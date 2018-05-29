using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMess
{

    public partial class ChatForm : Form
    {
        private Conversation currentConversation;
        public ChatForm()
        {
            InitializeComponent();
        }

        public void UpdateDialog(Conversation conv)
        {
            currentConversation = conv;
            this.DialogForm.Hide();
            this.DialogForm.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            updateMessagies(currentConversation);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            RequestResponse resp;
            LoginRequest request = new LoginRequest();
            String uname = this.userNameField.Text;
            String pass = this.passwordField.Text;
            String email = this.emailField.Text;
            List<String> args = new List<string>();
            args.Add(uname);
            args.Add(pass);
            args.Add(email);
            resp = request.SendRequest(args);
            if (resp == Request.SuccessResponse)
            {
                this.LoginForm.Hide();
                this.DialogForm.Show();
                Timer timer = new Timer();
                timer.Interval = (10 * 1000); // 10 secs
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
                return;
            }
            if (resp == Request.NetworkErrorResponse)
            {
                this.StatusLabel.Text = "Network Unreacheble";
            }
            else {
                if (resp.Status != 0)
                {
                    this.StatusLabel.Text = "Incorrect User name or password inserted";
                }

            }

//            this.LoginForm.Hide();
//            this.DialogForm.Show();
        }

        private void DialogForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.DialogForm.Visible)
            {
                // do update load fields from conversation class;
            }
        }

        private void updateMessagies(Conversation conv)
        {
            RequestResponse resp;
            GetMessageRequest request = new GetMessageRequest();
            List<String> args = new List<string>();
            resp = request.SendRequest(args);
            if (resp == Request.SuccessResponse)
            {
                this.ChatTextBox.Text = "";
                this.ChatTextBox.Text = resp.Data;
                return;
            }
            if (resp == Request.NetworkErrorResponse)
            {
                this.ChatStatusLabel.Text = "Network Unreacheble";
            }
            else
            {

            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            RequestResponse resp;
            SendMessageRequest request = new SendMessageRequest();
            string text = this.SendMsgTextBox.Text;
            List<String> args = new List<string>();
            args.Add(text);
            resp = request.SendRequest(args);

            if (resp == Request.SuccessResponse)
            {
                this.updateMessagies(currentConversation);
                return;
            }
            if (resp == Request.NetworkErrorResponse)
            {
                this.ChatStatusLabel.Text = "Network Unreacheble";
            }
            else
            {

            }
        }
    }
}
