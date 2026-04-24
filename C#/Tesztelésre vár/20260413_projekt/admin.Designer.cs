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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.kereso = new System.Windows.Forms.TextBox();
            this.dgv_admin_esemenyek = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Típus:";
            // 
            // tipus
            // 
            this.tipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tipus.FormattingEnabled = true;
            this.tipus.Location = new System.Drawing.Point(101, 9);
            this.tipus.Margin = new System.Windows.Forms.Padding(2);
            this.tipus.Name = "tipus";
            this.tipus.Size = new System.Drawing.Size(171, 28);
            this.tipus.TabIndex = 1;
            this.tipus.SelectedIndexChanged += new System.EventHandler(this.tipus_SelectedIndexChanged);
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
            this.label3.Location = new System.Drawing.Point(14, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Keresés:";
            // 
            // kereso
            // 
            this.kereso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kereso.Location = new System.Drawing.Point(101, 60);
            this.kereso.Margin = new System.Windows.Forms.Padding(2);
            this.kereso.Name = "kereso";
            this.kereso.Size = new System.Drawing.Size(171, 27);
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
            this.dgv_admin_esemenyek.Location = new System.Drawing.Point(18, 161);
            this.dgv_admin_esemenyek.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_admin_esemenyek.Name = "dgv_admin_esemenyek";
            this.dgv_admin_esemenyek.RowHeadersVisible = false;
            this.dgv_admin_esemenyek.RowHeadersWidth = 62;
            this.dgv_admin_esemenyek.RowTemplate.Height = 28;
            this.dgv_admin_esemenyek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_admin_esemenyek.ShowEditingIcon = false;
            this.dgv_admin_esemenyek.Size = new System.Drawing.Size(808, 192);
            this.dgv_admin_esemenyek.TabIndex = 8;
            this.dgv_admin_esemenyek.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_admin_esemenyek_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(18, 397);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Új esemény";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(227, 397);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 49);
            this.button2.TabIndex = 10;
            this.button2.Text = "Módosítás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(435, 397);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 49);
            this.button3.TabIndex = 11;
            this.button3.Text = "Törlés";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // valtozo_admin
            // 
            this.valtozo_admin.AutoSize = true;
            this.valtozo_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valtozo_admin.Location = new System.Drawing.Point(702, 29);
            this.valtozo_admin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valtozo_admin.Name = "valtozo_admin";
            this.valtozo_admin.Size = new System.Drawing.Size(128, 39);
            this.valtozo_admin.TabIndex = 13;
            this.valtozo_admin.Text = "ADMIN";
            this.valtozo_admin.Click += new System.EventHandler(this.valtozo_admin_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(639, 397);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 49);
            this.button5.TabIndex = 14;
            this.button5.Text = "Bejövő regisztrációk";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(759, 92);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(837, 459);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.valtozo_admin);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_admin_esemenyek);
            this.Controls.Add(this.kereso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tipus);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(853, 498);
            this.MinimumSize = new System.Drawing.Size(853, 498);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kereso;
        private System.Windows.Forms.DataGridView dgv_admin_esemenyek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label valtozo_admin;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}