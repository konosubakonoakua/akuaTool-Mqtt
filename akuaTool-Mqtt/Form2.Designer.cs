namespace akuaTool_Mqtt
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialSingleLineTextField_ip = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField_port = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField_user = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialSingleLineTextField_pass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // materialSingleLineTextField_ip
            // 
            this.materialSingleLineTextField_ip.Depth = 0;
            this.materialSingleLineTextField_ip.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSingleLineTextField_ip.Hint = "";
            this.materialSingleLineTextField_ip.Location = new System.Drawing.Point(12, 78);
            this.materialSingleLineTextField_ip.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField_ip.Name = "materialSingleLineTextField_ip";
            this.materialSingleLineTextField_ip.PasswordChar = '\0';
            this.materialSingleLineTextField_ip.SelectedText = "";
            this.materialSingleLineTextField_ip.SelectionLength = 0;
            this.materialSingleLineTextField_ip.SelectionStart = 0;
            this.materialSingleLineTextField_ip.Size = new System.Drawing.Size(242, 23);
            this.materialSingleLineTextField_ip.TabIndex = 1;
            this.materialSingleLineTextField_ip.Text = "127.0.0.1";
            this.materialSingleLineTextField_ip.UseSystemPasswordChar = false;
            this.materialSingleLineTextField_ip.Click += new System.EventHandler(this.MaterialSingleLineTextField1_Click);
            // 
            // materialSingleLineTextField_port
            // 
            this.materialSingleLineTextField_port.Depth = 0;
            this.materialSingleLineTextField_port.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSingleLineTextField_port.Hint = "";
            this.materialSingleLineTextField_port.Location = new System.Drawing.Point(13, 119);
            this.materialSingleLineTextField_port.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField_port.Name = "materialSingleLineTextField_port";
            this.materialSingleLineTextField_port.PasswordChar = '\0';
            this.materialSingleLineTextField_port.SelectedText = "";
            this.materialSingleLineTextField_port.SelectionLength = 0;
            this.materialSingleLineTextField_port.SelectionStart = 0;
            this.materialSingleLineTextField_port.Size = new System.Drawing.Size(242, 23);
            this.materialSingleLineTextField_port.TabIndex = 2;
            this.materialSingleLineTextField_port.Text = "1883";
            this.materialSingleLineTextField_port.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField_user
            // 
            this.materialSingleLineTextField_user.Depth = 0;
            this.materialSingleLineTextField_user.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSingleLineTextField_user.Hint = "";
            this.materialSingleLineTextField_user.Location = new System.Drawing.Point(12, 158);
            this.materialSingleLineTextField_user.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField_user.Name = "materialSingleLineTextField_user";
            this.materialSingleLineTextField_user.PasswordChar = '\0';
            this.materialSingleLineTextField_user.SelectedText = "";
            this.materialSingleLineTextField_user.SelectionLength = 0;
            this.materialSingleLineTextField_user.SelectionStart = 0;
            this.materialSingleLineTextField_user.Size = new System.Drawing.Size(242, 23);
            this.materialSingleLineTextField_user.TabIndex = 3;
            this.materialSingleLineTextField_user.Text = "admin";
            this.materialSingleLineTextField_user.UseSystemPasswordChar = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialFlatButton1.Location = new System.Drawing.Point(0, 246);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(266, 36);
            this.materialFlatButton1.TabIndex = 4;
            this.materialFlatButton1.Text = "LinkStart";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1_Click);
            // 
            // materialSingleLineTextField_pass
            // 
            this.materialSingleLineTextField_pass.Depth = 0;
            this.materialSingleLineTextField_pass.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSingleLineTextField_pass.Hint = "";
            this.materialSingleLineTextField_pass.Location = new System.Drawing.Point(13, 195);
            this.materialSingleLineTextField_pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField_pass.Name = "materialSingleLineTextField_pass";
            this.materialSingleLineTextField_pass.PasswordChar = '#';
            this.materialSingleLineTextField_pass.SelectedText = "";
            this.materialSingleLineTextField_pass.SelectionLength = 0;
            this.materialSingleLineTextField_pass.SelectionStart = 0;
            this.materialSingleLineTextField_pass.Size = new System.Drawing.Size(242, 23);
            this.materialSingleLineTextField_pass.TabIndex = 5;
            this.materialSingleLineTextField_pass.Text = "admin";
            this.materialSingleLineTextField_pass.UseSystemPasswordChar = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(266, 282);
            this.Controls.Add(this.materialSingleLineTextField_pass);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialSingleLineTextField_user);
            this.Controls.Add(this.materialSingleLineTextField_port);
            this.Controls.Add(this.materialSingleLineTextField_ip);
            this.Name = "Form2";
            this.Text = "Server Setup";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField_ip;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField_port;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField_user;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField_pass;
    }
}