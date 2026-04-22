using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _20230413_projekt
{
    public partial class Esemeny_adatai : Form
    {
        public static string nev = "";
        public static string mikor = "";
        public Esemeny_adatai()
        {
            InitializeComponent();
        }

        private void Esemeny_adatai_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($"{regisztracio_bejelentkezes.i}.jpg");

            label1.Text = Form1.szovegek[0];
            nev = Form1.szovegek[0];
            label5.Text = Form1.szovegek[0];
            lblDatum.Text = $"{Form1.szovegek[2]} - {Form1.szovegek[3]}";
            mikor = $"{Form1.szovegek[2]} - {Form1.szovegek[3]}";
            lblcat.Text = Form1.szovegek[4];
            lblhelyszin.Text = Form1.szovegek[5];
            richTextBox1.Text = Form1.szovegek[1];


            if (Form1.asd.Text != "Nincs" && Form1.asd.Text.Contains(nev))
            {
                btnJelentkezes.Text = "Lemondás";
            }
            else
            {
                btnJelentkezes.Text = "Jelentkezés";
            }
        }

        private void kor(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);

            pictureBox1.Region = new Region(gp);
        }

        private void btnJelentkezes_Click(object sender, EventArgs e)
        {
            string kapcsolat = "server=localhost;database=iskola;uid=root;pwd=mysql";

            if (btnJelentkezes.Text == "Jelentkezés" && Form1.asd.Text.Trim() == "Nincs")
            {
                using (MySqlConnection con = new MySqlConnection(kapcsolat))
                {
                    con.Open();
                    string parancs = "UPDATE users SET EventId = @EventId WHERE Id = @UserId";
                    MySqlCommand cmd = new MySqlCommand(parancs, con);
                    cmd.Parameters.AddWithValue("@EventId", Form1.id); // valódi DB EventId
                    cmd.Parameters.AddWithValue("@UserId", regisztracio_bejelentkezes.id);
                    cmd.ExecuteNonQuery();
                }

                string[] datumok = mikor.Split('-');
                Form1.asd.Text = $"{nev}\n{datumok[0].Trim()} -\n{datumok[1].Trim()}";
                MessageBox.Show($"Sikeres jelentkezés!\n{regisztracio_bejelentkezes.nev}");
                this.Close();
            }
            else if (btnJelentkezes.Text == "Jelentkezés" && Form1.asd.Text.Trim() != "Nincs")
            {
                MessageBox.Show("Már jelentkeztél 1 eseményre!\nEgyszerre csak 1-re lehet jelentkezni!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (MySqlConnection con = new MySqlConnection(kapcsolat))
                {
                    con.Open();
                    string parancs = "UPDATE users SET EventId = NULL WHERE Id = @UserId";
                    MySqlCommand cmd = new MySqlCommand(parancs, con);
                    cmd.Parameters.AddWithValue("@UserId", regisztracio_bejelentkezes.id);
                    cmd.ExecuteNonQuery();
                }

                Form1.asd.Text = "Nincs";
                MessageBox.Show($"Sikeres lemondás!\n{regisztracio_bejelentkezes.nev}");
                this.Close();
            }
        }
    }
}
