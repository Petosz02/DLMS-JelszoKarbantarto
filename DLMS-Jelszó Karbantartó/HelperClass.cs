using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLMS_Jelszó_Karbantartó
{
    class HelperClass
    {

        private const string FILE_NAME = "users.txt";

        private static HelperClass instance = null;
        public static HelperClass Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new HelperClass();
                }
                return instance;
            }
        }

        public event EventHandler OnLogedInUserChanged;
        public event EventHandler OnUserFileChanged;

        private List<User> users = new List<User>();
        public List<User> Users { get => users; }

        private User logedInUser = null;
        public User LogedInUser { get => logedInUser; set => logedInUser = value; }

        /// <summary>
        /// Átalakítja az adott szöveget Base64 kódolásra
        /// </summary>
        /// <param name="s"></param>
        /// <returns> Base64 szöveg </returns>
        public string ToB64(string s)
        {
            string base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
            return base64;
        }

        /// <summary>
        /// Base64 szöveget alakít át kódolatlan szöveggé
        /// </summary>
        /// <param name="s"></param>
        /// <returns> Dekódolt szöveg </returns>
        public string FromB64(string s)
        {
            string normal = Encoding.UTF8.GetString(Convert.FromBase64String(s));
            return normal;
        }

        /// <summary>
        /// Létrehoz egy felugró ablakot
        /// </summary>
        /// <param name="massage"> Az ablak szövege </param>
        /// <param name="caption"> Az ablak címe alapértelmezett beálítás = "Figyelem!" </param>
        /// <param name="buttons"> A lehetséges gombok alapértelmezett beállítás = "Ok" </param>
        /// <returns> Visszatér egy DialogResulttal amit aztán lehet ellenőrizni </returns>
        public DialogResult ShowMassage(string massage, string caption = "Figyelem!", MessageBoxButtons buttons=MessageBoxButtons.OK)
        {
            DialogResult dialogResult = MessageBox.Show(massage, caption, buttons );
            return dialogResult;
        }

        /// <summary>
        /// Feltölti a users listát a user.txt-ből
        /// Ha nem találja a fájlt akkor csinál egyet a megadott alap adatokkal
        /// </summary>
        public void InitializeUserList()
        {
            if (!File.Exists(FILE_NAME))
            {
                using (StreamWriter streamWriter = File.CreateText(FILE_NAME))
                {
                    streamWriter.WriteLine(ToB64("WEB:Admin:" + ToB64("Admin")));
                    streamWriter.WriteLine(ToB64("PROGRAM:User1:" + ToB64("Password")));
                    streamWriter.WriteLine(ToB64("TERMINÁL:User2:" + ToB64("Jelszó")));
                }
            }

            using (StreamReader sr = File.OpenText(FILE_NAME))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    string[] datas = FromB64(s).Split(':');
                    User u = new User(ParseEnum<EntriPoints>(datas[0]), datas[1], datas[2]);
                    users.Add(u);
                    
                }
            }
        }

        /// <summary>
        /// Szövegből alakítja át az EntriPonts nevú enum listát
        /// </summary>
        /// <typeparam name="EntriPoints"> string </typeparam>
        /// <param name="type">  </param>
        /// <returns> Szövegből átalakított enum verzió </returns>
        public EntriPoints ParseEnum<EntriPoints>(string type)
        {
            return (EntriPoints)Enum.Parse(typeof(EntriPoints), type, true);
        }

        public void AddUser(EntriPoints entri, string userName, string password)
        {
            User u = new User(entri, userName, ToB64(password));
            using (StreamWriter streamWriter = File.AppendText(FILE_NAME))
            {
                streamWriter.WriteLine(ToB64( u.EntriPoint + ":" +u.UserName + ":" + u.PasswordHash));
            }
            users.Add(u);
            OnUserFileChanged?.Invoke(this, EventArgs.Empty);
        }

        public void UpdateUsers()
        {
            using (StreamWriter streamWriter = File.CreateText(FILE_NAME))
            {
                foreach (User u in users)
                {
                    streamWriter.WriteLine(ToB64(u.EntriPoint + ":" + u.UserName + ":" + u.PasswordHash));
                }
            }
            OnUserFileChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Ellenőrzi hogy a megadott adatokkal van-e felhasználó, ha van belépteti
        /// </summary>
        /// <param name="entri"> Belépési pont </param>
        /// <param name="uName"> Felhasználónév </param>
        /// <param name="passwd"> Jelszó </param>
        /// <returns> True ha talált felhasználót, False ha nem </returns>
        public bool CanLogin(EntriPoints entri, string uName, string passwd)
        {
            User u = null;
            if (users.Exists(x => x.UserName == uName))
            {
                u = users.Find(x => x.UserName == uName && x.EntriPoint == entri);
                if (u != null)
                {
                    if (u.PasswordHash != ToB64(passwd))
                    {
                        ShowMassage("Nem megfelelő jelszó");
                        u = null;
                        return false;
                    }
                    if (u != null)
                    {
                        logedInUser = u;
                        OnLogedInUserChanged?.Invoke(this, EventArgs.Empty);
                    }
                    return true;
                }
                ShowMassage("A felhasználónak nincs jogosultsága ehet a belépési ponthoz");
                return false;
            }
            ShowMassage("Nincs felhasnáló ilyen névvel");
            return false;
        }

        public bool Change(EntriPoints oldEntri, EntriPoints entri, string oldUserName, string uName, string oldPasswd, string newPasswd)
        {
            User u = users.Find(x => x.EntriPoint == oldEntri && x.UserName == oldUserName);
            if (u.SetPassword(oldPasswd, newPasswd))
            {
                u.Change(entri, uName);

            }
            return u.SetPassword(oldPasswd, newPasswd);
        }

    }
}
