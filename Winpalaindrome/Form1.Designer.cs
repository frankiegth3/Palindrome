namespace Winpalaindrome
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadFile = new System.Windows.Forms.Button();
            this.lstAll = new System.Windows.Forms.ListBox();
            this.lstPalaindrome = new System.Windows.Forms.ListBox();
            this.lstNotPalaindrome = new System.Windows.Forms.ListBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(104, 42);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(265, 23);
            this.ReadFile.TabIndex = 0;
            this.ReadFile.Text = "Lire Fichier Palaindrome";
            this.ReadFile.UseVisualStyleBackColor = true;
            // 
            // lstAll
            // 
            this.lstAll.FormattingEnabled = true;
            this.lstAll.Location = new System.Drawing.Point(30, 92);
            this.lstAll.Name = "lstAll";
            this.lstAll.Size = new System.Drawing.Size(120, 342);
            this.lstAll.TabIndex = 1;
            // 
            // lstPalaindrome
            // 
            this.lstPalaindrome.FormattingEnabled = true;
            this.lstPalaindrome.Location = new System.Drawing.Point(420, 89);
            this.lstPalaindrome.Name = "lstPalaindrome";
            this.lstPalaindrome.Size = new System.Drawing.Size(120, 342);
            this.lstPalaindrome.TabIndex = 2;
            // 
            // lstNotPalaindrome
            // 
            this.lstNotPalaindrome.FormattingEnabled = true;
            this.lstNotPalaindrome.Location = new System.Drawing.Point(602, 89);
            this.lstNotPalaindrome.Name = "lstNotPalaindrome";
            this.lstNotPalaindrome.Size = new System.Drawing.Size(120, 329);
            this.lstNotPalaindrome.TabIndex = 3;
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(180, 145);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(199, 94);
            this.BtnFilter.TabIndex = 4;
            this.BtnFilter.Text = "Filter les Palaindrome";
            this.BtnFilter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.lstNotPalaindrome);
            this.Controls.Add(this.lstPalaindrome);
            this.Controls.Add(this.lstAll);
            this.Controls.Add(this.ReadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.ListBox lstAll;
        private System.Windows.Forms.ListBox lstPalaindrome;
        private System.Windows.Forms.ListBox lstNotPalaindrome;
        private System.Windows.Forms.Button BtnFilter;
    }
}

