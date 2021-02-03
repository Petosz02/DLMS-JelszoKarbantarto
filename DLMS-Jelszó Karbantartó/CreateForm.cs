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
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
            EntriListBox.DataSource = Enum.GetValues(typeof(EntriPoints));
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            HelperClass.Instance.AddUser(HelperClass.Instance.ParseEnum<EntriPoints>(EntriListBox.SelectedItem.ToString()), UserNameTextBox.Text, PasswordTextBox.Text);
            HelperClass.Instance.ShowMassage(UserNameTextBox.Text + " felhasználó hozzáadva");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = HelperClass.Instance.ShowMassage("Biztos nem szeretne több felhasználót létrehozni?", "Felhasználó létrehozása", MessageBoxButtons.YesNo);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
