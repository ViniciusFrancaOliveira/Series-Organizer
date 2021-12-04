using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SeriesOrganizer.Dao
{
    class MySqlAcess
    {
        public static MySqlConnection GetConnection(string datasource, string username,
            string password, string database)
        {
            string sql = "datasource=" + datasource +
                         ";username=" + username +
                         ";password=" + password +
                         ";database=" + database;

            MySqlConnection connectSql = new MySqlConnection(sql);

            try
            {
                connectSql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return connectSql;
        }

        public static MySqlConnection GetConnection(string sql)
        {
            MySqlConnection connectSql = new MySqlConnection(sql);

            try
            {
                connectSql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return connectSql;
        }

        public static void DataToViewList(MySqlCommand commandSql, ListView listViewForm,
            int totalColumns)
        {
            MySqlDataReader readerSql = commandSql.ExecuteReader();

            listViewForm.Items.Clear();

            while (readerSql.Read())
            {
                string[] row = new string[totalColumns];

                for (int n = 1; n <= totalColumns; n++)
                {
                    row[n - 1] = readerSql.GetString(n);
                }

                ListViewItem listViewRow = new ListViewItem(row);

                listViewForm.Items.Add(listViewRow);
            }
        }
    }
}
