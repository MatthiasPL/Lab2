namespace Lab2
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
            this.groupBoxUzytkownik = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.labelWiek = new System.Windows.Forms.Label();
            this.numericUpDownWiek = new System.Windows.Forms.NumericUpDown();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.labelImie = new System.Windows.Forms.Label();
            this.errorProviderPolTekstowych = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxUzytkownik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWiek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPolTekstowych)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUzytkownik
            // 
            this.groupBoxUzytkownik.Controls.Add(this.listBox1);
            this.groupBoxUzytkownik.Controls.Add(this.buttonDodaj);
            this.groupBoxUzytkownik.Controls.Add(this.labelWiek);
            this.groupBoxUzytkownik.Controls.Add(this.numericUpDownWiek);
            this.groupBoxUzytkownik.Controls.Add(this.textBoxNazwisko);
            this.groupBoxUzytkownik.Controls.Add(this.labelNazwisko);
            this.groupBoxUzytkownik.Controls.Add(this.textBoxImie);
            this.groupBoxUzytkownik.Controls.Add(this.labelImie);
            this.groupBoxUzytkownik.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUzytkownik.Name = "groupBoxUzytkownik";
            this.groupBoxUzytkownik.Size = new System.Drawing.Size(660, 408);
            this.groupBoxUzytkownik.TabIndex = 0;
            this.groupBoxUzytkownik.TabStop = false;
            this.groupBoxUzytkownik.Text = "Użytkownik";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(196, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(464, 407);
            this.listBox1.TabIndex = 7;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(73, 108);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(100, 23);
            this.buttonDodaj.TabIndex = 6;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // labelWiek
            // 
            this.labelWiek.AutoSize = true;
            this.labelWiek.Location = new System.Drawing.Point(70, 84);
            this.labelWiek.Name = "labelWiek";
            this.labelWiek.Size = new System.Drawing.Size(32, 13);
            this.labelWiek.TabIndex = 5;
            this.labelWiek.Text = "Wiek";
            // 
            // numericUpDownWiek
            // 
            this.numericUpDownWiek.Location = new System.Drawing.Point(114, 82);
            this.numericUpDownWiek.Maximum = new decimal(new int[] {
            88,
            0,
            0,
            0});
            this.numericUpDownWiek.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownWiek.Name = "numericUpDownWiek";
            this.numericUpDownWiek.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownWiek.TabIndex = 4;
            this.numericUpDownWiek.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(73, 56);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwisko.TabIndex = 3;
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(9, 59);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(56, 13);
            this.labelNazwisko.TabIndex = 2;
            this.labelNazwisko.Text = "Nazwisko:";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(73, 19);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 1;
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(9, 22);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(29, 13);
            this.labelImie.TabIndex = 0;
            this.labelImie.Text = "Imię:";
            // 
            // errorProviderPolTekstowych
            // 
            this.errorProviderPolTekstowych.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 432);
            this.Controls.Add(this.groupBoxUzytkownik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxUzytkownik.ResumeLayout(false);
            this.groupBoxUzytkownik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWiek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPolTekstowych)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUzytkownik;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label labelWiek;
        private System.Windows.Forms.NumericUpDown numericUpDownWiek;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.ErrorProvider errorProviderPolTekstowych;
    }
}

