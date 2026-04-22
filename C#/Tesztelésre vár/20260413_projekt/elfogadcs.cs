using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230413_projekt
{
    public partial class elfogadcs : Form
    {
        public elfogadcs()
        {
            InitializeComponent();
        }
        private void Frissites()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "Select * from regist";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                button1.Visible = false;
                button2.Visible = false;
                kijeloltId = -1;
                dataGridView1.ClearSelection();
            }
        }
        string connStr = "server=localhost;database=iskola;uid=root;pwd=mysql;";
        int kijeloltId = -1;
        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Frissites();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                kijeloltId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                button1.Visible = true;
                button2.Visible = true;

                dataGridView1.Rows[e.RowIndex].Selected = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kijeloltId == -1) return;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "DELETE FROM Regist WHERE Id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", kijeloltId);
                    cmd.ExecuteNonQuery();
                }
            }
            Frissites();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kijeloltId == -1) return; // Érdemes ide is tenni egy ellenőrzést!

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                // JAVÍTOTT SQL: Szóköz a FROM előtt, és NULL az EventId helyett a SELECT részben
                string copySql = "INSERT INTO Users (Name, Password, EventId, ImgNumber, Email, AdminE) " +
                                 "SELECT Name, Password, NULL, imgNumber, Email, AdminE " +
                                 "FROM Regist WHERE Id = @id;";

                using (MySqlCommand copyCmd = new MySqlCommand(copySql, conn))
                {
                    copyCmd.Parameters.AddWithValue("@id", kijeloltId);
                    int rows = copyCmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        string deleteSql = "DELETE FROM Regist WHERE Id = @id;";
                        using (MySqlCommand deleteCmd = new MySqlCommand(deleteSql, conn))
                        {
                            deleteCmd.Parameters.AddWithValue("@id", kijeloltId);
                            deleteCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            Frissites();
        }
    }
}

