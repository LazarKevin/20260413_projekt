using BCrypt.Net;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230413_projekt
{
    public partial class regisztracio_bejelentkezes : Form
    {
        public static bool ADMINE = false;
        public static int i = 1;
        public bool regisztracio = false;
        public static string nev = "";
        public static int id = -1;
        public regisztracio_bejelentkezes()
        {
            InitializeComponent();
        }

        private void regisztracio_bejelentkezes_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Új felhaszáló vagy?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Text = "Regisztráció";
                belepes.Text = "Regisztráció";
                admine.Visible = true;
                regisztracio = true;
            }
            else
            {
                this.Text = "Bejelentkezés";
                belepes.Text = "Bejelentkezés";
                admine.Visible = false;
                regisztracio = false;

                #region ÁRAKÁSOK
                pb_bal.Visible = false;
                pb_jobb.Visible = false;
                profilkep.Visible = false;

                label2.Location = new Point(84, 129);
                txtbox_felhaszn.Location = new Point(250, 126);

                label3.Location = new Point(84, 212);
                txtbox_jelszo.Location = new Point(250, 212);
                elrejtes.Location = new Point(465, 213);

                label4.Location = new Point(84, 295);
                txt_email.Location = new Point(250, 295);

                belepes.Location = new Point(200, 375);

                this.Size = new Size(550, 500);

                #endregion



            }

            profilkep.Image = Image.FromFile($"{i}.jpg");
        }

        private void belepes_Click(object sender, EventArgs e)
        {
            if (txtbox_felhaszn.Text != "" && txtbox_jelszo.Text != "" && txt_email.Text.Contains('@'))
            {
                if (admine.Checked) ADMINE = true;
                else ADMINE = false;

                if (txtbox_felhaszn.Text == "ADMIN") ADMINE = true;

                nev = txtbox_felhaszn.Text;

                if (regisztracio)
                {
                    string kapcsolat = "server=localhost;database=iskola;uid=root;pwd=mysql";

                    using (MySqlConnection connection = new MySqlConnection(kapcsolat))
                    {
                        connection.Open();

                        string nev = txtbox_felhaszn.Text;
                        string jelszo = txtbox_jelszo.Text;
                        string titkositott = BCrypt.Net.BCrypt.HashPassword(jelszo, BCrypt.Net.BCrypt.GenerateSalt());
                        string email = txt_email.Text;
                        int imgnumber = i;
                        bool adminE = ADMINE; 

                        string sql = "INSERT INTO Regist (Name, Password, Email, ImgNumber, AdminE) VALUES (@Name, @Password, @Email, @ImgNumber, @AdminE)";
                        MySqlCommand parancs = new MySqlCommand(sql, connection);
                        parancs.Parameters.AddWithValue("@Name", nev);
                        parancs.Parameters.AddWithValue("@Password", titkositott);
                        parancs.Parameters.AddWithValue("@Email", email);
                        parancs.Parameters.AddWithValue("@ImgNumber", i + ".png");
                        parancs.Parameters.AddWithValue("@AdminE", adminE);

                        parancs.ExecuteNonQuery();
                        MessageBox.Show("Sikeres regisztráció!\nAddig nem bír bejelentkezni míg egy ADMIN el nem fogadja!","FONTOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Az ablak bezárul 3 másodperc múlva!");
                        Thread.Sleep(3000);

                        this.Close();
                        connection.Close();
                    }
                }
                else
                {
                    string kapcsolat = "server=localhost;database=iskola;uid=root;pwd=mysql";

                    using (MySqlConnection connection = new MySqlConnection(kapcsolat))
                    {
                        connection.Open();

                        string nev = txtbox_felhaszn.Text;
                        string jelszo = txtbox_jelszo.Text;
                        string titkositott = BCrypt.Net.BCrypt.HashPassword(jelszo, BCrypt.Net.BCrypt.GenerateSalt());
                        string email = txt_email.Text;

                        List<int> idk = new List<int>();
                        List<string> nevek = new List<string>();
                        List<string> jelszavak = new List<string>();
                        List<string> emailek = new List<string>();
                        List<bool> adminok = new List<bool>();

                        string sql = "SELECT users.Id, users.Name, users.Password, users.email, users.AdminE FROM users";
                        MySqlCommand parancs = new MySqlCommand(sql, connection);
                        MySqlDataReader olvaso = parancs.ExecuteReader();

                        while (olvaso.Read())
                        {
                            idk.Add(olvaso.GetInt32(0));
                            nevek.Add(olvaso.GetString(1));
                            jelszavak.Add(olvaso.GetString(2));
                            emailek.Add(olvaso.GetString(3));
                            adminok.Add(olvaso.GetBoolean(4));

                        }

                        if (nevek.Contains(nev))
                        {
                            int i = nevek.IndexOf(nev);
                            if (BCrypt.Net.BCrypt.Verify(jelszo, jelszavak[i]))
                            {
                                if (emailek.Contains(email))
                                {
                                    id = idk[i];         
                                    ADMINE = adminok[i];   
                                    MessageBox.Show("Sikeres bejelentkezés!");
                                    this.Hide();

                                    Form1 form1 = new Form1();
                                    form1.ShowDialog();

                                    Application.Exit();
                                }
                                else
                                {
                                    MessageBox.Show("Hibás email!");
                                    txt_email.Text = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Hibás jelszó!");
                                txtbox_jelszo.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Felhasználó nem található!");
                            txtbox_felhaszn.Text = "";
                            txtbox_jelszo.Text = "";
                        }
                        connection.Close();
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Nem adtál meg minden adatot!\nVagy\nNem megfelelően adtad meg az adatokat!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddEllipse(0, 0, profilkep.Width, profilkep.Height);

            profilkep.Region = new Region(gp);
        }

        private void elrejtes_Click(object sender, EventArgs e)
        {
            if (txtbox_jelszo.PasswordChar == '*')
            {
                txtbox_jelszo.PasswordChar = '\0';
                elrejtes.Image = Image.FromFile("igen.png");
            }
            else
            {
                txtbox_jelszo.PasswordChar = '*';
                elrejtes.Image = Image.FromFile("nem.png");
            }
        }

        private void pb_bal_Click(object sender, EventArgs e)
        {
            i--;
            if (i == 0) i = 5;
            profilkep.Image = Image.FromFile($"{i}.jpg");
        }

        private void pb_jobb_Click(object sender, EventArgs e)
        {
            i++;
            if (i == 6) i = 1;
            profilkep.Image = Image.FromFile($"{i}.jpg");
        }
    }
}
