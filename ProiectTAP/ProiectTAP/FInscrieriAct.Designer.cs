
namespace ProiectTAP
{
    partial class FInscrieriAct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInscrieriAct));
            this.lblIdInscriere = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSpecializare = new System.Windows.Forms.Label();
            this.txtIdInscriere = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.cmbSpecializare = new System.Windows.Forms.ComboBox();
            this.specializariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProiectTAP.DataSet1();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblOp = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nrAniStudiuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaAnualaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaInitialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSpecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anStudiuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscrieriContinutManevraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specializariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSelectie = new System.Windows.Forms.Button();
            this.specializariTableAdapter = new ProiectTAP.DataSet1TableAdapters.SpecializariTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.studentiTableAdapter = new ProiectTAP.DataSet1TableAdapters.StudentiTableAdapter();
            this.lblAnStudiu = new System.Windows.Forms.Label();
            this.txtAnStudiu = new System.Windows.Forms.TextBox();
            this.btnSpecializare = new System.Windows.Forms.Button();
            this.btnAn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscrieriContinutManevraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdInscriere
            // 
            this.lblIdInscriere.AutoSize = true;
            this.lblIdInscriere.BackColor = System.Drawing.Color.Lavender;
            this.lblIdInscriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdInscriere.Location = new System.Drawing.Point(36, 66);
            this.lblIdInscriere.Name = "lblIdInscriere";
            this.lblIdInscriere.Size = new System.Drawing.Size(117, 25);
            this.lblIdInscriere.TabIndex = 8;
            this.lblIdInscriere.Text = "Id Inscriere";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Lavender;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(36, 101);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(57, 25);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "Data";
            // 
            // lblSpecializare
            // 
            this.lblSpecializare.AutoSize = true;
            this.lblSpecializare.BackColor = System.Drawing.Color.Lavender;
            this.lblSpecializare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecializare.Location = new System.Drawing.Point(36, 137);
            this.lblSpecializare.Name = "lblSpecializare";
            this.lblSpecializare.Size = new System.Drawing.Size(136, 25);
            this.lblSpecializare.TabIndex = 10;
            this.lblSpecializare.Text = "Specializare:";
            // 
            // txtIdInscriere
            // 
            this.txtIdInscriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdInscriere.Location = new System.Drawing.Point(188, 60);
            this.txtIdInscriere.Name = "txtIdInscriere";
            this.txtIdInscriere.Size = new System.Drawing.Size(135, 31);
            this.txtIdInscriere.TabIndex = 11;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Lavender;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(587, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 25);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(659, 6);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 31);
            this.txtTotal.TabIndex = 14;
            this.txtTotal.Visible = false;
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmare.Location = new System.Drawing.Point(708, 137);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(110, 35);
            this.btnConfirmare.TabIndex = 15;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // cmbSpecializare
            // 
            this.cmbSpecializare.DataSource = this.specializariBindingSource1;
            this.cmbSpecializare.DisplayMember = "DenumireSpecializare";
            this.cmbSpecializare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpecializare.FormattingEnabled = true;
            this.cmbSpecializare.Location = new System.Drawing.Point(188, 134);
            this.cmbSpecializare.Name = "cmbSpecializare";
            this.cmbSpecializare.Size = new System.Drawing.Size(246, 33);
            this.cmbSpecializare.TabIndex = 16;
            this.cmbSpecializare.ValueMember = "IdSpecializare";
            this.cmbSpecializare.SelectedValueChanged += new System.EventHandler(this.cmbSpecializare_SelectedValueChanged);
            // 
            // specializariBindingSource1
            // 
            this.specializariBindingSource1.DataMember = "Specializari";
            this.specializariBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(188, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 31);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(460, 87);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 25);
            this.lblOp.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrcDataGridViewTextBoxColumn,
            this.denumireStudentDataGridViewTextBoxColumn,
            this.nrAniStudiuDataGridViewTextBoxColumn,
            this.taxaAnualaDataGridViewTextBoxColumn,
            this.taxaInitialaDataGridViewTextBoxColumn,
            this.taxaTotalDataGridViewTextBoxColumn,
            this.idSpecializareDataGridViewTextBoxColumn,
            this.anStudiuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inscrieriContinutManevraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(815, 210);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            // 
            // denumireStudentDataGridViewTextBoxColumn
            // 
            this.denumireStudentDataGridViewTextBoxColumn.DataPropertyName = "DenumireStudent";
            this.denumireStudentDataGridViewTextBoxColumn.DataSource = this.studentiBindingSource;
            this.denumireStudentDataGridViewTextBoxColumn.DisplayMember = "NumeStudent";
            this.denumireStudentDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.denumireStudentDataGridViewTextBoxColumn.HeaderText = "DenumireStudent";
            this.denumireStudentDataGridViewTextBoxColumn.Name = "denumireStudentDataGridViewTextBoxColumn";
            this.denumireStudentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.denumireStudentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.denumireStudentDataGridViewTextBoxColumn.Width = 170;
            // 
            // studentiBindingSource
            // 
            this.studentiBindingSource.DataMember = "Studenti";
            this.studentiBindingSource.DataSource = this.dataSet1;
            // 
            // nrAniStudiuDataGridViewTextBoxColumn
            // 
            this.nrAniStudiuDataGridViewTextBoxColumn.DataPropertyName = "NrAniStudiu";
            this.nrAniStudiuDataGridViewTextBoxColumn.HeaderText = "NrAniStudiu";
            this.nrAniStudiuDataGridViewTextBoxColumn.Name = "nrAniStudiuDataGridViewTextBoxColumn";
            // 
            // taxaAnualaDataGridViewTextBoxColumn
            // 
            this.taxaAnualaDataGridViewTextBoxColumn.DataPropertyName = "TaxaAnuala";
            this.taxaAnualaDataGridViewTextBoxColumn.HeaderText = "TaxaAnuala";
            this.taxaAnualaDataGridViewTextBoxColumn.Name = "taxaAnualaDataGridViewTextBoxColumn";
            // 
            // taxaInitialaDataGridViewTextBoxColumn
            // 
            this.taxaInitialaDataGridViewTextBoxColumn.DataPropertyName = "TaxaInitiala";
            this.taxaInitialaDataGridViewTextBoxColumn.HeaderText = "TaxaInitiala";
            this.taxaInitialaDataGridViewTextBoxColumn.Name = "taxaInitialaDataGridViewTextBoxColumn";
            // 
            // taxaTotalDataGridViewTextBoxColumn
            // 
            this.taxaTotalDataGridViewTextBoxColumn.DataPropertyName = "Taxa Total";
            this.taxaTotalDataGridViewTextBoxColumn.HeaderText = "Taxa Total";
            this.taxaTotalDataGridViewTextBoxColumn.Name = "taxaTotalDataGridViewTextBoxColumn";
            this.taxaTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSpecializareDataGridViewTextBoxColumn
            // 
            this.idSpecializareDataGridViewTextBoxColumn.DataPropertyName = "IdSpecializare";
            this.idSpecializareDataGridViewTextBoxColumn.HeaderText = "IdSpecializare";
            this.idSpecializareDataGridViewTextBoxColumn.Name = "idSpecializareDataGridViewTextBoxColumn";
            this.idSpecializareDataGridViewTextBoxColumn.Visible = false;
            // 
            // anStudiuDataGridViewTextBoxColumn
            // 
            this.anStudiuDataGridViewTextBoxColumn.DataPropertyName = "AnStudiu";
            this.anStudiuDataGridViewTextBoxColumn.HeaderText = "AnStudiu";
            this.anStudiuDataGridViewTextBoxColumn.Name = "anStudiuDataGridViewTextBoxColumn";
            this.anStudiuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inscrieriContinutManevraBindingSource
            // 
            this.inscrieriContinutManevraBindingSource.DataMember = "InscrieriContinutManevra";
            this.inscrieriContinutManevraBindingSource.DataSource = this.dataSet1;
            this.inscrieriContinutManevraBindingSource.CurrentChanged += new System.EventHandler(this.inscrieriContinutManevraBindingSource_CurrentChanged);
            // 
            // specializariBindingSource
            // 
            this.specializariBindingSource.DataMember = "Specializari";
            this.specializariBindingSource.DataSource = this.dataSet1;
            // 
            // btnSelectie
            // 
            this.btnSelectie.Location = new System.Drawing.Point(791, 183);
            this.btnSelectie.Name = "btnSelectie";
            this.btnSelectie.Size = new System.Drawing.Size(29, 23);
            this.btnSelectie.TabIndex = 20;
            this.btnSelectie.Text = "...";
            this.btnSelectie.UseVisualStyleBackColor = true;
            this.btnSelectie.Click += new System.EventHandler(this.btnSelectie_Click);
            // 
            // specializariTableAdapter
            // 
            this.specializariTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Adaugare Sau Modificare Studenti";
            // 
            // studentiTableAdapter
            // 
            this.studentiTableAdapter.ClearBeforeFill = true;
            // 
            // lblAnStudiu
            // 
            this.lblAnStudiu.AutoSize = true;
            this.lblAnStudiu.BackColor = System.Drawing.Color.Lavender;
            this.lblAnStudiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnStudiu.Location = new System.Drawing.Point(36, 183);
            this.lblAnStudiu.Name = "lblAnStudiu";
            this.lblAnStudiu.Size = new System.Drawing.Size(264, 25);
            this.lblAnStudiu.TabIndex = 22;
            this.lblAnStudiu.Text = "Introduceti Anul de Studiu:";
            // 
            // txtAnStudiu
            // 
            this.txtAnStudiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnStudiu.Location = new System.Drawing.Point(315, 179);
            this.txtAnStudiu.Name = "txtAnStudiu";
            this.txtAnStudiu.Size = new System.Drawing.Size(53, 31);
            this.txtAnStudiu.TabIndex = 23;
            // 
            // btnSpecializare
            // 
            this.btnSpecializare.Location = new System.Drawing.Point(440, 134);
            this.btnSpecializare.Name = "btnSpecializare";
            this.btnSpecializare.Size = new System.Drawing.Size(35, 33);
            this.btnSpecializare.TabIndex = 24;
            this.btnSpecializare.Text = "...";
            this.btnSpecializare.UseVisualStyleBackColor = true;
            this.btnSpecializare.Click += new System.EventHandler(this.btnSpecializare_Click);
            // 
            // btnAn
            // 
            this.btnAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAn.Location = new System.Drawing.Point(374, 178);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(128, 35);
            this.btnAn.TabIndex = 25;
            this.btnAn.Text = "Incrementare";
            this.btnAn.UseVisualStyleBackColor = true;
            this.btnAn.Click += new System.EventHandler(this.btnAn_Click);
            // 
            // FInscrieriAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectTAP.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(830, 448);
            this.Controls.Add(this.btnAn);
            this.Controls.Add(this.btnSpecializare);
            this.Controls.Add(this.txtAnStudiu);
            this.Controls.Add(this.lblAnStudiu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectie);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbSpecializare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtIdInscriere);
            this.Controls.Add(this.lblSpecializare);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblIdInscriere);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FInscrieriAct";
            this.Text = "FInscrieriAct";
            this.Load += new System.EventHandler(this.FInscrieriAct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscrieriContinutManevraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdInscriere;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSpecializare;
        private System.Windows.Forms.TextBox txtIdInscriere;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.ComboBox cmbSpecializare;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSelectie;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource specializariBindingSource;
        private DataSet1TableAdapters.SpecializariTableAdapter specializariTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn denumireSpecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource specializariBindingSource1;
        private System.Windows.Forms.BindingSource inscrieriContinutManevraBindingSource;
        private System.Windows.Forms.BindingSource studentiBindingSource;
        private DataSet1TableAdapters.StudentiTableAdapter studentiTableAdapter;
        private System.Windows.Forms.Label lblAnStudiu;
        private System.Windows.Forms.TextBox txtAnStudiu;
        private System.Windows.Forms.Button btnSpecializare;
        private System.Windows.Forms.Button btnAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn denumireStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrAniStudiuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaAnualaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaInitialaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSpecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anStudiuDataGridViewTextBoxColumn;
    }
}