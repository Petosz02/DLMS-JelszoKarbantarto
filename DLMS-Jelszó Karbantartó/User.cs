using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLMS_Jelszó_Karbantartó
{

    public enum EntriPoints
    {
        WEB,
        PROGRAM,
        TERMINÁL
    }

    [Serializable]
    class User
    {

        private EntriPoints entriPoint;
        private string userName;
        private string passwordHash;

        public string UserName { get => userName; }
        public string PasswordHash { get => passwordHash; }
        public EntriPoints EntriPoint { get => entriPoint; }

        public override string ToString()
        {
            return "Belépési pont: " + entriPoint + ", felhasználónév: " + userName + ", hashelt jelszó: " + passwordHash;
        }

        public bool Equals(User other)
        {
            if (other == null) return false;
            return (this.userName.Equals(other.userName));
        }
        public User()
        {

        }

        public User(EntriPoints entriPoint, string userName, string passwordHash)
        {
            this.entriPoint = entriPoint;
            this.userName = userName;
            this.passwordHash = passwordHash;
        }

        public void Change(EntriPoints entri, string userName)
        {
            entriPoint = entri;
            this.userName = userName;
            HelperClass.Instance.UpdateUsers();
        }

        public bool SetPassword(string oldPwd, string newPwd)
        {
            string oldB64 = HelperClass.Instance.ToB64(oldPwd);
            string newB64 = HelperClass.Instance.ToB64(newPwd);
            if (passwordHash == oldB64)
            {
                passwordHash = newB64;
                return true;
            }
            return false;
        }
    }
}
