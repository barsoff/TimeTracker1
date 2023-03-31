﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TimeTracker1.DataBase
{
    public class ClassDataBase
    {
        private string configurationToConnect;
        private NpgsqlConnection connection;
        private string msg;

        public string ConfigurationToConnect { get => configurationToConnect; set => configurationToConnect = value; }
        public string GetMsg { get => msg; }

        public NpgsqlConnection ConnectToDB(string configurationToConnect)
        {
            try
            {
                this.connection = new NpgsqlConnection(configurationToConnect);
                this.connection.Open();
                return this.connection;

            }
            catch
            {
                SystemException e = new SystemException();
                this.msg = (string)e.Message;
                return null;
            }

        }

        public NpgsqlDataReader SelectFunctionUsing(string nameOfFunction)
        {
            if (string.IsNullOrEmpty(nameOfFunction))
            {
                return null;
            }
            else
            {
                var command = new NpgsqlCommand("select * from " + nameOfFunction, this.connection);
                return command.ExecuteReader();
            }
        }

        public NpgsqlDataReader SelectFunction(string nameOfFunction)
        {
            if (string.IsNullOrEmpty(nameOfFunction))
            {
                return null;
            }
            else
            {
                try
                {
                    var command = new NpgsqlCommand(nameOfFunction, this.connection);
                    return command.ExecuteReader();
                }
                catch (SystemException e) { MessageBox.Show($"Error:\r\n{e}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
            }
        }

        public void ExecuteScript(string nameOfFunction)
        {
            if (!string.IsNullOrEmpty(nameOfFunction))
            {
                var command = new NpgsqlCommand(nameOfFunction, this.connection);
                command.ExecuteReader().Close();
            }
        }

    }
}