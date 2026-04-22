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
    public partial class admin : Form
    {
        public float arnyalat = 0.0f;
        public int r = 255, g = 0, b = 0;
        
        public static string id = "";
        public static string nev = "";
        public static string leiras = "";
        public static string mettol = "";
        public static string meddig = "";
        public static string kateg = "";
        public static bool fontose = false;
        public static string helyszin = "";

        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            string kapcsolat = "server=localhost;database=iskola;uid=root;pwd=mysql";

            tipus.Items.Add("Minden kategoria");
            tipus.SelectedIndex = 0;
            using (MySqlConnection con = new MySqlConnection(kapcsolat))
            {
                con.Open();

                string cmd = $"SELECT DISTINCT eventt.categ FROM eventt";
                MySqlCommand parancs = new MySqlCommand(cmd, con);
                MySqlDataReader reader = parancs.ExecuteReader();
                while (reader.Read())
                {
                    tipus.Items.Add(reader.GetString(0));
                }
            }


            dgv_admin_esemenyek.Columns.Clear();
            dgv_admin_esemenyek.Rows.Clear();

            dgv_admin_esemenyek.Columns.Add("ID", "ID");
            dgv_admin_esemenyek.Columns.Add("Nev", "Név");
            dgv_admin_esemenyek.Columns.Add("Desc", "Leírás");
            dgv_admin_esemenyek.Columns.Add("Datetol", "Mettől");
            dgv_admin_esemenyek.Columns.Add("Dateig", "Meddig");
            dgv_admin_esemenyek.Columns.Add("Categ", "Kategória");
            dgv_admin_esemenyek.Columns.Add("Important", "Kötelező-e");
            dgv_admin_esemenyek.Columns.Add("Wheres", "Helyszín");
            using (MySqlConnection con = new MySqlConnection(kapcsolat))
            {
                con.Open();

                string cmd = "SELECT eventt.Id, eventt.Name, eventt.Descr, eventt.Datetol, eventt.Dateig, eventt.Categ, eventt.Important, eventt.Wheres FROM eventt;";
                MySqlCommand parancs = new MySqlCommand(cmd, con);
                MySqlDataReader reader = parancs.ExecuteReader();
                while (reader.Read())
                {
                    dgv_admin_esemenyek.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetString(5), reader.GetBoolean(6), reader.GetString(7));
                }


            }
            
            Timer t = new Timer();
            t.Interval = 2;
            t.Tick += valtozo;
            t.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Esemeny_Letrehozasa esemeny_Letrehozasa = new Esemeny_Letrehozasa();
            esemeny_Letrehozasa.Show();
        }

        private void tipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string melyik = tipus.SelectedItem.ToString();

            foreach (DataGridViewRow row in dgv_admin_esemenyek.Rows) 
            {
                if (tipus.SelectedIndex == 0)
                {
                    row.Visible = true;
                }
                else if (row.Cells[4].Value.ToString() == melyik)
                {
                    row.Visible = true;
                }
                else 
                {
                    row.Visible = false;
                }
            }
        }

        private void dgv_admin_esemenyek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kereso_TextChanged(object sender, EventArgs e)
        {
            string keres = kereso.Text.ToLower();
            foreach (DataGridViewRow row in dgv_admin_esemenyek.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower().Contains(keres))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_admin_esemenyek.CurrentRow != null)
            {
                id = dgv_admin_esemenyek.CurrentRow.Cells["ID"].Value.ToString();
                nev = dgv_admin_esemenyek.CurrentRow.Cells["Nev"].Value.ToString();
                leiras = dgv_admin_esemenyek.CurrentRow.Cells["Desc"].Value.ToString();
                mettol = dgv_admin_esemenyek.CurrentRow.Cells["Datetol"].Value.ToString();
                meddig = dgv_admin_esemenyek.CurrentRow.Cells["Dateig"].Value.ToString();
                kateg = dgv_admin_esemenyek.CurrentRow.Cells["Categ"].Value.ToString();
                fontose = bool.Parse(dgv_admin_esemenyek.CurrentRow.Cells["Important"].Value.ToString());
                helyszin = dgv_admin_esemenyek.CurrentRow.Cells["Wheres"].Value.ToString();

                Modosit_Admin_ modosit_Admin_ = new Modosit_Admin_();
                modosit_Admin_.Show();
            }
            else
            {
                MessageBox.Show("Nincs kiválasztva esemény!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kereso.Text = "";
            tipus.SelectedIndex = 0;
            datum.Value = DateTime.Now;
            dgv_admin_esemenyek.Rows.Clear();

            string kapcsolat = "server=localhost;database=iskola;uid=root;pwd=mysql";


            using (MySqlConnection con = new MySqlConnection(kapcsolat))
            {
                con.Open();

                string cmd = $"SELECT * FROM eventt";
                MySqlCommand parancs = new MySqlCommand(cmd, con);
                MySqlDataReader reader = parancs.ExecuteReader();
                while (reader.Read())
                {
                    dgv_admin_esemenyek.Rows.Add(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetString(5), reader.GetBoolean(6), reader.GetString(7));
                }

            }
            using (MySqlConnection con = new MySqlConnection(kapcsolat))
            {
                con.Open();

                string cmd = $"SELECT DISTINCT eventt.Categ FROM eventt;";
                MySqlCommand parancs = new MySqlCommand(cmd, con);
                MySqlDataReader reader = parancs.ExecuteReader();
                while (reader.Read())
                {
                    tipus.Items.Add(reader.GetString(0));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv_admin_esemenyek.CurrentRow != null)
            {
                if (MessageBox.Show($"Biztosna törölni szeretné a '{dgv_admin_esemenyek.CurrentRow.Cells["Nev"].Value}'", "Kérdés", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string kapcsolat = "server=localhost;database=iskola;uid=root;pwd=mysql";

                    using (MySqlConnection con = new MySqlConnection(kapcsolat))
                    {
                        con.Open();
                        string cmd = $"DELETE FROM eventt WHERE Id = {dgv_admin_esemenyek.CurrentRow.Cells["ID"].Value}";
                        MySqlCommand parancs = new MySqlCommand(cmd, con);
                        parancs.ExecuteNonQuery();
                    }

                    MessageBox.Show("Sikeres törlés!");
                }
                else
                {
                    MessageBox.Show("Sikertelen törlés!");
                }
            }
            else
            {
                MessageBox.Show("Nincs kiválasztva esemény!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            elfogadcs a = new elfogadcs();
            a.Show();
        }

        private void valtozo(object sender, EventArgs e)
        {
            if (r > 0 && b == 0)      { r--; g++; }
            else if (g > 0 && r == 0) { g--; b++; }
            else if (b > 0 && g == 0) { b--; r++; }

            valtozo_admin.ForeColor = Color.FromArgb(r, g, b);
        }
    }
}
