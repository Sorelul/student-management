
namespace ProiectTAP
{
    partial class PaginaPrincipala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipala));
            this.lblAutor = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specializariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscrieriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.Lavender;
            this.lblAutor.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(137, 124);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(311, 33);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor: Cotuna Dumitru-Sorin";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(237, 283);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 35);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(266, 231);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(100, 20);
            this.txtParola.TabIndex = 10;
            this.txtParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParola_KeyDown);
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(266, 192);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(100, 20);
            this.txtUtilizator.TabIndex = 9;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.BackColor = System.Drawing.Color.Lavender;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParola.Location = new System.Drawing.Point(190, 231);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(58, 20);
            this.lblParola.TabIndex = 8;
            this.lblParola.Text = "Parola:";
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.BackColor = System.Drawing.Color.Lavender;
            this.lblUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilizator.Location = new System.Drawing.Point(173, 192);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(75, 20);
            this.lblUtilizator.TabIndex = 7;
            this.lblUtilizator.Text = "Utilizator:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentiToolStripMenuItem,
            this.specializariToolStripMenuItem,
            this.inscrieriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.studentiToolStripMenuItem.Text = "Studenti";
            this.studentiToolStripMenuItem.Click += new System.EventHandler(this.studentiToolStripMenuItem_Click);
            // 
            // specializariToolStripMenuItem
            // 
            this.specializariToolStripMenuItem.Name = "specializariToolStripMenuItem";
            this.specializariToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.specializariToolStripMenuItem.Text = "Specializari";
            this.specializariToolStripMenuItem.Click += new System.EventHandler(this.specializariToolStripMenuItem_Click);
            // 
            // inscrieriToolStripMenuItem
            // 
            this.inscrieriToolStripMenuItem.Name = "inscrieriToolStripMenuItem";
            this.inscrieriToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.inscrieriToolStripMenuItem.Text = "Inscrieri";
            this.inscrieriToolStripMenuItem.Click += new System.EventHandler(this.inscrieriToolStripMenuItem_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.BackColor = System.Drawing.Color.Lavender;
            this.lblTitlu.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(12, 63);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(569, 37);
            this.lblTitlu.TabIndex = 13;
            this.lblTitlu.Text = "Aplicatie pt. inscrierea studentilor dintr-o facultate";
            // 
            // PaginaPrincipala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::ProiectTAP.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUtilizator);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PaginaPrincipala";
            this.Text = "Pagina Principala";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblUtilizator;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specializariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscrieriToolStripMenuItem;
        private System.Windows.Forms.Label lblTitlu;
    }
}

