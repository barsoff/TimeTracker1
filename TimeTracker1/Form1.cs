using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            //ClassUserAuth user = new ClassUserAuth();
            MessageBox.Show("\r\r\r  Здесь должен быть выполнен вход, но пока этого нет.  \r\r\r");
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
            if (!dataBase.isConnectToDB(configurationString))
            { 
                MessageBox.Show("\n\n     Проверьте верность данных в строке     \n         для подключения к Базе данных!         \n\n");
                Application.Exit(); //Если подключение не состоялось, то необходимо закрыть приложение.
            }
            else
            {
                MessageBox.Show(dataBase.GetMsg);
            }
        }
        private void labelGoToRegForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister reg = new FormRegister();
            reg.Owner = this;
            reg.ShowDialog();
        }
    }
}