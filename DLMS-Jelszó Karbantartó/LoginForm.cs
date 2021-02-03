using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLMS_Jelszó_Karbantartó
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            EntriListBox.DataSource = Enum.GetValues(typeof(EntriPoints));
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            LoginAttempt();
        }

        public void LoginAttempt()
        {
            EntriPoints entri = HelperClass.Instance.ParseEnum<EntriPoints>(EntriListBox.SelectedItem.ToString());
            string uName = UserNameTextBox.Text;
            string passw = PasswordTextBox.Text;
            if (HelperClass.Instance.CanLogin(entri, uName, passw))
            {
                this.Hide();

            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                LoginAttempt();
            }
        }
    }
}
