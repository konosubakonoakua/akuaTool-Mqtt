using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet;
//using MQTTnet.Client.Connecting;
using MQTTnet.Client;
using MQTTnet.Client.Options;
//using MQTTnet.Packets;
//using MQTTnet.Protocol;
//using MQTTnet.Client.Receiving;
//using MQTTnet.Client.Disconnecting;
using Newtonsoft.Json;

namespace akuaTool_Mqtt
{
    public partial class Form1 : Form
    {
        static bool isMoveFormEnabled = false;
        static Point mouseDownPos = new Point(0, 0);
        private MqttClient mqttClient = new MqttFactory().CreateMqttClient() as MqttClient;
        private IMqttClientOptions mqttClientOptions = null;
        private string clientName = null;
        private string mqttTopicPub = null;
        private string mqttTopicSub = null;
        private static string localAppDataLocation = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private string userConfigLocation = localAppDataLocation + @"\akuaTool-Mqtt\config.json";
        private Hashtable userConfig = new Hashtable { };
        private Form2 fm2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            userConfig.Add("server", this.textBox_server.Text);
            userConfig.Add("port", this.numericUpDown_port.Value.ToString());
            userConfig.Add("user", this.textBox_user.Text);
            userConfig.Add("pass", this.textBox_pass.Text);
            userConfig.Add("sub", this.textBox_sub.Text);
            userConfig.Add("pub", this.textBox_pub.Text);
            userConfig.Add("local_server_ip", fm2.materialSingleLineTextField_ip.Text);
            userConfig.Add("local_server_port", fm2.materialSingleLineTextField_port.Text);
            userConfig.Add("local_server_user", fm2.materialSingleLineTextField_user.Text);
            userConfig.Add("local_server_pass", fm2.materialSingleLineTextField_pass.Text);
            userConfig = ReadConfigFile(userConfigLocation);
            clientName = DateTime.Now.ToFileTimeUtc().ToString(); // 使用当前时间作为client名称
            this.Text = "Client: " + clientName;
            mqttTopicPub = this.textBox_pub.Text;
            mqttTopicSub = this.textBox_sub.Text;
            Make_mqttClientOptions();
            Set_mqtt_delegates();
        }

        private Hashtable ReadConfigFile(string path)
        {

            string dir = System.IO.Path.GetDirectoryName(path); //获取文件路径
            //string name = System.IO.Path.GetFileName(path); //获取文件名

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            if (!File.Exists(path))
            {
                SaveConfigToFile(userConfig, path);
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = sr.ReadToEnd();
                Hashtable val = JsonConvert.DeserializeObject<Hashtable>(s);
                SetComponentsAttri(val);
                return val;
            }
        }

