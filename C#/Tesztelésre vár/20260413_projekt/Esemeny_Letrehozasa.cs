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
    public partial class Esemeny_Letrehozasa : Form
    {
        public float arnyalat = 0.0f;
        public int r = 255, g = 0, b = 0;
        public Esemeny_Letrehozasa()
        {
            InitializeComponent();
        }

        private void valtozo(object sender, EventArgs e)
        {
            if (r > 0 && b == 0) { r--; g++; }
            else if (g > 0 && r == 0) { g--; b++; }
            else if (b > 0 && g == 0) { b--; r++; }

            lblAdmin.ForeColor = Color.FromArgb(r, g, b);
        }
        private void valtozoJelentkezes(object sender, EventArgs e)
        {
            if (r > 0 && b == 0) { r--; g++; }
            else if (g > 0 && r == 0) { g--; b++; }
            else if (b > 0 && g == 0) { b--; r++; }

            btnJelentkezes.BackColor = Color.FromArgb(r, g, b);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJelentkezes_Click(object sender, EventArgs e)
        {
            string nev = txtEsemenyNeve.Text;
            DateTime mettol = DateTime.Parse(dtpKezdesIdopont.Text);
            DateTime meddig = DateTime.Parse(dtpBefejezIdopont.Text);
            string helyszin = txthelyszin.Text;
            string kategoria = txtkategoria.Text;
            string leiras = richTextBox1.Text;
            bool fontose;
            if (chcFontos.Checked) fontose = true;
            else fontose = false;

            string kapcsolat = "server=localhost;database=iskola;uid=root;pwd=mysql";

            if (nev == "" || helyszin == "" || kategoria == "" || leiras == "" || meddig == DateTime.Now)
            {
                MessageBox.Show("Kérlek adj meg minden adatot / helyes adatot");
            }
            else
            {
                using (MySqlConnection con = new MySqlConnection(kapcsolat))
                {
                    con.Open();

                    string parancs = "INSERT INTO Eventt (Name, Descr, Datetol, Dateig, Categ, Important, Wheres) VALUES (@Name, @Descr, @Datetol, @Dateig, @Categ, @Important, @Wheres);";
                    MySqlCommand cmd = new MySqlCommand(parancs, con);
                    cmd.Parameters.AddWithValue("@Name", nev);
                    cmd.Parameters.AddWithValue("@Descr", leiras);
                    cmd.Parameters.AddWithValue("@Datetol", mettol);
                    cmd.Parameters.AddWithValue("@Dateig", meddig);
                    cmd.Parameters.AddWithValue("@Categ", kategoria);
                    cmd.Parameters.AddWithValue("@Important", fontose);
                    cmd.Parameters.AddWithValue("@Wheres", helyszin);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Sikeresen létrehoztad a '{nev}' nevezetű eseményt!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
                
        }

        private void valtozoMegse(object sender, EventArgs e)
        {
            if (r > 0 && b == 0)      { r--; g++; }
            else if (g > 0 && r == 0) { g--; b++; }
            else if (b > 0 && g == 0) { b--; r++; }

            btnMegse.BackColor = Color.FromArgb(r, g, b);
        }

        private void Esemeny_Letrehozasa_Load(object sender, EventArgs e)
        {
            Timer t = new Timer();
            Timer tt = new Timer();
            Timer ttt = new Timer();
            t.Interval = 2;
            tt.Interval = 2;
            ttt.Interval = 2;
            t.Tick += valtozo;
            tt.Tick += valtozoJelentkezes;
            ttt.Tick += valtozoMegse;
            t.Start();
            tt.Start();
            ttt.Start();
        }
    }
}
