using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TimeTracker1.DataBase
{
    internal class ClassDataBase
    {
        private string configurationToConnect;
        private NpgsqlConnection connection;
        private string msg;

        public string ConfigurationToConnect { get => configurationToConnect; set => configurationToConnect = value; }
        public string GetMsg { get => msg; }

        public bool isConnectToDB(string configurationToConnect)
        {
            try
            {
                this.connection = new NpgsqlConnection(configurationToConnect);
                this.connection.Open();
                msg = "\n\n     База данных присоединена к программе     \n\n";
                return true;

            }
            catch
            {
                SystemException e = new SystemException();
                this.msg = (string)e.Message;
                return false;
            }

        }





    }
}