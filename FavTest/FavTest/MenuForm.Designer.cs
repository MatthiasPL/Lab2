namespace FavTest
{
    partial class MenuForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNowePytanie = new System.Windows.Forms.Button();
            this.listPytania = new System.Windows.Forms.ListBox();
            this.buttonUsunPytanie = new System.Windows.Forms.Button();
            this.buttonUsunOdpowiedz = new System.Windows.Forms.Button();
            this.buttonDodajPytanie = new System.Windows.Forms.Button();
            this.buttonDodajOdpowiedz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textOdpowiedz = new System.Windows.Forms.TextBox();
            this.checkedListOdpowiedzi = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPytanie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZapiszTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonZapiszTest);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.buttonNowePytanie);
            this.splitContainer1.Panel1.Controls.Add(this.listPytania);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonUsunPytanie);
            this.splitContainer1.Panel2.Controls.Add(this.buttonUsunOdpowiedz);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDodajPytanie);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDodajOdpowiedz);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.textOdpowiedz);
            this.splitContainer1.Panel2.Controls.Add(this.checkedListOdpowiedzi);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textPytanie);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(784, 450);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lista pytań:";
            // 
            // buttonNowePytanie
            // 
            this.buttonNowePytanie.Location = new System.Drawing.Point(112, 411);
            this.buttonNowePytanie.Name = "buttonNowePytanie";
            this.buttonNowePytanie.Size = new System.Drawing.Size(95, 36);
            this.buttonNowePytanie.TabIndex = 1;
            this.buttonNowePytanie.Text = "Nowe pytanie";
            this.buttonNowePytanie.UseVisualStyleBackColor = true;
            // 
            // listPytania
            // 
            this.listPytania.FormattingEnabled = true;
            this.listPytania.Location = new System.Drawing.Point(3, 24);
            this.listPytania.Name = "listPytania";
            this.listPytania.Size = new System.Drawing.Size(204, 381);
            this.listPytania.TabIndex = 0;
            this.listPytania.SelectedIndexChanged += new System.EventHandler(this.listPytania_SelectedIndexChanged);
            // 
            // buttonUsunPytanie
            // 
            this.buttonUsunPytanie.Location = new System.Drawing.Point(220, 411);
            this.buttonUsunPytanie.Name = "buttonUsunPytanie";
            this.buttonUsunPytanie.Size = new System.Drawing.Size(167, 36);
            this.buttonUsunPytanie.TabIndex = 9;
            this.buttonUsunPytanie.Text = "Usuń pytanie";
            this.buttonUsunPytanie.UseVisualStyleBackColor = true;
            // 
            // buttonUsunOdpowiedz
            // 
            this.buttonUsunOdpowiedz.Location = new System.Drawing.Point(108, 411);
            this.buttonUsunOdpowiedz.Name = "buttonUsunOdpowiedz";
            this.buttonUsunOdpowiedz.Size = new System.Drawing.Size(106, 36);
            this.buttonUsunOdpowiedz.TabIndex = 8;
            this.buttonUsunOdpowiedz.Text = "Usuń odpowiedź";
            this.buttonUsunOdpowiedz.UseVisualStyleBackColor = true;
            // 
            // buttonDodajPytanie
            // 
            this.buttonDodajPytanie.Location = new System.Drawing.Point(393, 411);
            this.buttonDodajPytanie.Name = "buttonDodajPytanie";
            this.buttonDodajPytanie.Size = new System.Drawing.Size(174, 36);
            this.buttonDodajPytanie.TabIndex = 7;
            this.buttonDodajPytanie.Text = "Dodaj pytanie";
            this.buttonDodajPytanie.UseVisualStyleBackColor = true;
            // 
            // buttonDodajOdpowiedz
            // 
            this.buttonDodajOdpowiedz.Location = new System.Drawing.Point(3, 411);
            this.buttonDodajOdpowiedz.Name = "buttonDodajOdpowiedz";
            this.buttonDodajOdpowiedz.Size = new System.Drawing.Size(99, 36);
            this.buttonDodajOdpowiedz.TabIndex = 6;
            this.buttonDodajOdpowiedz.Text = "Dodaj odpowiedź";
            this.buttonDodajOdpowiedz.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Odpowiedź:";
            // 
            // textOdpowiedz
            // 
            this.textOdpowiedz.Location = new System.Drawing.Point(3, 129);
            this.textOdpowiedz.Multiline = true;
            this.textOdpowiedz.Name = "textOdpowiedz";
            this.textOdpowiedz.Size = new System.Drawing.Size(211, 276);
            this.textOdpowiedz.TabIndex = 4;
            // 
            // checkedListOdpowiedzi
            // 
            this.checkedListOdpowiedzi.FormattingEnabled = true;
            this.checkedListOdpowiedzi.Location = new System.Drawing.Point(220, 131);
            this.checkedListOdpowiedzi.Name = "checkedListOdpowiedzi";
            this.checkedListOdpowiedzi.Size = new System.Drawing.Size(347, 274);
            this.checkedListOdpowiedzi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Odpowiedzi:";
            // 
            // textPytanie
            // 
            this.textPytanie.Location = new System.Drawing.Point(3, 25);
            this.textPytanie.Multiline = true;
            this.textPytanie.Name = "textPytanie";
            this.textPytanie.Size = new System.Drawing.Size(564, 85);
            this.textPytanie.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Treść pytania:";
            // 
            // buttonZapiszTest
            // 
            this.buttonZapiszTest.Location = new System.Drawing.Point(3, 411);
            this.buttonZapiszTest.Name = "buttonZapiszTest";
            this.buttonZapiszTest.Size = new System.Drawing.Size(103, 36);
            this.buttonZapiszTest.TabIndex = 3;
            this.buttonZapiszTest.Text = "Zapisz test";
            this.buttonZapiszTest.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listPytania;
        private System.Windows.Forms.TextBox textPytanie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDodajPytanie;
        private System.Windows.Forms.Button buttonDodajOdpowiedz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textOdpowiedz;
        private System.Windows.Forms.CheckedListBox checkedListOdpowiedzi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNowePytanie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUsunOdpowiedz;
        private System.Windows.Forms.Button buttonUsunPytanie;
        private System.Windows.Forms.Button buttonZapiszTest;
    }
}