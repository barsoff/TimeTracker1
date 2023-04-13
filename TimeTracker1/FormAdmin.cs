using ControlzEx.Standard;
using System;
using System.Windows.Forms;
using TimeTracker1.AuthClasses;
using TimeTracker1.DataBase;

namespace TimeTracker1
{
    public partial class FormAdmin : Form
    {
        private ClassUserAuht user;
        private ClassDataBase database;

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var resultFunc = database.SelectFunction("select * from public.user");

            while (resultFunc.Read())
            {
                string user_disabled = "Да";
                if (resultFunc.GetValue(6).ToString()=="False")
                {
                    user_disabled = "Нет";
                }
                dataGridView1.Rows.Add(resultFunc.GetValue(0).ToString().Split(' ')[0], resultFunc.GetValue(2), resultFunc.GetValue(1), resultFunc.GetValue(3), resultFunc.GetValue(4), resultFunc.GetValue(5), user_disabled);

                if (!resultFunc.IsDBNull(6) && resultFunc.GetBoolean(6))
                {
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = System.Drawing.Color.White;

                }
            }
            resultFunc.Close();
        }
        public void SetUser(ClassUserAuht _user)
        {
            this.user = _user;
        }
        public void SetDB(ClassDataBase _db)
        {
            this.database = _db;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string selectedLogin = dataGridView1.SelectedCells[0].Value.ToString();
            ClassUserAuht selectedUser = new ClassUserAuht(selectedLogin, database);
            //FormChangeUser formChangeUser = new FormChangeUser();
            //formChangeUser.SetUser(selectedUser);
            //formChangeUser.SetDB(database);
            //formChangeUser.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                buttonChange.Enabled = true;
                // нужно добавить проверку на активность пользователя
                buttonDeleteBlock.Enabled = true;
            }
            else
            {
                buttonChange.Enabled = false;
                buttonDeleteBlock.Enabled = false;
            }
        
        }

        private void buttonDeleteBlock_Click(object sender, EventArgs e)
        {
            string script = "update public.user set disabled = false where user_id = "+ dataGridView1.CurrentCell.Value + ";";
            script += "update autorization.user set disabled = false where user_id = " + dataGridView1.CurrentCell.Value + ";";
            if (!string.IsNullOrEmpty(script))
            {
                database.ExecuteScript(script);
                MessageBox.Show("Пользователь заблокирован");
            }
        }
    }
}