namespace SnapShot
{
    partial class Konfiguracja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Konfiguracja));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.b_przegladajNotatki = new System.Windows.Forms.Button();
            this.tb_sciezkaNotatki = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.b_przegladaj = new System.Windows.Forms.Button();
            this.tb_sciezka = new System.Windows.Forms.TextBox();
            this.fbd_szukajKatalogu = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.b_przegladajNotatki);
            this.groupBox1.Controls.Add(this.tb_sciezkaNotatki);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.b_przegladaj);
            this.groupBox1.Controls.Add(this.tb_sciezka);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustawienia folderów";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Taki sam dla obu przypadków";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // b_przegladajNotatki
            // 
            this.b_przegladajNotatki.Enabled = false;
            this.b_przegladajNotatki.Location = new System.Drawing.Point(224, 79);
            this.b_przegladajNotatki.Name = "b_przegladajNotatki";
            this.b_przegladajNotatki.Size = new System.Drawing.Size(75, 23);
            this.b_przegladajNotatki.TabIndex = 6;
            this.b_przegladajNotatki.Text = "Przeglądaj...";
            this.b_przegladajNotatki.UseVisualStyleBackColor = true;
            this.b_przegladajNotatki.Click += new System.EventHandler(this.b_przegladajNotatki_Click);
            // 
            // tb_sciezkaNotatki
            // 
            this.tb_sciezkaNotatki.Location = new System.Drawing.Point(6, 79);
            this.tb_sciezkaNotatki.Name = "tb_sciezkaNotatki";
            this.tb_sciezkaNotatki.ReadOnly = true;
            this.tb_sciezkaNotatki.Size = new System.Drawing.Size(212, 20);
            this.tb_sciezkaNotatki.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Folder notatek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Folder migawek";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_przegladaj
            // 
            this.b_przegladaj.Location = new System.Drawing.Point(224, 36);
            this.b_przegladaj.Name = "b_przegladaj";
            this.b_przegladaj.Size = new System.Drawing.Size(75, 23);
            this.b_przegladaj.TabIndex = 1;
            this.b_przegladaj.Text = "Przeglądaj...";
            this.b_przegladaj.UseVisualStyleBackColor = true;
            this.b_przegladaj.Click += new System.EventHandler(this.b_przegladaj_Click);
            // 
            // tb_sciezka
            // 
            this.tb_sciezka.Location = new System.Drawing.Point(6, 36);
            this.tb_sciezka.Name = "tb_sciezka";
            this.tb_sciezka.ReadOnly = true;
            this.tb_sciezka.Size = new System.Drawing.Size(212, 20);
            this.tb_sciezka.TabIndex = 0;
            // 
            // Konfiguracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 167);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(372, 159);
            this.Name = "Konfiguracja";
            this.Text = "Konfiguracja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_przegladaj;
        private System.Windows.Forms.TextBox tb_sciezka;
        private System.Windows.Forms.FolderBrowserDialog fbd_szukajKatalogu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button b_przegladajNotatki;
        private System.Windows.Forms.TextBox tb_sciezkaNotatki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}