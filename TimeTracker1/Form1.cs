﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker1.AuthClasses;
using TimeTracker1.DataBase;

namespace TimeTracker1
{
    public partial class FormAuth : Form
    {
        ClassDataBase dataBase = new ClassDataBase();
        private string configurationString = "Host = localhost; Port = 5432; Database = TimeTracker_DateBase; " +
            "Username = postgres; Password = barsoff_21";

        public FormAuth()
        {
            InitializeComponent();
        }
       
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            ClassUserAuht user = new ClassUserAuht(login, password, dataBase);

            var result = dataBase.SelectFunction("select u.user_id from autorization.user u where u.login = '" + login.Trim() + "' and u.password = '" + password.Trim() + "'");
            string resString = "";
            while (result.Read())
            {
                resString += result.GetValue(0).ToString();
            }
            result.Close();
            if (resString != "")
            {
                this.Hide();
                FormTimeTracker formTime = new FormTimeTracker();
                formTime.SetUser(user);
                formTime.SetDB(dataBase);
                formTime.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
            if (dataBase.ConnectToDB(configurationString)==null)
            { 
                MessageBox.Show("\n\n     Проверьте верность данных в строке     \n         для подключения к Базе данных!         \n\n");
                Application.Exit();
            }
        }
        private void labelGoToRegForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister reg = new FormRegister();
            reg.SetDB(dataBase);
            reg.Owner = this;
            reg.ShowDialog();
        }
    }
}