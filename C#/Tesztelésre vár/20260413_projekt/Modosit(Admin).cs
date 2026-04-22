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

namespace _20230413_projekt
{
    public partial class Modosit_Admin_ : Form
    {
        public Modosit_Admin_()
        {
            InitializeComponent();
        }

        private void Modosit_Admin__Load(object sender, EventArgs e)
        {
            string id = admin.id;
            txt_nev.Text = admin.nev;
            rtxt_leiras.Text = admin.leiras;
            txt_mettol.Text = admin.mettol;
            txt_meddig.Text = admin.meddig;
            txt_categ.Text = admin.kateg;
            chbox_fontos.Checked = admin.fontose;
            txt_helyszin.Text = admin.helyszin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kapcsolat = "server=localhost;database=iskola;uid=root;pwd=mysql";

            try
            {
                using (MySqlConnection con = new MySqlConnection(kapcsolat))
                {
                    con.Open();

                    string cmd = @"UPDATE Eventt SET Name = @name, Descr = @descr, Datetol = @datetol, Dateig = @dateig, Categ = @categ, Important = @important, Wheres = @wheres WHERE Id = @id";

                    MySqlCommand parancs = new MySqlCommand(cmd, con);
                    parancs.Parameters.AddWithValue("@id", admin.id);
                    parancs.Parameters.AddWithValue("@name", txt_nev.Text);
                    parancs.Parameters.AddWithValue("@descr", rtxt_leiras.Text);
                    parancs.Parameters.AddWithValue("@datetol", DateTime.Parse( txt_mettol.Text));
                    parancs.Parameters.AddWithValue("@dateig", DateTime.Parse(txt_meddig.Text));
                    parancs.Parameters.AddWithValue("@categ", txt_categ.Text);
                    parancs.Parameters.AddWithValue("@important", chbox_fontos.Checked);
                    parancs.Parameters.AddWithValue("@wheres", txt_helyszin.Text);
                    parancs.ExecuteNonQuery();
                    MessageBox.Show("Sikeres módosítás!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a módosítás során!\n" + ex.Message);
            }
            
        }
    }
}
