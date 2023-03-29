﻿using System;
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
            this.isActive = UserIsActive(login, password);

            if (userId != -1)
            {
                this.login = login;
                this.password = password;

                var resultFunction = dataBase.SelectFunctionUsing("main.get_user_info(" + this.userId + ")");
                resultFunction.Read();
                this.firstname = resultFunction.GetString(0);
                this.lastname = resultFunction.GetString(1);
                this.middlename = resultFunction.GetString(2);
                this.phone = resultFunction.GetString(3);
                this.email = resultFunction.GetString(4);
                resultFunction.Close();

                resultFunction = dataBase.SelectFunctionUsing("main.get_user_roles(" + this.userId + ")");
                while (resultFunction.Read())
                {
                    this.roles.Add(resultFunction.GetInt32(0));
                }
                resultFunction.Close();
            }
        }

        //Начать от сюда доделвать
        public ClassUserAuht(string login, ClassDataBase dataBase)
        {
            this.dataBase = dataBase;
            this.userId = GetUserId(login);

            if (userId != -1)
            {
                this.login = login;

                var resultFunction = dataBase.SelectFunctionUsing("main.get_user_info(" + this.userId + ")");
                resultFunction.Read();
                this.firstname = resultFunction.GetString(0);
                this.lastname = resultFunction.GetString(1);
                this.middlename = resultFunction.GetString(2);
                this.phone = resultFunction.GetString(3);
                this.email = resultFunction.GetString(4);
                resultFunction.Close();

                resultFunction = dataBase.SelectFunctionUsing("main.get_user_roles(" + this.userId + ")");
                while (resultFunction.Read())
                {
                    this.roles.Add(resultFunction.GetInt32(0));
                }
                resultFunction.Close();
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
            int result = -1;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                return result;
            }
            else
            {
                var resultFunction = dataBase.SelectFunctionUsing("auth.user_login(\'" + login + "\', \'" + password + "\')");
                resultFunction.Read();
                if (resultFunction != null)
                {
                    result = resultFunction.GetInt32(0);
                    resultFunction.Close();
                    return result;

                }
                else
                {
                    resultFunction.Close();
                    return result;
                }
            }
        }

        public int GetUserId(string login)
        {
            int result = -1;
            if (string.IsNullOrEmpty(login))
            {
                return result;
            }
            else
            {
                var resultFunction = dataBase.SelectFunctionUsing("auth.user_login(\'" + login + "\')");
                resultFunction.Read();
                if (resultFunction != null)
                {
                    result = resultFunction.GetInt32(0);
                    resultFunction.Close();
                    return result;

                }
                else
                {
                    resultFunction.Close();
                    return result;
                }
            }
        }

        public bool UserIsActive(string login, string password)
        {
            bool result = false;

            if (string.IsNullOrEmpty(login))
            {
                return result;
            }
            else
            {
                var resultFunction = dataBase.SelectFunctionUsing("auth.user_is_active(\'" + login + "\', \'" + password + "\')");
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
            }

        }


    }
}