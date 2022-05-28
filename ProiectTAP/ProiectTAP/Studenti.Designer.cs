
namespace ProiectTAP
{
    partial class Studenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studenti));
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProiectTAP.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentiTableAdapter = new ProiectTAP.DataSet1TableAdapters.StudentiTableAdapter();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdStudent = new System.Windows.Forms.TextBox();
            this.lblIdStudent = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            this.txtSpPoza = new System.Windows.Forms.TextBox();
            this.txtNrTelefon = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.txtNumeStudent = new System.Windows.Forms.TextBox();
            this.lblSpPoza = new System.Windows.Forms.Label();
            this.lblNrTelefon = new System.Windows.Forms.Label();
            this.lblCNP = new System.Windows.Forms.Label();
            this.lblNumeStudent = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblOp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.Location = new System.Drawing.Point(11, 26);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(109, 26);
            this.btnAdaugare.TabIndex = 1;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificare.Location = new System.Drawing.Point(139, 26);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(109, 26);
            this.btnModificare.TabIndex = 2;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.Location = new System.Drawing.Point(272, 26);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(109, 26);
            this.btnStergere.TabIndex = 3;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeStudentDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.nrTelefonDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentiBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.Location = new System.Drawing.Point(11, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 240);
            this.dataGridView1.TabIndex = 4;
            // 
            // numeStudentDataGridViewTextBoxColumn
            // 
            this.numeStudentDataGridViewTextBoxColumn.DataPropertyName = "NumeStudent";
            this.numeStudentDataGridViewTextBoxColumn.HeaderText = "NumeStudent";
            this.numeStudentDataGridViewTextBoxColumn.Name = "numeStudentDataGridViewTextBoxColumn";
            this.numeStudentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrTelefonDataGridViewTextBoxColumn
            // 
            this.nrTelefonDataGridViewTextBoxColumn.DataPropertyName = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.HeaderText = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.Name = "nrTelefonDataGridViewTextBoxColumn";
            this.nrTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            this.spImagineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentiBindingSource
            // 
            this.studentiBindingSource.DataMember = "Studenti";
            this.studentiBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // studentiTableAdapter
            // 
            this.studentiTableAdapter.ClearBeforeFill = true;
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmare.Location = new System.Drawing.Point(525, 28);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(109, 26);
            this.btnConfirmare.TabIndex = 5;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenuntare.Location = new System.Drawing.Point(653, 28);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(109, 26);
            this.btnRenuntare.TabIndex = 6;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ProiectTAP.Properties.Resources.background;
            this.groupBox1.Controls.Add(this.txtIdStudent);
            this.groupBox1.Controls.Add(this.lblIdStudent);
            this.groupBox1.Controls.Add(this.pb);
            this.groupBox1.Controls.Add(this.txtSpPoza);
            this.groupBox1.Controls.Add(this.txtNrTelefon);
            this.groupBox1.Controls.Add(this.txtCNP);
            this.groupBox1.Controls.Add(this.txtNumeStudent);
            this.groupBox1.Controls.Add(this.lblSpPoza);
            this.groupBox1.Controls.Add(this.lblNrTelefon);
            this.groupBox1.Controls.Add(this.lblCNP);
            this.groupBox1.Controls.Add(this.lblNumeStudent);
            this.groupBox1.Location = new System.Drawing.Point(529, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 250);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.Location = new System.Drawing.Point(124, 199);
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.Size = new System.Drawing.Size(169, 20);
            this.txtIdStudent.TabIndex = 14;
            // 
            // lblIdStudent
            // 
            this.lblIdStudent.AutoSize = true;
            this.lblIdStudent.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdStudent.Location = new System.Drawing.Point(6, 198);
            this.lblIdStudent.Name = "lblIdStudent";
            this.lblIdStudent.Size = new System.Drawing.Size(70, 19);
            this.lblIdStudent.TabIndex = 13;
            this.lblIdStudent.Text = "IdStudent";
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(308, 32);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(204, 188);
            this.pb.TabIndex = 12;
            this.pb.TabStop = false;
            // 
            // txtSpPoza
            // 
            this.txtSpPoza.Location = new System.Drawing.Point(124, 157);
            this.txtSpPoza.Name = "txtSpPoza";
            this.txtSpPoza.Size = new System.Drawing.Size(169, 20);
            this.txtSpPoza.TabIndex = 10;
            this.txtSpPoza.DoubleClick += new System.EventHandler(this.txtSpPoza_DoubleClick);
            // 
            // txtNrTelefon
            // 
            this.txtNrTelefon.Location = new System.Drawing.Point(124, 116);
            this.txtNrTelefon.Name = "txtNrTelefon";
            this.txtNrTelefon.Size = new System.Drawing.Size(169, 20);
            this.txtNrTelefon.TabIndex = 8;
            this.txtNrTelefon.TextChanged += new System.EventHandler(this.txtNrTelefon_TextChanged);
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(124, 79);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(169, 20);
            this.txtCNP.TabIndex = 7;
            this.txtCNP.Leave += new System.EventHandler(this.txtCNP_Leave);
            // 
            // txtNumeStudent
            // 
            this.txtNumeStudent.Location = new System.Drawing.Point(124, 31);
            this.txtNumeStudent.Name = "txtNumeStudent";
            this.txtNumeStudent.Size = new System.Drawing.Size(169, 20);
            this.txtNumeStudent.TabIndex = 6;
            // 
            // lblSpPoza
            // 
            this.lblSpPoza.AutoSize = true;
            this.lblSpPoza.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpPoza.Location = new System.Drawing.Point(6, 157);
            this.lblSpPoza.Name = "lblSpPoza";
            this.lblSpPoza.Size = new System.Drawing.Size(54, 19);
            this.lblSpPoza.TabIndex = 4;
            this.lblSpPoza.Text = "SpPoza";
            // 
            // lblNrTelefon
            // 
            this.lblNrTelefon.AutoSize = true;
            this.lblNrTelefon.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrTelefon.Location = new System.Drawing.Point(6, 117);
            this.lblNrTelefon.Name = "lblNrTelefon";
            this.lblNrTelefon.Size = new System.Drawing.Size(101, 19);
            this.lblNrTelefon.TabIndex = 2;
            this.lblNrTelefon.Text = "Numar Telefon";
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNP.Location = new System.Drawing.Point(6, 80);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(37, 19);
            this.lblCNP.TabIndex = 1;
            this.lblCNP.Text = "CNP";
            // 
            // lblNumeStudent
            // 
            this.lblNumeStudent.AutoSize = true;
            this.lblNumeStudent.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeStudent.Location = new System.Drawing.Point(6, 32);
            this.lblNumeStudent.Name = "lblNumeStudent";
            this.lblNumeStudent.Size = new System.Drawing.Size(100, 19);
            this.lblNumeStudent.TabIndex = 0;
            this.lblNumeStudent.Text = "Nume Student";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(895, 30);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 24);
            this.lblOp.TabIndex = 8;
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectTAP.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1088, 322);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Studenti";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.Studenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource studentiBindingSource;
        private DataSet1TableAdapters.StudentiTableAdapter studentiTableAdapter;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.TextBox txtSpPoza;
        private System.Windows.Forms.TextBox txtNrTelefon;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.TextBox txtNumeStudent;
        private System.Windows.Forms.Label lblSpPoza;
        private System.Windows.Forms.Label lblNrTelefon;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.Label lblNumeStudent;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtIdStudent;
        private System.Windows.Forms.Label lblIdStudent;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
    }
}