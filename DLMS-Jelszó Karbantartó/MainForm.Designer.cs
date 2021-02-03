
namespace DLMS_Jelszó_Karbantartó
{
    partial class MainForm
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
            this.LogInLabel = new System.Windows.Forms.Label();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.NewUserBtn = new System.Windows.Forms.Button();
            this.ChangePwdBtn = new System.Windows.Forms.Button();
            this.DeleteUserBtn = new System.Windows.Forms.Button();
            this.LogedInUserLabel = new System.Windows.Forms.Label();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.UserListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // LogInLabel
            // 
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.LogInLabel.Location = new System.Drawing.Point(9, 12);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(172, 23);
            this.LogInLabel.TabIndex = 0;
            this.LogInLabel.Text = "Belépett felhasználó: ";
            // 
            // LogInBtn
            // 
            this.LogInBtn.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogInBtn.Location = new System.Drawing.Point(12, 65);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(219, 47);
            this.LogInBtn.TabIndex = 5;
            this.LogInBtn.Text = "Bejelentkezés";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // NewUserBtn
            // 
            this.NewUserBtn.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.NewUserBtn.Location = new System.Drawing.Point(12, 118);
            this.NewUserBtn.Name = "NewUserBtn";
            this.NewUserBtn.Size = new System.Drawing.Size(219, 47);
            this.NewUserBtn.TabIndex = 7;
            this.NewUserBtn.Text = "Új felhasználó hozzáadása";
            this.NewUserBtn.UseVisualStyleBackColor = true;
            this.NewUserBtn.Visible = false;
            this.NewUserBtn.Click += new System.EventHandler(this.NewUserBtn_Click);
            // 
            // ChangePwdBtn
            // 
            this.ChangePwdBtn.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.ChangePwdBtn.Location = new System.Drawing.Point(13, 171);
            this.ChangePwdBtn.Name = "ChangePwdBtn";
            this.ChangePwdBtn.Size = new System.Drawing.Size(218, 47);
            this.ChangePwdBtn.TabIndex = 8;
            this.ChangePwdBtn.Text = "Felhasználó módosítása";
            this.ChangePwdBtn.UseVisualStyleBackColor = true;
            this.ChangePwdBtn.Visible = false;
            this.ChangePwdBtn.Click += new System.EventHandler(this.ChangePwdBtn_Click);
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.DeleteUserBtn.Location = new System.Drawing.Point(12, 224);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(219, 47);
            this.DeleteUserBtn.TabIndex = 9;
            this.DeleteUserBtn.Text = "Felhasználó törlése";
            this.DeleteUserBtn.UseVisualStyleBackColor = true;
            this.DeleteUserBtn.Visible = false;
            this.DeleteUserBtn.Click += new System.EventHandler(this.DeleteUserBtn_Click);
            // 
            // LogedInUserLabel
            // 
            this.LogedInUserLabel.AutoSize = true;
            this.LogedInUserLabel.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.LogedInUserLabel.Location = new System.Drawing.Point(12, 35);
            this.LogedInUserLabel.Name = "LogedInUserLabel";
            this.LogedInUserLabel.Size = new System.Drawing.Size(28, 23);
            this.LogedInUserLabel.TabIndex = 10;
            this.LogedInUserLabel.Text = "---";
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.LogOutBtn.Location = new System.Drawing.Point(12, 277);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(219, 47);
            this.LogOutBtn.TabIndex = 11;
            this.LogOutBtn.Text = "Kijelentkezés";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Visible = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // UserListView
            // 
            this.UserListView.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.UserListView.FullRowSelect = true;
            this.UserListView.GridLines = true;
            this.UserListView.HideSelection = false;
            this.UserListView.Location = new System.Drawing.Point(237, 12);
            this.UserListView.Name = "UserListView";
            this.UserListView.Size = new System.Drawing.Size(406, 312);
            this.UserListView.TabIndex = 13;
            this.UserListView.UseCompatibleStateImageBehavior = false;
            this.UserListView.View = System.Windows.Forms.View.Details;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 339);
            this.Controls.Add(this.UserListView);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.LogedInUserLabel);
            this.Controls.Add(this.DeleteUserBtn);
            this.Controls.Add(this.ChangePwdBtn);
            this.Controls.Add(this.NewUserBtn);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.LogInLabel);
            this.Name = "MainForm";
            this.Text = "Jelszó karbantartó";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Button NewUserBtn;
        private System.Windows.Forms.Button ChangePwdBtn;
        private System.Windows.Forms.Button DeleteUserBtn;
        private System.Windows.Forms.Label LogedInUserLabel;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.ListView UserListView;
    }
}

