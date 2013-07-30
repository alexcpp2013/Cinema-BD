using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dbgdgui
{
    public partial class FormGoldenDragon : Form
    {
        MySqlConnection MyConnection;

        public FormGoldenDragon()
        {
            InitializeComponent();
            comboBoxTimeSeance.SelectedIndex = 0;
            comboBoxFilm.SelectedIndex = 0;
            comboBoxTimeOnlySeance.SelectedIndex = 0;
            string Connect = "Database = gd; Data Source = localhost; User Id = root; Password = root";
            MyConnection = new MySqlConnection(Connect);
            MyConnection.Open();
        }

        private void FormGoldenDragon_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyConnection.Close();
        }

        private void buttonUnSold_Click(object sender, EventArgs e)
        {
            if (dataGridViewTicketsSold.SelectedRows.Count == 1)
            {
                MySqlCommand command = MyConnection.CreateCommand();
                command.CommandText = "update ticket set bstatus = b'0' where id_ticket = " +
                       dataGridViewTicketsSold.SelectedRows[0].Cells[0].Value.ToString();
                command.ExecuteNonQuery();
                MessageBox.Show("Отмена продажи билета!");
                dataGridViewTicketsSold.Refresh();
                dataGridViewTicketsToSold.Refresh();
                Refresh();
            }
        }

        private void tabPageAllData_Paint_1(object sender, PaintEventArgs e)
        {
            MySqlDataAdapter MyData0 = new MySqlDataAdapter();
            string MySelect0 = "Select seance.id_seance, seance.id_movie, movie.name,"
                + " seance.date_seance, seance.freetickets, seance.soldtickets from seance, movie"
                + " where seance.id_movie = movie.id_movie and date(seance.date_seance) = date(NOW());";
            MyData0.SelectCommand = new MySqlCommand(MySelect0, MyConnection);
            DataTable table0 = new DataTable();
            MyData0.Fill(table0);
            BindingSource bsource0 = new BindingSource();
            bsource0.DataSource = table0;
            dataGridViewSeance.DataSource = bsource0;
            this.dataGridViewSeance.Columns[0].Visible = false;
            this.dataGridViewSeance.Columns[1].Visible = false;
            this.dataGridViewSeance.Columns[4].Visible = false;
            this.dataGridViewSeance.Columns[5].Visible = false;

            MySqlDataAdapter MyData1 = new MySqlDataAdapter();
            string MySelect1 = "select * from movie";
            MyData1.SelectCommand = new MySqlCommand(MySelect1, MyConnection);
            DataTable table1 = new DataTable();
            MyData1.Fill(table1);
            BindingSource bsource1 = new BindingSource();
            bsource1.DataSource = table1;
            dataGridViewFilm.DataSource = bsource1;
            this.dataGridViewFilm.Columns[0].Visible = false;

            if (comboBoxTimeOnlySeance.SelectedIndex == 0)
            {
                MySqlDataAdapter MyData2 = new MySqlDataAdapter();
                string MySelect2 = "Select  id_ticket, date_seance, name, row, n_place, price from ticket, seance, movie" +
                    " where ticket.id_seance = seance.id_seance and seance.id_movie = movie.id_movie" +
                " and date(seance.date_seance) = date(NOW()) and ticket.bstatus = b'0'";
                MyData2.SelectCommand = new MySqlCommand(MySelect2, MyConnection);
                DataTable table2 = new DataTable();
                MyData2.Fill(table2);
                BindingSource bsource2 = new BindingSource();
                bsource2.DataSource = table2;
                dataGridViewTicketsToSold.DataSource = bsource2;
                dataGridViewTicketsToSold.Columns[0].Visible = false;

                MySqlDataAdapter MyData3 = new MySqlDataAdapter();
                string MySelect3 = "Select  id_ticket, date_seance, name, row, n_place, price from ticket, seance, movie" +
                    " where ticket.id_seance = seance.id_seance and seance.id_movie = movie.id_movie" +
                " and date(seance.date_seance) = date(NOW()) and ticket.bstatus = b'1'";
                MyData3.SelectCommand = new MySqlCommand(MySelect3, MyConnection);
                DataTable table3 = new DataTable();
                MyData3.Fill(table3);
                BindingSource bsource3 = new BindingSource();
                bsource3.DataSource = table3;
                dataGridViewTicketsSold.DataSource = bsource3;
                dataGridViewTicketsSold.Columns[0].Visible = false;
            }
            if (comboBoxTimeOnlySeance.SelectedIndex != 0)
            {
                MySqlDataAdapter MyData3 = new MySqlDataAdapter();
                string MySelect3 = "Select  id_ticket, date_seance, name, row, n_place, price from ticket, seance, movie" +
                " where ticket.id_seance = seance.id_seance and seance.id_movie = movie.id_movie" +
                " and date(seance.date_seance) = date(NOW()) and time(seance.date_seance) = " +
                "'" + comboBoxTimeOnlySeance.SelectedItem.ToString() + ":00'" +
                " and ticket.bstatus = b'0'";
                MyData3.SelectCommand = new MySqlCommand(MySelect3, MyConnection);
                DataTable table3 = new DataTable();
                MyData3.Fill(table3);
                BindingSource bsource3 = new BindingSource();
                bsource3.DataSource = table3;
                dataGridViewTicketsToSold.DataSource = bsource3;
                this.dataGridViewTicketsToSold.Columns[0].Visible = false;

                MySqlDataAdapter MyData4 = new MySqlDataAdapter();
                string MySelect4 = "Select  id_ticket, date_seance, name, row, n_place, price from ticket, seance, movie" +
                " where ticket.id_seance = seance.id_seance and seance.id_movie = movie.id_movie" +
                " and date(seance.date_seance) = date(NOW()) and time(seance.date_seance) = " +
                "'" + comboBoxTimeOnlySeance.SelectedItem.ToString() + ":00'" +
                " and ticket.bstatus = b'1'";
                MyData3.SelectCommand = new MySqlCommand(MySelect4, MyConnection);
                DataTable table4 = new DataTable();
                MyData3.Fill(table4);
                BindingSource bsource4 = new BindingSource();
                bsource4.DataSource = table4;
                dataGridViewTicketsSold.DataSource = bsource4;
                this.dataGridViewTicketsSold.Columns[0].Visible = false;
            }
        }

        private void buttonSold_Click(object sender, EventArgs e)
        {
            if (dataGridViewTicketsToSold.SelectedRows.Count == 1)
            {
                string n = "";
                string cel = "";
                n = DateTime.Now.ToString();
                cel = dataGridViewTicketsToSold.SelectedRows[0].Cells[1].Value.ToString();
                if (string.Compare(n, cel) < 0)
                {
                    MySqlCommand command = MyConnection.CreateCommand();
                    command.CommandText = "update ticket set bstatus = b'1' where id_ticket = " +
                           dataGridViewTicketsToSold.SelectedRows[0].Cells[0].Value.ToString();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Билет продан!");

                    MySqlDataAdapter MyData3 = new MySqlDataAdapter();
                    string MySelect3 = "";
                    if (comboBoxTimeOnlySeance.SelectedIndex != 0)
                    {
                        MySelect3 = "Select  id_ticket, date_seance, name, row, n_place, price from ticket, seance, movie" +
                            " where ticket.id_seance = seance.id_seance and seance.id_movie = movie.id_movie" +
                            " and date(seance.date_seance) = date(NOW()) and time(seance.date_seance) = " +
                            "'" + comboBoxTimeOnlySeance.SelectedItem.ToString() + ":00'" +
                            " and ticket.bstatus = b'0'";
                    }
                    else
                    {
                        MySelect3 = "Select  id_ticket, date_seance, name, row, n_place, price from ticket, seance, movie" +
                            " where ticket.id_seance = seance.id_seance and seance.id_movie = movie.id_movie" +
                            " and date(seance.date_seance) = date(NOW()) and ticket.bstatus = b'0'";
                    }
                    MyData3.SelectCommand = new MySqlCommand(MySelect3, MyConnection);
                    DataTable table3 = new DataTable();
                    MyData3.Fill(table3);
                    BindingSource bsource3 = new BindingSource();
                    bsource3.DataSource = table3;
                    dataGridViewTicketsToSold.DataSource = bsource3;
                    this.dataGridViewTicketsToSold.Columns[0].Visible = false;

                    MySqlDataAdapter MyData4 = new MySqlDataAdapter();
                    string MySelect4 = "";
                    if (comboBoxTimeOnlySeance.SelectedIndex != 0)
                    {
                        MySelect4 = "Select  id_ticket, date_seance, name, row, n_place, price from ticket, seance, movie" +
                            " where ticket.id_seance = seance.id_seance and seance.id_movie = movie.id_movie" +
                            " and date(seance.date_seance) = date(NOW()) and time(seance.date_seance) = " +
                            "'" + comboBoxTimeOnlySeance.SelectedItem.ToString() + ":00'" +
                            " and ticket.bstatus = b'1'";
                    }
                    else
                    {
                        MySelect4 = "Select  id_ticket, date_seance, name, row, n_place, price from ticket, seance, movie" +
                            " where ticket.id_seance = seance.id_seance and seance.id_movie = movie.id_movie" +
                            " and date(seance.date_seance) = date(NOW()) and ticket.bstatus = b'1'";
                    }
                    MyData4.SelectCommand = new MySqlCommand(MySelect4, MyConnection);
                    DataTable table4 = new DataTable();
                    MyData4.Fill(table4);
                    BindingSource bsource4 = new BindingSource();
                    bsource4.DataSource = table4;
                    dataGridViewTicketsSold.DataSource = bsource4;
                    this.dataGridViewTicketsSold.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show("Не корректное время!");
                }
            }
        }

        private void comboBoxTimeOnlySeance_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Refresh();
        }

        private void buttonAddSeance_Click(object sender, EventArgs e)
        {
            string n = "";
            string cel = "";
            n = DateTime.Now.ToString();
            string _pat1 = comboBoxTimeSeance.SelectedItem.ToString();
            cel = DateTime.Now.ToString("dd.MM.yyyy") + " " + _pat1 + ":00";
            if (string.Compare(n, cel) < 0)
            {
                bool f = true;
                string pat1 = comboBoxTimeSeance.SelectedItem.ToString();
                string pat = DateTime.Now.ToString("dd.MM.yyyy") + " " + pat1 + ":00";
                string g = "";
                for (int i = 0; i < dataGridViewSeance.Rows.Count - 1; ++i)
                {
                    g = dataGridViewSeance.Rows[i].Cells[3].Value.ToString();
                    if (pat == g)
                    {
                        f = false;
                        break;
                    }
                }
                if (f)
                {
                    string item = "";
                    item = comboBoxFilm.SelectedItem.ToString();
                    if (item == "Marlowe") item = "1";
                    if (item == "The Big Boss") item = "2";
                    if (item == "Fist of Fury") item = "3";
                    if (item == "Way of the Dragon") item = "4";
                    if (item == "Enter the Dragon") item = "5";
                    if (item == "Game of Death") item = "6";
                    MySqlCommand command = MyConnection.CreateCommand();
                    command.CommandText = "Insert into seance(id_movie, date_seance) values ("
                        + item + ", "
                        + "concat(curdate(), ' " + comboBoxTimeSeance.SelectedItem.ToString() + "'))";
                    command.ExecuteNonQuery();
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Данный сеанс уже добавлен.");
                }
            }
            else
            {
                MessageBox.Show("Выберите другое время для сеанса.");
            }
        }

        private void buttonEscape_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewSeance_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridViewSeance.RowCount != 0 && dataGridViewSeance.SelectedRows.Count == 1)
            {
                MySqlCommand command = MyConnection.CreateCommand();
                command.CommandText = "delete from seance where id_seance = "
                    + e.Row.Cells[0].Value.ToString();
                command.ExecuteNonQuery();

                MySqlDataAdapter MyData3 = new MySqlDataAdapter();
                string MySelect3 = "";
                if (comboBoxTimeOnlySeance.SelectedIndex != 0)
                {
                    MySelect3 = "Select  id_ticket, date_seance, name, row, n_place, price from ticket, seance, movie" +
                        " where ticket.id_seance = seance.id_seance and seance.id_movie = movie.id_movie" +
                        " and date(seance.date_seance) = date(NOW()) and time(seance.date_seance) = " +
                        "'" + comboBoxTimeOnlySeance.SelectedItem.ToString() + ":00'" +
                        " and ticket.bstatus = b'0'";
                }
                else
                {
                    MySelect3 = "Select  id_ticket, date_seance, name, row, n_place, price from ticket, seance, movie" +
                        " where ticket.id_seance = seance.id_seance and seance.id_movie = movie.id_movie" +
                        " and date(seance.date_seance) = date(NOW()) and ticket.bstatus = b'0'";
                }
                MyData3.SelectCommand = new MySqlCommand(MySelect3, MyConnection);
                DataTable table3 = new DataTable();
                MyData3.Fill(table3);
                BindingSource bsource3 = new BindingSource();
                bsource3.DataSource = table3;
                dataGridViewTicketsToSold.DataSource = bsource3;
                this.dataGridViewTicketsToSold.Columns[0].Visible = false;

                MySqlDataAdapter MyData4 = new MySqlDataAdapter();
                string MySelect4 = "";
                if (comboBoxTimeOnlySeance.SelectedIndex != 0)
                {
                    MySelect4 = "Select  id_ticket, date_seance, name, row, n_place, price from ticket, seance, movie" +
                        " where ticket.id_seance = seance.id_seance and seance.id_movie = movie.id_movie" +
                        " and date(seance.date_seance) = date(NOW()) and time(seance.date_seance) = " +
                        "'" + comboBoxTimeOnlySeance.SelectedItem.ToString() + ":00'" +
                        " and ticket.bstatus = b'1'";
                }
                else
                {
                    MySelect4 = "Select  id_ticket, date_seance, name, row, n_place, price from ticket, seance, movie" +
                        " where ticket.id_seance = seance.id_seance and seance.id_movie = movie.id_movie" +
                        " and date(seance.date_seance) = date(NOW()) and ticket.bstatus = b'1'";
                }
                MyData4.SelectCommand = new MySqlCommand(MySelect4, MyConnection);
                DataTable table4 = new DataTable();
                MyData4.Fill(table4);
                BindingSource bsource4 = new BindingSource();
                bsource4.DataSource = table4;
                dataGridViewTicketsSold.DataSource = bsource4;
                this.dataGridViewTicketsSold.Columns[0].Visible = false;
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            FormHelp f = new FormHelp();
            f.Show();
        }
    }
}
