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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.LoginForm.Hide();
            this.DialogForm.Show();
        }

        private void DialogForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.DialogForm.Visible)
            {
                // do update load fields from conversation class;
            }
        }
    }
}
