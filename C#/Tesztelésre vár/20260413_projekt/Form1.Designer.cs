namespace _20230413_projekt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip_HOME = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Jelentkezeseim = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kilepes = new System.Windows.Forms.Button();
            this.Esemenyek = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kereso = new System.Windows.Forms.TextBox();
            this.comb_kategoria = new System.Windows.Forms.ComboBox();
            this.lbl_nev = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Esemenyek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_HOME,
            this.MenuStrip_Jelentkezeseim,
            this.MenuStrip_Admin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 108, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(212, 738);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip_HOME
            // 
            this.menuStrip_HOME.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.menuStrip_HOME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip_HOME.Name = "menuStrip_HOME";
            this.menuStrip_HOME.Size = new System.Drawing.Size(193, 40);
            this.menuStrip_HOME.Text = "Home";
            this.menuStrip_HOME.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // MenuStrip_Jelentkezeseim
            // 
            this.MenuStrip_Jelentkezeseim.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.MenuStrip_Jelentkezeseim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MenuStrip_Jelentkezeseim.Name = "MenuStrip_Jelentkezeseim";
            this.MenuStrip_Jelentkezeseim.Size = new System.Drawing.Size(193, 40);
            this.MenuStrip_Jelentkezeseim.Text = "Jelentkazéseim";
            this.MenuStrip_Jelentkezeseim.Click += new System.EventHandler(this.MenuStrip_Jelentkezeseim_Click);
            // 
            // MenuStrip_Admin
            // 
            this.MenuStrip_Admin.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.MenuStrip_Admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MenuStrip_Admin.Name = "MenuStrip_Admin";
            this.MenuStrip_Admin.Size = new System.Drawing.Size(193, 40);
            this.MenuStrip_Admin.Text = "ADMIN";
            this.MenuStrip_Admin.Click += new System.EventHandler(this.aDMINToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iskola Eseménykezelő";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1392, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // kilepes
            // 
            this.kilepes.BackColor = System.Drawing.Color.Firebrick;
            this.kilepes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kilepes.ForeColor = System.Drawing.Color.White;
            this.kilepes.Location = new System.Drawing.Point(1240, 48);
            this.kilepes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kilepes.Name = "kilepes";
            this.kilepes.Size = new System.Drawing.Size(142, 65);
            this.kilepes.TabIndex = 3;
            this.kilepes.Text = "Kijelentkezés";
            this.kilepes.UseVisualStyleBackColor = false;
            this.kilepes.Click += new System.EventHandler(this.kilepes_Click);
            // 
            // Esemenyek
            // 
            this.Esemenyek.AllowUserToAddRows = false;
            this.Esemenyek.AllowUserToDeleteRows = false;
            this.Esemenyek.AllowUserToResizeColumns = false;
            this.Esemenyek.AllowUserToResizeRows = false;
            this.Esemenyek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Esemenyek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Esemenyek.Location = new System.Drawing.Point(273, 254);
            this.Esemenyek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Esemenyek.Name = "Esemenyek";
            this.Esemenyek.ReadOnly = true;
            this.Esemenyek.RowHeadersVisible = false;
            this.Esemenyek.RowHeadersWidth = 62;
            this.Esemenyek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Esemenyek.Size = new System.Drawing.Size(1239, 470);
            this.Esemenyek.TabIndex = 4;
            this.Esemenyek.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Esemenyek_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(268, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kereső:";
            // 
            // txt_kereso
            // 
            this.txt_kereso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_kereso.Location = new System.Drawing.Point(388, 180);
            this.txt_kereso.Name = "txt_kereso";
            this.txt_kereso.Size = new System.Drawing.Size(230, 37);
            this.txt_kereso.TabIndex = 6;
            this.txt_kereso.TextChanged += new System.EventHandler(this.txt_kereso_TextChanged);
            // 
            // comb_kategoria
            // 
            this.comb_kategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comb_kategoria.FormattingEnabled = true;
            this.comb_kategoria.Location = new System.Drawing.Point(1252, 183);
            this.comb_kategoria.Name = "comb_kategoria";
            this.comb_kategoria.Size = new System.Drawing.Size(260, 38);
            this.comb_kategoria.TabIndex = 7;
            this.comb_kategoria.SelectedIndexChanged += new System.EventHandler(this.comb_kategoria_SelectedIndexChanged);
            // 
            // lbl_nev
            // 
            this.lbl_nev.AutoSize = true;
            this.lbl_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_nev.ForeColor = System.Drawing.Color.White;
            this.lbl_nev.Location = new System.Drawing.Point(268, 108);
            this.lbl_nev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nev.Name = "lbl_nev";
            this.lbl_nev.Size = new System.Drawing.Size(77, 30);
            this.lbl_nev.TabIndex = 8;
            this.lbl_nev.Text = "name";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 440);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 154);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Jelentkezett esemény:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1122, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1521, 738);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_nev);
            this.Controls.Add(this.comb_kategoria);
            this.Controls.Add(this.txt_kereso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Esemenyek);
            this.Controls.Add(this.kilepes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1543, 794);
            this.MinimumSize = new System.Drawing.Size(1543, 794);
            this.Name = "Form1";
            this.Text = "Iskola Eseménykezelő";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Esemenyek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_HOME;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Jelentkezeseim;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kilepes;
        private System.Windows.Forms.DataGridView Esemenyek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kereso;
        private System.Windows.Forms.ComboBox comb_kategoria;
        private System.Windows.Forms.Label lbl_nev;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label valtozo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

