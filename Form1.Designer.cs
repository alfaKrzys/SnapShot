namespace SnapShot
{
    partial class f_pstryk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_pstryk));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfiguracjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_listaKamer = new System.Windows.Forms.ComboBox();
            this.pb_obrazZkamery = new System.Windows.Forms.PictureBox();
            this.b_pstryk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_zapiszNotatke = new System.Windows.Forms.Button();
            this.tx_notatka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_imieInazwisko = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_obrazZkamery)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfiguracjaToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // konfiguracjaToolStripMenuItem
            // 
            this.konfiguracjaToolStripMenuItem.Name = "konfiguracjaToolStripMenuItem";
            this.konfiguracjaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.konfiguracjaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.konfiguracjaToolStripMenuItem.Text = "Konfiguracja...";
            this.konfiguracjaToolStripMenuItem.Click += new System.EventHandler(this.konfiguracjaToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.oProgramieToolStripMenuItem.Text = "O Programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cb_listaKamer);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kamera";
            // 
            // cb_listaKamer
            // 
            this.cb_listaKamer.FormattingEnabled = true;
            this.cb_listaKamer.Location = new System.Drawing.Point(7, 20);
            this.cb_listaKamer.Name = "cb_listaKamer";
            this.cb_listaKamer.Size = new System.Drawing.Size(163, 21);
            this.cb_listaKamer.TabIndex = 0;
            this.cb_listaKamer.SelectedIndexChanged += new System.EventHandler(this.cb_listaKamer_SelectedIndexChanged);
            // 
            // pb_obrazZkamery
            // 
            this.pb_obrazZkamery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_obrazZkamery.Location = new System.Drawing.Point(196, 28);
            this.pb_obrazZkamery.MaximumSize = new System.Drawing.Size(1024, 768);
            this.pb_obrazZkamery.Name = "pb_obrazZkamery";
            this.pb_obrazZkamery.Size = new System.Drawing.Size(424, 302);
            this.pb_obrazZkamery.TabIndex = 3;
            this.pb_obrazZkamery.TabStop = false;
            // 
            // b_pstryk
            // 
            this.b_pstryk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_pstryk.Location = new System.Drawing.Point(294, 336);
            this.b_pstryk.Name = "b_pstryk";
            this.b_pstryk.Size = new System.Drawing.Size(228, 50);
            this.b_pstryk.TabIndex = 4;
            this.b_pstryk.Text = "Pstryk!";
            this.b_pstryk.UseVisualStyleBackColor = true;
            this.b_pstryk.Click += new System.EventHandler(this.b_pstryk_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.b_zapiszNotatke);
            this.groupBox2.Controls.Add(this.tx_notatka);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tx_imieInazwisko);
            this.groupBox2.Location = new System.Drawing.Point(13, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 298);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notatka";
            // 
            // b_zapiszNotatke
            // 
            this.b_zapiszNotatke.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_zapiszNotatke.Location = new System.Drawing.Point(22, 248);
            this.b_zapiszNotatke.Name = "b_zapiszNotatke";
            this.b_zapiszNotatke.Size = new System.Drawing.Size(135, 44);
            this.b_zapiszNotatke.TabIndex = 4;
            this.b_zapiszNotatke.Text = "Zapisz";
            this.b_zapiszNotatke.UseVisualStyleBackColor = true;
            this.b_zapiszNotatke.Click += new System.EventHandler(this.b_zapiszNotatke_Click);
            // 
            // tx_notatka
            // 
            this.tx_notatka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tx_notatka.Location = new System.Drawing.Point(7, 76);
            this.tx_notatka.Multiline = true;
            this.tx_notatka.Name = "tx_notatka";
            this.tx_notatka.Size = new System.Drawing.Size(164, 166);
            this.tx_notatka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notatka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię i nazwisko:";
            // 
            // tx_imieInazwisko
            // 
            this.tx_imieInazwisko.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tx_imieInazwisko.Location = new System.Drawing.Point(7, 32);
            this.tx_imieInazwisko.Name = "tx_imieInazwisko";
            this.tx_imieInazwisko.Size = new System.Drawing.Size(163, 20);
            this.tx_imieInazwisko.TabIndex = 0;
            // 
            // f_pstryk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 398);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.b_pstryk);
            this.Controls.Add(this.pb_obrazZkamery);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_pstryk";
            this.Text = "Pstryk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f_pstryk_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_obrazZkamery)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfiguracjaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_listaKamer;
        private System.Windows.Forms.PictureBox pb_obrazZkamery;
        private System.Windows.Forms.Button b_pstryk;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tx_imieInazwisko;
        private System.Windows.Forms.Button b_zapiszNotatke;
        private System.Windows.Forms.TextBox tx_notatka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}

