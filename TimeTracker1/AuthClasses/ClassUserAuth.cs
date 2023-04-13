using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TimeTracker1.DataBase;

namespace TimeTracker1.AuthClasses
{
    public class ClassUserAuht
    {
        private int userId;
        private string firstname;
        private string lastname;
        private string middlename;
        private string phone;
        private string email;
        private bool isActive;
        private List<int> roles = new List<int>();

        private string login;
        private string password;

        private ClassDataBase dataBase;

        public ClassUserAuht(string login, string password, ClassDataBase dataBase) //for 1
        {
            this.dataBase = dataBase;
            this.userId = GetUserId(login, password);
            this.isActive = UserIsActive(login);

            if (userId != -1)
            {
                this.login = login;
                this.password = password;

                var result = dataBase.SelectFunction("select * from public.user u where u.user_id = " + this.userId + "");
                while (result.Read())
                {
                    this.firstname = result.GetValue(1).ToString();
                    this.lastname = result.GetValue(2).ToString();
                    this.middlename = result.GetValue(3).ToString();
                    this.phone = result.GetValue(4).ToString();
                    this.email = result.GetValue(5).ToString();
                }
                result.Close();
                result = dataBase.SelectFunction("select * from public.connect_user_role u where u.user_id = " + this.userId + "");
                while (result.Read())
                {
                    this.roles.Add(result.GetInt32(1));
                }
                result.Close();
            }
        }

        public ClassUserAuht(string login, ClassDataBase dataBase) //for 2
        {
            this.dataBase = dataBase;
            this.userId = GetUserId(login);
            this.isActive = UserIsActive(login);

            if (userId != -1)
            {
                this.login = login;

                var result = dataBase.SelectFunction("select * from public.user u where u.user_id = " + this.userId + "");
                while (result.Read())
                {
                    this.firstname = result.GetValue(1).ToString();
                    this.lastname = result.GetValue(2).ToString();
                    this.middlename = result.GetValue(3).ToString();
                    this.phone = result.GetValue(4).ToString();
                    this.email = result.GetValue(5).ToString();
                }
                result.Close();
                result = dataBase.SelectFunction("select * from public.connect_user_role u where u.user_id = " + this.userId + "");
                while (result.Read())
                {
                    this.roles.Add(result.GetInt32(0));
                }
                result.Close();
            }
        }

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Middlename { get => middlename; set => middlename = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public List<int> Roles { get => roles; set => roles = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public int UserId { get => userId; set => userId = value; }

        public int GetUserId(string login, string password) //for login and password
        {
            int res = -1;
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                var result = dataBase.SelectFunction("select u.user_id from autorization.user u where u.login = '" + login.Trim() + "' and u.password = '" + password.Trim() + "'");
                string resString="";
                while (result.Read())
                {
                    resString = result.GetValue(0).ToString();
                }
                result.Close();
                if (resString != "")
                {
                    res = Convert.ToInt32(resString)- Convert.ToInt32("0");
                }
            }
            return res;
        }

        public int GetUserId(string login) //for only login 
        {
            int res = -1;
            if (!string.IsNullOrEmpty(login))
            {
                var result = dataBase.SelectFunction("select u.user_id from autorization.user u where u.login = '" + login.Trim() + "'");
                string resString = "";
                while (result.Read())
                {
                    resString += result.GetValue(0).ToString();
                }
                result.Close();
                if (resString != "")
                {
                    res = Convert.ToInt32(resString) - Convert.ToInt32('0');
                }
            }
            return res;
        }

        public bool UserIsActive(string login)
        {
            bool res = false;
            if (!string.IsNullOrEmpty(login))
            {
                var result = dataBase.SelectFunction("select u.disabled from public.user u where u.user_id = " + this.userId + "");
                while (result.Read())
                {
                    res = result.GetValue(0).Equals(true);
                }
                result.Close();
            }
            return res;
        }
    }
}