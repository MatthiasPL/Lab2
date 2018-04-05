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
            this.buttonGenerator = new System.Windows.Forms.Button();
            this.buttonSolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGenerator
            // 
            this.buttonGenerator.Location = new System.Drawing.Point(12, 12);
            this.buttonGenerator.Name = "buttonGenerator";
            this.buttonGenerator.Size = new System.Drawing.Size(237, 132);
            this.buttonGenerator.TabIndex = 0;
            this.buttonGenerator.Text = "Generator";
            this.buttonGenerator.UseVisualStyleBackColor = true;
            // 
            // buttonSolver
            // 
            this.buttonSolver.Location = new System.Drawing.Point(255, 12);
            this.buttonSolver.Name = "buttonSolver";
            this.buttonSolver.Size = new System.Drawing.Size(223, 132);
            this.buttonSolver.TabIndex = 1;
            this.buttonSolver.Text = "Solver";
            this.buttonSolver.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 156);
            this.Controls.Add(this.buttonSolver);
            this.Controls.Add(this.buttonGenerator);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerator;
        private System.Windows.Forms.Button buttonSolver;
    }
}