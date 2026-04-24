using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230413_projekt
{
    public partial class Form1 : Form
    {
        public static List<string> szovegek = new List<string>();
        public static List<string> nevek = new List<string>();
        public static Label asd = new System.Windows.Forms.Label();
        public static List<int> esemenyIdk = new List<int>();   
        public static int id = -1;

        public Form1()
        {
            InitializeComponent();
            // 
            // valtozo
            // 
            asd.AutoSize = true;
            asd.ForeColor = System.Drawing.Color.Red;
            asd.Location = new System.Drawing.Point(0, 44);
            asd.Size = new System.Drawing.Size(34, 17);
            asd.TabIndex = 10;
            asd.Text = "Nincs";

            // 
            // panel1
            // 
            this.panel1.Controls.Add(asd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 144);
            this.panel1.TabIndex = 9;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            lbl_nev.Text = regisztracio_bejelentkezes.nev;

            if (regisztracio_bejelentkezes.ADMINE) MenuStrip_Admin.Visible = true;
            else MenuStrip_Admin.Visible = false;

            pictureBox1.Image = Image.FromFile($"{regisztracio_bejelentkezes.i}.jpg");

            comb_kategoria.Items.Add("Minden kategória");
            comb_kategoria.SelectedIndex = 0;


            string kapcsolat = "server=localhost;database=iskola;uid=root;pwd=mysql";

            Esemenyek.Columns.Add("Id","Id");
            Esemenyek.Columns.Add("Nev","Név");
            Esemenyek.Columns.Add("Desc","Leírás");
            Esemenyek.Columns.Add("Datetol","Mettől");
            Esemenyek.Columns.Add("Dateig","Meddig");
            Esemenyek.Columns.Add("Categ","Kategória");
            Esemenyek.Columns.Add("Important","Kötelező-e");
            Esemenyek.Columns.Add("Wheres","Helyszín");

            Esemenyek.Columns["Id"].Visible = false;
            using (MySqlConnection con = new MySqlConnection(kapcsolat))
            {
                con.Open();

                string cmd = $"SELECT * FROM eventt";
                MySqlCommand parancs = new MySqlCommand(cmd, con);
                MySqlDataReader reader = parancs.ExecuteReader();
                while (reader.Read())
                {
                    Esemenyek.Rows.Add(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetString(5), reader.GetBoolean(6), reader.GetString(7));
                    nevek.Add(reader.GetString(1));
                    esemenyIdk.Add(reader.GetInt32(0));
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
                    comb_kategoria.Items.Add(reader.GetString(0));
                }
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ott van!");
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);

            pictureBox1.Region = new Region(gp);
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.Show();
        }


        private void kilepes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan ki akarsz jelentkezni?\nHa kijelentkezel bezárul az abalak!", "Kijelentkezés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void Esemenyek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                return;
            }


            szovegek.Clear();

            
            id = Convert.ToInt32(Esemenyek.Rows[e.RowIndex].Cells["Id"].Value); // ID 
            szovegek.Add(Esemenyek.Rows[e.RowIndex].Cells[1].Value.ToString()); // Nev
            szovegek.Add(Esemenyek.Rows[e.RowIndex].Cells[2].Value.ToString()); // Desc
            szovegek.Add(Esemenyek.Rows[e.RowIndex].Cells[3].Value.ToString()); // Datetol
            szovegek.Add(Esemenyek.Rows[e.RowIndex].Cells[4].Value.ToString()); // Dateig
            szovegek.Add(Esemenyek.Rows[e.RowIndex].Cells[5].Value.ToString()); // Categ
            szovegek.Add(Esemenyek.Rows[e.RowIndex].Cells[6].Value.ToString()); // Wheres


            Esemeny_adatai a = new Esemeny_adatai();
            a.ShowDialog();
        }

        private void comb_kategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string melyik = comb_kategoria.SelectedItem.ToString();
            string keres = txt_kereso.Text.ToLower();

            foreach (DataGridViewRow row in Esemenyek.Rows)
            {
                if (row.Cells[5].Value.ToString() == melyik && row.Cells[1].Value.ToString().ToLower().Contains(keres))
                {
                    row.Visible = true;
                }
                else if (melyik == "Minden kategória" && row.Cells[1].Value.ToString().ToLower().Contains(keres))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void txt_kereso_TextChanged(object sender, EventArgs e)
        {
            string melyik = comb_kategoria.SelectedItem.ToString();
            string keres = txt_kereso.Text.ToLower();
            foreach (DataGridViewRow row in Esemenyek.Rows)
            {
                if ((row.Cells[1].Value.ToString().ToLower().Contains(keres) && row.Cells[5].Value.ToString() == comb_kategoria.Text) || (row.Cells[1].Value.ToString().ToLower().Contains(keres) && melyik == "Minden kategória"))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txt_kereso.Text = "";
            comb_kategoria.SelectedIndex = 0;
            Esemenyek.Rows.Clear();


            string kapcsolat = "server=localhost;database=iskola;uid=root;pwd=mysql";


            using (MySqlConnection con = new MySqlConnection(kapcsolat))
            {
                con.Open();

                string cmd = $"SELECT * FROM eventt";
                MySqlCommand parancs = new MySqlCommand(cmd, con);
                MySqlDataReader reader = parancs.ExecuteReader();
                while (reader.Read())
                {
                    Esemenyek.Rows.Add(reader.GetInt32(0) ,reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetString(5), reader.GetBoolean(6), reader.GetString(7));
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
                    comb_kategoria.Items.Add(reader.GetString(0));
                }
            }
        }

        private void MenuStrip_Jelentkezeseim_Click(object sender, EventArgs e)
        {
            if (asd.Text == "Nincs")
            {
                MessageBox.Show("Jelenleg nincs semmilyen jelentkezett eseményed!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                szovegek.Clear();
                for (int i = 0; i < nevek.Count; i++)
                {
                    if (asd.Text.Contains(nevek[i]))
                    {
                        szovegek.Add(Esemenyek.Rows[i].Cells[1].Value.ToString()); // Nev
                        szovegek.Add(Esemenyek.Rows[i].Cells[2].Value.ToString()); // Desc
                        szovegek.Add(Esemenyek.Rows[i].Cells[3].Value.ToString()); // Datetol
                        szovegek.Add(Esemenyek.Rows[i].Cells[4].Value.ToString()); // Dateig
                        szovegek.Add(Esemenyek.Rows[i].Cells[5].Value.ToString()); // Categ
                        szovegek.Add(Esemenyek.Rows[i].Cells[6].Value.ToString()); // Wheres
                    }
                }
                Esemeny_adatai a = new Esemeny_adatai();
                a.ShowDialog();
            }
        }
    }
}
