﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace TestSql
{
    class conexao
    {
      
        public SQLiteConnection conn = new SQLiteConnection("Data Source=Teste.db");

        public void conectar()
        {
            conn.Open();
        }

        public void desconectar()
        {
            conn.Close();

        }
    }
}