        private void SaveConfigToFile(Hashtable ht, string path)
        {

            userConfig["server"] = this.textBox_server.Text;
            userConfig["port"] = this.numericUpDown_port.Value.ToString();
            userConfig["user"] = this.textBox_user.Text;
            userConfig["pass"] = this.textBox_pass.Text;
            userConfig["sub"] = this.textBox_sub.Text;
            userConfig["pub"] = this.textBox_pub.Text;

            string json = JsonConvert.SerializeObject(userConfig, Formatting.Indented);
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(json);
            }
        }

        private void SetComponentsAttri(Hashtable ht)
        {
            //var ht = ReadConfigFile(userConfigLocation);
            if (ht != null)
            {
                try
                {
                    this.textBox_server.Text = (string)ht["server"];
                    this.numericUpDown_port.Value = int.Parse((string)ht["port"]);
                    this.textBox_user.Text = (string)ht["user"];
                    this.textBox_pass.Text = (string)ht["pass"];
                    this.textBox_sub.Text = (string)ht["sub"];
                    this.textBox_pub.Text = (string)ht["pub"];
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                isMoveFormEnabled = true;
                mouseDownPos = e.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoveFormEnabled == true)
            {
                var Form1Pos = Control.MousePosition;
                Form1Pos.Offset(-mouseDownPos.X, -mouseDownPos.Y);
                this.Location = Form1Pos;
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            isMoveFormEnabled = false;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isMoveFormEnabled = false;
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void Btn_conn_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn.Text == "conn")
            {
                Make_mqttClientOptions();
                try
                {
                    await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None); // Since 3.0.5 with CancellationToken
                }
                catch (Exception err)
                { 
                    Invoke((new Action(() =>
                    {
                        this.textBox_recv.AppendText(Environment.NewLine + err.ToString());
                    })));
                }
                Console.WriteLine(Environment.NewLine);
            }
            else
            {
                try
                {
                    await mqttClient.DisconnectAsync();
                }
                catch (Exception err)
                {
                    Invoke((new Action(() =>
                    {
                        this.textBox_recv.AppendText(Environment.NewLine + err.ToString());
                    })));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void Btn_pub_Click(object sender, EventArgs e)
        {
            mqttTopicPub = textBox_pub.Text;
            string payload = this.textBox_send.Text;
            var message = new MqttApplicationMessageBuilder()
                .WithTopic(mqttTopicPub)
                .WithPayload(payload)
                .WithExactlyOnceQoS()
                .Build();
            try
            {
                await mqttClient.PublishAsync(message);
            }
            catch (Exception err)
            {
                Invoke((new Action(() =>
                {
                    this.textBox_recv.AppendText(Environment.NewLine + err.ToString());
                })));
            }
        }

        private void NumericUpDown_port_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void Btn_sub_Click(object sender, EventArgs e)
        {
            mqttTopicSub = textBox_sub.Text;
            try
            {
                if (btn_sub.Text == "sub")
                {
                    await mqttClient.SubscribeAsync(new TopicFilterBuilder().WithTopic(mqttTopicSub).Build());
                    Invoke((new Action(() =>
                    {
                        this.textBox_recv.AppendText(Environment.NewLine + "### Sub Success ###");
                        this.btn_sub.BackColor = Color.Green;
                        this.btn_sub.Text = "unsub";
                    })));
                }
                else
                {
                    await mqttClient.UnsubscribeAsync(mqttTopicSub);
                    Invoke((new Action(() =>
                    {
                        this.textBox_recv.AppendText(Environment.NewLine + "### Sub Success ###");
                        this.btn_sub.BackColor = Color.Aqua;
                        this.btn_sub.Text = "sub";
                    })));
                }
            }
            catch (Exception err)
            {
                Invoke((new Action(() =>
                {
                    this.textBox_recv.AppendText(Environment.NewLine + err.ToString());
                })));
            }
        }

        private void Make_mqttClientOptions()
        {
            mqttClientOptions = new MqttClientOptionsBuilder()  // 构建mqtt连接配置
                .WithClientId(clientName)
                .WithTcpServer(textBox_server.Text, (int)this.numericUpDown_port.Value)
                .WithCredentials(textBox_user.Text, textBox_pass.Text)
                .Build();
        }

        private void Set_mqtt_delegates()
        {
            mqttClient.UseDisconnectedHandler(err =>
            {
                Invoke((new Action(() =>
                {
                    this.textBox_recv.AppendText("\r\n### DISCONNECTED FROM SERVER ###\r\n");
                })));
                //await Task.Delay(TimeSpan.FromSeconds(5));
                //try
                //{
                //    await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None); // Since 3.0.5 with CancellationToken
                //}
                //catch
                //{
                //    Invoke((new Action(() =>
                //    {
                //        this.textBox_recv.AppendText("\r\n### RECONNECTING FAILED ###\r\n");
                //    })));
                //}
                Change_ui_if_conn(false);

            });
            mqttClient.UseConnectedHandler(err =>
            {
                Invoke((new Action(() =>
                {
                    this.textBox_recv.AppendText("\r\n### CONNECTED ###\r\n");
                })));
                Change_ui_if_conn(true);
            });
            mqttClient.UseApplicationMessageReceivedHandler(e =>
            {
                //Console.WriteLine("### RECEIVED APPLICATION MESSAGE ###");
                //Console.WriteLine($"+ Topic = {e.ApplicationMessage.Topic}");
                //Console.WriteLine($"+ Payload = {Encoding.UTF8.GetString(e.ApplicationMessage.Payload)}");
                //Console.WriteLine($"+ QoS = {e.ApplicationMessage.QualityOfServiceLevel}");
                //Console.WriteLine($"+ Retain = {e.ApplicationMessage.Retain}");
                //Console.WriteLine();

                Invoke((new Action(() =>
                {
                    try
                    {
                        this.textBox_recv.AppendText(Environment.NewLine + DateTime.Now.ToString() + " from " + e.ClientId + ":    " + Encoding.UTF8.GetString(e.ApplicationMessage.Payload));
                        
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                })));

            });
        }

        private void Change_ui_if_conn(bool isConnected)
        {
            Invoke((new Action(() =>
            {
                if (isConnected == true)
                {
                    this.label_server.ForeColor = Color.Green;
                    this.btn_sub.BackColor = Color.Green;
                    this.btn_conn.BackColor = Color.Green;
                    this.btn_pub.BackColor = Color.Green;
                    this.btn_sub.BackColor = Color.Aqua;
                    this.btn_pub.Enabled = true;
                    this.btn_sub.Enabled = true;
                    this.btn_conn.Text = "disconn";
                }
                else
                {
                    this.label_server.ForeColor = Color.Red;
                    this.btn_sub.BackColor = Color.Red;
                    this.btn_conn.BackColor = Color.Red;
                    this.btn_pub.BackColor = Color.Red;
                    this.btn_sub.BackColor = Color.Red;
                    this.btn_pub.Enabled = false;
                    this.btn_sub.Enabled = false;
                    this.btn_conn.Text = "conn";
                    this.btn_sub.Text = "sub";
                }
            })));
        }

        private void TextBox_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SaveConfigToFile(userConfig, userConfigLocation);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void ClearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var strip = sender as ToolStripMenuItem;
            var textbox = (strip.GetCurrentParent() as ContextMenuStrip).SourceControl as TextBox;
            textbox.Clear();
        }

        private void ServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isfind = false;
            foreach (Form fm in Application.OpenForms)
            {
                //判断Form2是否存在，如果在激活并给予焦点
                if (fm.Name == "Form2")
                {
                    fm.WindowState = FormWindowState.Maximized;
                    fm.WindowState = FormWindowState.Normal;
                    fm.Activate();
                    return;
                }
            }
            //如果窗口不存在，打开窗口
            if (!isfind) {
                fm2 = new Form2();
                fm2.materialSingleLineTextField_ip.Text = (string)userConfig["local_server_ip"];
                fm2.materialSingleLineTextField_port.Text = (string)userConfig["local_server_port"];
                fm2.materialSingleLineTextField_user.Text = (string)userConfig["local_server_user"];
                fm2.materialSingleLineTextField_pass.Text = (string)userConfig["local_server_pass"];
                fm2.FormClosing += Form2_Closing;
                fm2.Show();
            }
        }

        private void Form2_Closing(object sender, EventArgs e)
        {
            userConfig["local_server_ip"] = fm2.materialSingleLineTextField_ip.Text;
            userConfig["local_server_port"] = fm2.materialSingleLineTextField_port.Text;
            userConfig["local_server_user"] = fm2.materialSingleLineTextField_user.Text;
            userConfig["local_server_pass"] = fm2.materialSingleLineTextField_pass.Text;            
        }

    }
}
