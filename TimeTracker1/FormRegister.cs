using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Npgsql;

namespace TimeTracker1
{
    public partial class FormRegister : Form
    {
        private bool isClose = true; // Флаг для того, чтобы приложение не закрывалось при закрытии формы
        public FormRegister()
        {
            InitializeComponent();
        }

        private void labelGoToLogForm_Click(object sender, EventArgs e)
        {
            isClose = false;
            this.Close();
            this.Owner.Show();
        }


        private void FormRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isClose)
            {
                Application.Exit();
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // connect to server PostgreSQL
            NpgsqlConnection connect = new NpgsqlConnection ("Host = localhost; Port = 5432; Database = TimeTracker_DateBase; " +
            "Username = postgres; Password = barsoff_21");
            connect.Open();

            // перенос данных в схемы autorization и public
            var commandAutorization = new NpgsqlCommand($"insert into autorization.user (firstname, lastname, middlename, phone, email, disabled) values ('{textBox7.Text}', '{textBox8.Text}', '{textBox4.Text}', '{textBox5.Text}','{textBox6.Text}', false)", connect);
            var commandPublic = new NpgsqlCommand($"insert into public.user (first_name, last_name, middle_name, phone, email, disabled) values ('{textBox7.Text}', '{textBox8.Text}', '{textBox4.Text}', '{textBox5.Text}','{textBox6.Text}', false)", connect);

            commandAutorization.ExecuteNonQuery();
            commandPublic.ExecuteNonQuery();
            //MessageBox.Show(commandAutorization.ExecuteNonQuery().ToString());
            //MessageBox.Show(commandPublic.ExecuteNonQuery().ToString());
            connect.Close();

            MessageBox.Show("\n   Вы успешно зарегистрированы   \n\n");
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }
    }
}
