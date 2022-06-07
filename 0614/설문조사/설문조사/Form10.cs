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

namespace 설문조사
{
    public partial class Form10 : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "new_schema";
        string _id = "root";
        string _pw = "";
        string _connectionAddress = "";
        public Form10()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};charset=utf8", _server, _port, _database, _id, _pw);

            listView1_load();
            listview1.SelectedIndexChanged += Listview1_SelectedIndexChanged;
        }

        private void Listview1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listview = sender as ListView;

            int index = listview.FocusedItem.Index;
            textBox6.Text = listview.Items[index].SubItems[1].Text;
            textBox5.Text = listview.Items[index].SubItems[2].Text;
            textBoxName.Text = listview.Items[index].SubItems[3].Text;
            textBoxPhone.Text = listview.Items[index].SubItems[4].Text;
            textBox2.Text = listview.Items[index].SubItems[5].Text;
            textBox1.Text = listview.Items[index].SubItems[6].Text;
            textBox4.Text = listview.Items[index].SubItems[7].Text;
            textBox3.Text = listview.Items[index].SubItems[8].Text;
            


        }

        private void listView1_load()
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT * FROM exam_table");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    listview1.Items.Clear();

                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = table["id"].ToString();
                        item.SubItems.Add(table["name"].ToString());
                        item.SubItems.Add(table["phone"].ToString());
                        item.SubItems.Add(table["drink"].ToString());
                        item.SubItems.Add(table["food"].ToString());
                        item.SubItems.Add(table["which"].ToString());
                        item.SubItems.Add(table["cook"].ToString());
                        item.SubItems.Add(table["place"].ToString());
                        item.SubItems.Add(table["count"].ToString());
                       


                        listview1.Items.Add(item);
                    }

                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    int pos = listview1.SelectedItems[0].Index;
                    int index = Convert.ToInt32(listview1.Items[pos].Text);
                    string updateQuery = string.Format("UPDATE exam_table SET name = '{1}', phone = '{2}', drink = '{3}', food = '{4}', which = '{5}', cook = '{6}', place = '{7}', count = '{8}' WHERE id={0};", index, textBox6.Text, textBox5.Text ,textBoxName.Text, textBoxPhone.Text,textBox2.Text, textBox1.Text, textBox4.Text, textBox3.Text);

                    MySqlCommand command = new MySqlCommand(updateQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to delete data.");

                    textBox6.Text = "";
                    textBox5.Text = "";
                    textBoxName.Text = "";
                    textBoxPhone.Text = "";
                    textBox2.Text = "";
                    textBox1.Text = "";
                    textBox4.Text = "";
                    textBox3.Text = "";
                 
                }
            }
            catch { }
            listview1.Items.Clear();
            listView1_load();
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    int pos = listview1.SelectedItems[0].Index;
                    int index = Convert.ToInt32(listview1.Items[pos].Text);
                    string deleteQuery = string.Format("DELETE FROM exam_table WHERE id={0};", index);

                    MySqlCommand command = new MySqlCommand(deleteQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to delete data.");

                    listview1.Items.Clear();
                    listView1_load();
                    textBoxName.Text = "";
                    textBoxPhone.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
            }
            catch { }
        }

        private void listview1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}

