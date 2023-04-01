using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public ClassUserAuht(string login, string password, ClassDataBase dataBase)
        {
            this.dataBase = dataBase;
            this.userId = GetUserId(login, password);
            this.isActive = UserIsActive(login);

            if (userId != -1)
            {
                this.login = login;
                this.password = password;

                this.firstname = "'+'fn'+'";
                this.lastname = "'+'ln'+'";
                this.middlename = "'+'ln'+'";
                this.phone = "'+'phone'+'";
                this.email = "'+'emal'+'";

                /* var resultFunction = dataBase.SelectFunctionUsing("public.get_user_info(" + this.userId + ")");
                 resultFunction.Read();
                 this.firstname = resultFunction.GetString(0);
                 this.lastname = resultFunction.GetString(1);
                 this.middlename = resultFunction.GetString(2);
                 this.phone = resultFunction.GetString(3);
                 this.email = resultFunction.GetString(4);
                 resultFunction.Close();

                 resultFunction = dataBase.SelectFunctionUsing("public.get_user_roles(" + this.userId + ")");
                 while (resultFunction.Read())
                 {
                     this.roles.Add(resultFunction.GetInt32(0));
                 }
                 resultFunction.Close();*/
            }
        }

        public ClassUserAuht(string login, ClassDataBase dataBase)
        {
            this.dataBase = dataBase;
            this.userId = GetUserId(login);
            this.isActive = UserIsActive(login);

            if (userId != -1)
            {
                this.login = login;
                this.firstname = "'+'fn'+'";
                this.lastname = "'+'ln'+'";
                this.middlename = "'+'ln'+'";
                this.phone = "'+'phone'+'";
                this.email = "'+'emal'+'";

                /*var resultFunction = dataBase.SelectFunctionUsing("public.get_user_info(" + this.userId + ")");
                resultFunction.Read();
                this.firstname = resultFunction.GetString(0);
                this.lastname = resultFunction.GetString(1);
                this.middlename = resultFunction.GetString(2);
                this.phone = resultFunction.GetString(3);
                this.email = resultFunction.GetString(4);
                resultFunction.Close();

                resultFunction = dataBase.SelectFunctionUsing("public.get_user_roles(" + this.userId + ")");
                while (resultFunction.Read())
                {
                    this.roles.Add(resultFunction.GetInt32(0));
                }
                resultFunction.Close();*/
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

        public int GetUserId(string login, string password)
        {
            int res = -1;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                return res;
            }
            else
            {
                var result = dataBase.SelectFunction("select u.user_id from autorization.user u where u.login = '" + login.Trim() + "' and u.password = '" + password.Trim() + "'");
                string resString = "";
                while (result.Read())
                {
                    resString += result.GetValue(0).ToString();
                }
                result.Close();
                if (resString != "")
                {
                    return 1;
                } else
                {
                    return 0;
                }
            }
        }

        public int GetUserId(string login)
        {
            int res = -1;
            if (string.IsNullOrEmpty(login))
            {
                return res;
            }
            else
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
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public bool UserIsActive(string login)
        {
            return true;
            /*bool result = false;

            if (string.IsNullOrEmpty(login))
            {
                return result;
            }
            else
            {
                var resultFunction = dataBase.SelectFunctionUsing("autorization.user_is_active('" + login + "')");
                resultFunction.Read();
                if (resultFunction != null)
                {
                    result = resultFunction.GetBoolean(0);
                    resultFunction.Close();
                    return result;

                }
                else
                {
                    resultFunction.Close();
                    return result;
                }
            }*/

        }


    }
}