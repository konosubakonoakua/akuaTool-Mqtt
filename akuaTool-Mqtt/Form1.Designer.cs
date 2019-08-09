namespace akuaTool_Mqtt
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_server = new System.Windows.Forms.Label();
            this.textBox_recv = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_port = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_pub = new System.Windows.Forms.Label();
            this.textBox_server = new System.Windows.Forms.TextBox();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_pub = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.textBox_sub = new System.Windows.Forms.TextBox();
            this.label_sub = new System.Windows.Forms.Label();
            this.btn_conn = new System.Windows.Forms.Button();
            this.btn_pub = new System.Windows.Forms.Button();
            this.numericUpDown_port = new System.Windows.Forms.NumericUpDown();
            this.btn_sub = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port)).BeginInit();
            this.SuspendLayout();
            // 
            // label_server
            // 
            this.label_server.AutoSize = true;
            this.label_server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_server.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_server.ForeColor = System.Drawing.Color.Red;
            this.label_server.Location = new System.Drawing.Point(10, 27);
            this.label_server.Margin = new System.Windows.Forms.Padding(3);
            this.label_server.Name = "label_server";
            this.label_server.Size = new System.Drawing.Size(69, 31);
            this.label_server.TabIndex = 0;
            this.label_server.Text = "Server";
            // 
            // textBox_recv
            // 
            this.textBox_recv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_recv.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox_recv.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_recv.Location = new System.Drawing.Point(279, 37);
            this.textBox_recv.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_recv.Multiline = true;
            this.textBox_recv.Name = "textBox_recv";
            this.textBox_recv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_recv.Size = new System.Drawing.Size(736, 380);
            this.textBox_recv.TabIndex = 1;
            this.textBox_recv.Text = "我是接收框(╹ڡ╹ )";
            this.textBox_recv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.textBox_recv.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.textBox_recv.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.textBox_recv.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.clearAllToolStripMenuItem.Text = "clearAll";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.ClearAllToolStripMenuItem_Click);
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_port.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_port.Location = new System.Drawing.Point(10, 64);
            this.label_port.Margin = new System.Windows.Forms.Padding(3);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(47, 31);
            this.label_port.TabIndex = 2;
            this.label_port.Text = "Port";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_user.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(12, 101);
            this.label_user.Margin = new System.Windows.Forms.Padding(3);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(51, 31);
            this.label_user.TabIndex = 3;
            this.label_user.Text = "User";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_pass.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.Location = new System.Drawing.Point(12, 138);
            this.label_pass.Margin = new System.Windows.Forms.Padding(3);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(52, 31);
            this.label_pass.TabIndex = 4;
            this.label_pass.Text = "Pass";
            // 
            // label_pub
            // 
            this.label_pub.AutoSize = true;
            this.label_pub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_pub.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pub.Location = new System.Drawing.Point(12, 175);
            this.label_pub.Margin = new System.Windows.Forms.Padding(3);
            this.label_pub.Name = "label_pub";
            this.label_pub.Size = new System.Drawing.Size(43, 31);
            this.label_pub.TabIndex = 5;
            this.label_pub.Text = "Pub";
            // 
            // textBox_server
            // 
            this.textBox_server.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_server.Location = new System.Drawing.Point(85, 37);
            this.textBox_server.Name = "textBox_server";
            this.textBox_server.Size = new System.Drawing.Size(180, 25);
            this.textBox_server.TabIndex = 6;
            this.textBox_server.Text = "127.0.0.1";
            // 
            // textBox_user
            // 
            this.textBox_user.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user.Location = new System.Drawing.Point(85, 111);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(180, 25);
            this.textBox_user.TabIndex = 8;
            this.textBox_user.Text = "admin";
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass.Location = new System.Drawing.Point(85, 148);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '#';
            this.textBox_pass.Size = new System.Drawing.Size(180, 25);
            this.textBox_pass.TabIndex = 9;
            this.textBox_pass.Text = "admin";
            this.textBox_pass.TextChanged += new System.EventHandler(this.TextBox_pass_TextChanged);
            // 
            // textBox_pub
            // 
            this.textBox_pub.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pub.Location = new System.Drawing.Point(85, 185);
            this.textBox_pub.Name = "textBox_pub";
            this.textBox_pub.Size = new System.Drawing.Size(180, 25);
            this.textBox_pub.TabIndex = 10;
            this.textBox_pub.Text = "/node/1801/14DC16286F24/sts";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.serverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.quitToolStripMenuItem.Text = "Quit(&Q)";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.serverToolStripMenuItem.Text = "Server(&S)";
            this.serverToolStripMenuItem.Click += new System.EventHandler(this.ServerToolStripMenuItem_Click);
            // 
            // textBox_send
            // 
            this.textBox_send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_send.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox_send.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_send.Location = new System.Drawing.Point(18, 349);
            this.textBox_send.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_send.Size = new System.Drawing.Size(247, 68);
            this.textBox_send.TabIndex = 12;
            this.textBox_send.Text = "我是发送框ヾ(•ω•`)o";
            // 
            // textBox_sub
            // 
            this.textBox_sub.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sub.Location = new System.Drawing.Point(85, 222);
            this.textBox_sub.Name = "textBox_sub";
            this.textBox_sub.Size = new System.Drawing.Size(180, 25);
            this.textBox_sub.TabIndex = 14;
            this.textBox_sub.Text = "/node/1801/14DC16286F24/sts";
            // 
            // label_sub
            // 
            this.label_sub.AutoSize = true;
            this.label_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_sub.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sub.ForeColor = System.Drawing.Color.Black;
            this.label_sub.Location = new System.Drawing.Point(12, 212);
            this.label_sub.Margin = new System.Windows.Forms.Padding(3);
            this.label_sub.Name = "label_sub";
            this.label_sub.Size = new System.Drawing.Size(43, 31);
            this.label_sub.TabIndex = 13;
            this.label_sub.Text = "Sub";
            // 
            // btn_conn
            // 
            this.btn_conn.BackColor = System.Drawing.Color.Red;
            this.btn_conn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conn.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conn.Location = new System.Drawing.Point(18, 276);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(72, 49);
            this.btn_conn.TabIndex = 15;
            this.btn_conn.Text = "conn";
            this.btn_conn.UseVisualStyleBackColor = false;
            this.btn_conn.Click += new System.EventHandler(this.Btn_conn_Click);
            // 
            // btn_pub
            // 
            this.btn_pub.BackColor = System.Drawing.Color.Red;
            this.btn_pub.Enabled = false;
            this.btn_pub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pub.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pub.Location = new System.Drawing.Point(197, 276);
            this.btn_pub.Name = "btn_pub";
            this.btn_pub.Size = new System.Drawing.Size(68, 49);
            this.btn_pub.TabIndex = 16;
            this.btn_pub.Text = "pub";
            this.btn_pub.UseVisualStyleBackColor = false;
            this.btn_pub.Click += new System.EventHandler(this.Btn_pub_Click);
            // 
            // numericUpDown_port
            // 
            this.numericUpDown_port.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_port.Location = new System.Drawing.Point(85, 74);
            this.numericUpDown_port.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_port.Name = "numericUpDown_port";
            this.numericUpDown_port.Size = new System.Drawing.Size(180, 25);
            this.numericUpDown_port.TabIndex = 18;
            this.numericUpDown_port.Value = new decimal(new int[] {
            1883,
            0,
            0,
            0});
            this.numericUpDown_port.ValueChanged += new System.EventHandler(this.NumericUpDown_port_ValueChanged);
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.Color.Red;
            this.btn_sub.Enabled = false;
            this.btn_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sub.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sub.Location = new System.Drawing.Point(111, 276);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(68, 49);
            this.btn_sub.TabIndex = 19;
            this.btn_sub.Text = "sub";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.Btn_sub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 426);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.numericUpDown_port);
            this.Controls.Add(this.btn_pub);
            this.Controls.Add(this.btn_conn);
            this.Controls.Add(this.textBox_sub);
            this.Controls.Add(this.label_sub);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.textBox_pub);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.textBox_server);
            this.Controls.Add(this.label_pub);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.textBox_recv);
            this.Controls.Add(this.label_server);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "akuaMqttTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_server;
        private System.Windows.Forms.TextBox textBox_recv;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_pub;
        private System.Windows.Forms.TextBox textBox_server;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_pub;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.TextBox textBox_sub;
        private System.Windows.Forms.Label label_sub;
        private System.Windows.Forms.Button btn_conn;
        private System.Windows.Forms.Button btn_pub;
        private System.Windows.Forms.NumericUpDown numericUpDown_port;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
    }
}

