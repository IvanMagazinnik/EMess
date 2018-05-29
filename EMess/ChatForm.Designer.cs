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
            this.LoginButton = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.DialogForm = new System.Windows.Forms.Panel();
            this.ChatTextBox = new System.Windows.Forms.RichTextBox();
            this.TextInputPanel = new System.Windows.Forms.Panel();
            this.SendMsgTextBox = new System.Windows.Forms.RichTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SendButton = new System.Windows.Forms.Button();
            this.emailField = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ChatStatusLabel = new System.Windows.Forms.Label();
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
            this.LoginForm.Controls.Add(this.StatusLabel);
            this.LoginForm.Controls.Add(this.emailLabel);
            this.LoginForm.Controls.Add(this.RegisterButton);
            this.LoginForm.Controls.Add(this.emailField);
            this.LoginForm.Controls.Add(this.LoginButton);
            this.LoginForm.Controls.Add(this.passwordField);
            this.LoginForm.Controls.Add(this.userNameField);
            this.LoginForm.Controls.Add(this.PasswordLabel);
            this.LoginForm.Controls.Add(this.UserNameLabel);
            this.LoginForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginForm.Location = new System.Drawing.Point(299, 63);
            this.LoginForm.Name = "LoginForm";
            this.LoginForm.Size = new System.Drawing.Size(980, 729);
            this.LoginForm.TabIndex = 2;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(395, 361);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(494, 264);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(100, 20);
            this.passwordField.TabIndex = 3;
            // 
            // userNameField
            // 
            this.userNameField.Location = new System.Drawing.Point(494, 235);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(100, 20);
            this.userNameField.TabIndex = 2;
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
            // ChatTextBox
            // 
            this.ChatTextBox.Location = new System.Drawing.Point(207, 0);
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.Size = new System.Drawing.Size(604, 619);
            this.ChatTextBox.TabIndex = 1;
            this.ChatTextBox.Text = "";
            // 
            // TextInputPanel
            // 
            this.TextInputPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TextInputPanel.Controls.Add(this.ChatStatusLabel);
            this.TextInputPanel.Controls.Add(this.SendButton);
            this.TextInputPanel.Controls.Add(this.SendMsgTextBox);
            this.TextInputPanel.Location = new System.Drawing.Point(0, 625);
            this.TextInputPanel.Name = "TextInputPanel";
            this.TextInputPanel.Size = new System.Drawing.Size(980, 104);
            this.TextInputPanel.TabIndex = 0;
            // 
            // SendMsgTextBox
            // 
            this.SendMsgTextBox.Location = new System.Drawing.Point(207, 0);
            this.SendMsgTextBox.Name = "SendMsgTextBox";
            this.SendMsgTextBox.Size = new System.Drawing.Size(604, 104);
            this.SendMsgTextBox.TabIndex = 0;
            this.SendMsgTextBox.Text = "";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(859, 18);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(494, 290);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(100, 20);
            this.emailField.TabIndex = 5;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(489, 361);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(353, 293);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(463, 334);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 13);
            this.StatusLabel.TabIndex = 8;
            // 
            // ChatStatusLabel
            // 
            this.ChatStatusLabel.AutoSize = true;
            this.ChatStatusLabel.Location = new System.Drawing.Point(880, 0);
            this.ChatStatusLabel.Name = "ChatStatusLabel";
            this.ChatStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.ChatStatusLabel.TabIndex = 2;
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
            this.TextInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel LoginForm;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Panel DialogForm;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Panel TextInputPanel;
        private System.Windows.Forms.RichTextBox SendMsgTextBox;
        private System.Windows.Forms.RichTextBox ChatTextBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label ChatStatusLabel;
    }
}

