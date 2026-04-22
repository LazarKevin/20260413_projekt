namespace _20230413_projekt
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.label1 = new System.Windows.Forms.Label();
            this.tipus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.kereso = new System.Windows.Forms.TextBox();
            this.dgv_admin_esemenyek = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.valtozo_admin = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_esemenyek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Típus:";
            // 
            // tipus
            // 
            this.tipus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tipus.FormattingEnabled = true;
            this.tipus.Location = new System.Drawing.Point(152, 14);
            this.tipus.Name = "tipus";
            this.tipus.Size = new System.Drawing.Size(254, 38);
            this.tipus.TabIndex = 1;
            this.tipus.SelectedIndexChanged += new System.EventHandler(this.tipus_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dátum:";
            // 
            // datum
            // 
            this.datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datum.Location = new System.Drawing.Point(152, 94);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(392, 37);
            this.datum.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Keresés:";
            // 
            // kereso
            // 
            this.kereso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kereso.Location = new System.Drawing.Point(152, 166);
            this.kereso.Name = "kereso";
            this.kereso.Size = new System.Drawing.Size(211, 37);
            this.kereso.TabIndex = 7;
            this.kereso.TextChanged += new System.EventHandler(this.kereso_TextChanged);
            // 
            // dgv_admin_esemenyek
            // 
            this.dgv_admin_esemenyek.AllowUserToAddRows = false;
            this.dgv_admin_esemenyek.AllowUserToDeleteRows = false;
            this.dgv_admin_esemenyek.AllowUserToResizeColumns = false;
            this.dgv_admin_esemenyek.AllowUserToResizeRows = false;
            this.dgv_admin_esemenyek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_admin_esemenyek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin_esemenyek.Location = new System.Drawing.Point(27, 248);
            this.dgv_admin_esemenyek.Name = "dgv_admin_esemenyek";
            this.dgv_admin_esemenyek.RowHeadersVisible = false;
            this.dgv_admin_esemenyek.RowHeadersWidth = 62;
            this.dgv_admin_esemenyek.RowTemplate.Height = 28;
            this.dgv_admin_esemenyek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_admin_esemenyek.ShowEditingIcon = false;
            this.dgv_admin_esemenyek.Size = new System.Drawing.Size(1212, 295);
            this.dgv_admin_esemenyek.TabIndex = 8;
            this.dgv_admin_esemenyek.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_admin_esemenyek_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(27, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 75);
            this.button1.TabIndex = 9;
            this.button1.Text = "Új esemény";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(340, 611);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 75);
            this.button2.TabIndex = 10;
            this.button2.Text = "Módosítás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(652, 611);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 75);
            this.button3.TabIndex = 11;
            this.button3.Text = "Törlés";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(958, 611);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(280, 75);
            this.button4.TabIndex = 12;
            this.button4.Text = "Mentés .txt-be";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // valtozo_admin
            // 
            this.valtozo_admin.AutoSize = true;
            this.valtozo_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valtozo_admin.Location = new System.Drawing.Point(1053, 45);
            this.valtozo_admin.Name = "valtozo_admin";
            this.valtozo_admin.Size = new System.Drawing.Size(186, 58);
            this.valtozo_admin.TabIndex = 13;
            this.valtozo_admin.Text = "ADMIN";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(979, 152);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(255, 51);
            this.button5.TabIndex = 14;
            this.button5.Text = "Bejövő regisztrációk";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(842, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1250, 689);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.valtozo_admin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_admin_esemenyek);
            this.Controls.Add(this.kereso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipus);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1272, 745);
            this.MinimumSize = new System.Drawing.Size(1272, 745);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_esemenyek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tipus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kereso;
        private System.Windows.Forms.DataGridView dgv_admin_esemenyek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label valtozo_admin;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}