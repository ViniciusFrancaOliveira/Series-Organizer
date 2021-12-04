using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SeriesOrganizer.Dao;

namespace SeriesOrganizer
{
    public partial class SeriesCatalog : Form
    {
        MySqlConnection connectSql;
        MySqlCommand commandSql;

        public SeriesCatalog()
        {
            InitializeComponent();
            UpdateList();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Clean()
        {
            textBoxName.Clear();
            textBoxCurrentEpisode.Clear();
            textBoxCurrentSeason.Clear();
            textBoxTotalSeasons.Clear();
        }

        public void Obtain()
        {
            textBoxName.Text = listViewSeries.SelectedItems[0].SubItems[0].Text;
            textBoxTotalSeasons.Text = listViewSeries.SelectedItems[0].SubItems[1].Text;
            comboBoxGenre.Text = listViewSeries.SelectedItems[0].SubItems[2].Text;
            textBoxCurrentSeason.Text = listViewSeries.SelectedItems[0].SubItems[3].Text;
            textBoxCurrentEpisode.Text = listViewSeries.SelectedItems[0].SubItems[4].Text;
        }

        public void UpdateList()
        {
            string querySql = "SELECT * FROM Series";

            connectSql = MySqlAcess.GetConnection("127.0.0.1", "root", "pa55w0rd", "myseries");
            commandSql = new MySqlCommand(querySql, connectSql);

            MySqlAcess.DataToViewList(commandSql, listViewSeries, 5);

            connectSql.Close();
        }

        private void PictureBoxSearchClick(object sender, EventArgs e)
        {
            try
            {
                string querySql = "SELECT * FROM Series " +
                                  "WHERE Name LIKE @Search";
                connectSql = MySqlAcess.GetConnection("127.0.0.1", "root", "pa55w0rd", "myseries");
                commandSql = new MySqlCommand(querySql, connectSql);

                commandSql.Parameters.AddWithValue("@search", "%" + textBoxSearch.Text + "%");

                MySqlAcess.DataToViewList(commandSql, listViewSeries, 5);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Search Function " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connectSql.Close();
            }
        }

        private void ButtonAddSerieClick(object sender, EventArgs e)
        {
            string querySql = "INSERT INTO Series " +
                              "VALUES (UUID(), @Name, @TotalSeasons, @Genre, @CurrentSeason, " +
                              "@CurrentEpisode)";

            connectSql = MySqlAcess.GetConnection("127.0.0.1", "root", "pa55w0rd", "myseries");
            commandSql = new MySqlCommand(querySql, connectSql);

            commandSql.Parameters.Add("@Name", MySqlDbType.VarChar).Value = textBoxName.Text;
            commandSql.Parameters.Add("@TotalSeasons", MySqlDbType.VarChar).Value = textBoxTotalSeasons.Text;
            commandSql.Parameters.Add("@Genre", MySqlDbType.VarChar).Value = comboBoxGenre.Text;
            commandSql.Parameters.Add("@CurrentSeason", MySqlDbType.Int32).Value = textBoxCurrentSeason.Text;
            commandSql.Parameters.Add("@CurrentEpisode", MySqlDbType.Int32).Value = textBoxCurrentEpisode.Text;

            try
            {
                commandSql.ExecuteNonQuery();

                MessageBox.Show("Added successfully to the database", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serie not inserted. \n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connectSql.Close();
            }

            Clean();
            UpdateList();
        }

        private void ListViewSeriesSelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSeries.SelectedItems.Count > 0)
            {
                Obtain();
            }
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            string querySql = "UPDATE Series " +
                              "SET Name = @Name, " +
                              "Total_Seasons = @TotalSeasons, " +
                              "Genre = @Genre, " +
                              "Current_Season = @CurrentSeason, " +
                              "Current_Episode = @CurrentEpisode";

            connectSql = MySqlAcess.GetConnection("127.0.0.1", "root", "pa55w0rd", "myseries");
            commandSql = new MySqlCommand(querySql, connectSql);

            commandSql.Parameters.Add("@Name", MySqlDbType.VarChar).Value = textBoxName.Text;
            commandSql.Parameters.Add("@TotalSeasons", MySqlDbType.VarChar).Value = textBoxTotalSeasons.Text;
            commandSql.Parameters.Add("@Genre", MySqlDbType.VarChar).Value = comboBoxGenre.Text;
            commandSql.Parameters.Add("@CurrentSeason", MySqlDbType.Int32).Value = textBoxCurrentSeason.Text;
            commandSql.Parameters.Add("@CurrentEpisode", MySqlDbType.Int32).Value = textBoxCurrentEpisode.Text;

            try
            {
                commandSql.ExecuteNonQuery();

                MessageBox.Show("Updated sucessfully", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serie not Updated. \n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connectSql.Close();
            }

            UpdateList();
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            string querySql = "DELETE FROM series WHERE Name = @Name";

            connectSql = MySqlAcess.GetConnection("127.0.0.1", "root", "pa55w0rd", "myseries");
            commandSql = new MySqlCommand(querySql, connectSql);

            commandSql.Parameters.Add("@Name", MySqlDbType.VarChar).Value = textBoxName.Text;

            try
            {
                commandSql.ExecuteNonQuery();

                MessageBox.Show("Deleted successfully", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serie not deleted. \n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connectSql.Close();
            }

            Clean();
            UpdateList();
        }

        private void ButtonCloseClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
