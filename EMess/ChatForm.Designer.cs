namespace EMess
{
    partial class ChatForm
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
            this.components = new System.ComponentModel.Container();
            this.sidebar = new System.Windows.Forms.Panel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.LoginForm = new System.Windows.Forms.Panel();
            this.DialogForm = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.TextInputPanel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ChatTextBox = new System.Windows.Forms.RichTextBox();
            this.sidebar.SuspendLayout();
            this.LoginForm.SuspendLayout();
            this.DialogForm.SuspendLayout();
            this.TextInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.sidebar.Controls.Add(this.LogoLabel);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(299, 792);
            this.sidebar.TabIndex = 0;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LogoLabel.Location = new System.Drawing.Point(41, 31);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(92, 33);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "EMess";
            // 
            // header
            // 
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(299, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(980, 63);
            this.header.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.LoginForm.Controls.Add(this.LoginButton);
            this.LoginForm.Controls.Add(this.textBox2);
            this.LoginForm.Controls.Add(this.textBox1);
            this.LoginForm.Controls.Add(this.PasswordLabel);
            this.LoginForm.Controls.Add(this.UserNameLabel);
            this.LoginForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginForm.Location = new System.Drawing.Point(299, 63);
            this.LoginForm.Name = "LoginForm";
            this.LoginForm.Size = new System.Drawing.Size(980, 729);
            this.LoginForm.TabIndex = 2;
            // 
            // DialogForm
            // 
            this.DialogForm.Controls.Add(this.ChatTextBox);
            this.DialogForm.Controls.Add(this.TextInputPanel);
            this.DialogForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DialogForm.Location = new System.Drawing.Point(299, 63);
            this.DialogForm.Name = "DialogForm";
            this.DialogForm.Size = new System.Drawing.Size(980, 729);
            this.DialogForm.TabIndex = 5;
            this.DialogForm.Visible = false;
            this.DialogForm.VisibleChanged += new System.EventHandler(this.DialogForm_VisibleChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(425, 328);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(494, 264);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(494, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(353, 267);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(350, 235);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(60, 13);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "User Name";
            // 
            // TextInputPanel
            // 
            this.TextInputPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TextInputPanel.Controls.Add(this.richTextBox1);
            this.TextInputPanel.Location = new System.Drawing.Point(0, 625);
            this.TextInputPanel.Name = "TextInputPanel";
            this.TextInputPanel.Size = new System.Drawing.Size(980, 104);
            this.TextInputPanel.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(207, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(604, 104);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.Location = new System.Drawing.Point(207, 0);
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.Size = new System.Drawing.Size(604, 619);
            this.ChatTextBox.TabIndex = 1;
            this.ChatTextBox.Text = "";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1279, 792);
            this.Controls.Add(this.DialogForm);
            this.Controls.Add(this.LoginForm);
            this.Controls.Add(this.header);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatForm";
            this.Text = "Form1";
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.LoginForm.ResumeLayout(false);
            this.LoginForm.PerformLayout();
            this.DialogForm.ResumeLayout(false);
            this.TextInputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel LoginForm;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Panel DialogForm;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Panel TextInputPanel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox ChatTextBox;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

