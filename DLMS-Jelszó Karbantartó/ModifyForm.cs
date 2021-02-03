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
    public partial class ModifyForm : Form
    {
        int index;
       
        public ModifyForm(int selectedIndex)
        {
            InitializeComponent();
            EntriListBox.DataSource = Enum.GetValues(typeof(EntriPoints));
            User u = HelperClass.Instance.Users[selectedIndex];
            index = selectedIndex;
            EntriListBox.SelectedItem = HelperClass.Instance.ParseEnum <EntriPoints>( u.EntriPoint.ToString());
            UserNameTextBox.Text = u.UserName;
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            User u = HelperClass.Instance.Users[index];
            if (HelperClass.Instance.Change(u.EntriPoint, HelperClass.Instance.ParseEnum<EntriPoints>(EntriListBox.SelectedItem.ToString()),
                u.UserName, UserNameTextBox.Text,
                OldPasswordTextBox.Text, NewPasswordTextBox.Text
                ))
                this.Close();
            else
                HelperClass.Instance.ShowMassage("Nem megfelelő az aktuális jelszó!");
        }

        private void OldPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            NewPasswordTextBox.Text = OldPasswordTextBox.Text;
        }
    }
}
