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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            HelperClass.Instance.OnLogedInUserChanged += Instance_OnLogedInUserChanged;
            HelperClass.Instance.OnUserFileChanged += Instance_OnUserFileChanged;
        }

        private void Instance_OnUserFileChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void Instance_OnLogedInUserChanged(object sender, EventArgs e)
        {
            LogedInUserLabel.Text = HelperClass.Instance.LogedInUser.UserName;
            if (HelperClass.Instance.LogedInUser != null)
            {
                LoadUsers();
                TogleBtns();
            }
        }

        private void LoadUsers()
        {
            UserListView.Clear();
            UserListView.Columns.Add("Belépési Pont");
            UserListView.Columns.Add("Felhasználónév");
            UserListView.Columns.Add("Hashelt Jelszó");
            foreach (User u in HelperClass.Instance.Users)
            {
                ListViewItem item = new ListViewItem();
                item.Text = u.EntriPoint.ToString();
                item.SubItems.Add(u.UserName);
                item.SubItems.Add(u.PasswordHash);
                UserListView.Items.Add(item);
            }
            UserListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            UserListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            UserListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void TogleBtns()
        {
            LogInBtn.Visible = !LogInBtn.Visible;
            ChangePwdBtn.Visible = !ChangePwdBtn.Visible;
            DeleteUserBtn.Visible = !DeleteUserBtn.Visible;
            LogOutBtn.Visible = !LogOutBtn.Visible;
            NewUserBtn.Visible = !NewUserBtn.Visible;
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LogedInUserLabel.Text = "---";
            HelperClass.Instance.LogedInUser = null;
            TogleBtns();
            UserListView.Clear();
        }

        private void NewUserBtn_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();
            createForm.Show();
        }

        private void ChangePwdBtn_Click(object sender, EventArgs e)
        {
            if (IsSelected())
            {
                ModifyForm modifyForm = new ModifyForm(UserListView.SelectedIndices[0]);

                modifyForm.Show();
            }
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            if (IsSelected())
            {
                DialogResult dialogResult = HelperClass.Instance.ShowMassage("Biztosan törölni szeretné a kiválasztott felhasználót?", "Felhasználó törlése!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    HelperClass.Instance.Users.RemoveAt(UserListView.SelectedIndices[0]);
                    HelperClass.Instance.UpdateUsers();
                    LoadUsers();
                }
            }
        }

        private bool IsSelected()
        {
            if (UserListView.SelectedIndices.Count > 0)
                return true;
            HelperClass.Instance.ShowMassage("Először ki kell választani egy felhasználót!");
            return false;
        }
    }
}
