using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using System.Threading;
using MQTTnet.Server;
using MQTTnet;
using System.Net;
using MQTTnet.Protocol;

namespace akuaTool_Mqtt
{
    public partial class Form2 : MaterialForm
    {
        static bool isServerOnline = false;
        static MqttServer mqttServer = new MqttFactory().CreateMqttServer() as MqttServer;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            AddHandlerForMqttServer();
        }

        private void MaterialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private async void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            if (isServerOnline == false)
            {
                var optionsBuilder = new MqttServerOptionsBuilder()
                    .WithDefaultEndpointBoundIPAddress(IPAddress.Parse(this.materialSingleLineTextField_ip.Text))
                    .WithConnectionBacklog(100)
                    .WithDefaultEndpointPort(int.Parse(this.materialSingleLineTextField_port.Text))
                    .WithConnectionValidator(c =>
                    {
                        if (c.ClientId.Length < 10)
                        {
                            c.ReturnCode = MqttConnectReturnCode.ConnectionRefusedIdentifierRejected;
                            return;
                        }

                        if (c.Username != this.materialSingleLineTextField_user.Text)
                        {
                            c.ReturnCode = MqttConnectReturnCode.ConnectionRefusedBadUsernameOrPassword;
                            return;
                        }

                        if (c.Password != this.materialSingleLineTextField_pass.Text)
                        {
                            c.ReturnCode = MqttConnectReturnCode.ConnectionRefusedBadUsernameOrPassword;
                            return;
                        }

                        c.ReturnCode = MqttConnectReturnCode.ConnectionAccepted;
                    });
                try
                {
                    await mqttServer.StartAsync(optionsBuilder.Build());
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                try
                {
                    await mqttServer.StopAsync();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }               
            }
        }

        private void AddHandlerForMqttServer()
        {
            mqttServer.StartedHandler = new MqttServerStartedHandlerDelegate(new Action<EventArgs>((err) =>
            {
                var status = mqttServer.GetSessionStatusAsync();
                isServerOnline = true;
                Invoke((new Action(() =>
                {
                    this.materialFlatButton1.Text = "disconn";
                })));

            }));
            mqttServer.StoppedHandler = new MqttServerStoppedHandlerDelegate(new Action<EventArgs>((err)=>
            {
                isServerOnline = false;
                Invoke((new Action(() =>
                {
                    this.materialFlatButton1.Text = "conn";
                })));
            }));
        }
    }
}
