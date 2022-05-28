using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectTAP
{
    public partial class FInscrieriAct : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int idCda;
        private int idStudentel;
        private int idDeSpecializare;
        public BindingSource bs1;//inscrieri1BindingSource;
        public BindingSource bs2;//inscrieriContinut1BindingSource;



        public FInscrieriAct()
        {
            InitializeComponent();
        }

        private void FInscrieriAct_Load(object sender, EventArgs e)
        {
            A1();

        }

        public void refreshLocalitati(int pozitie)
        {
            studentiTableAdapter.Fill(dataSet1.Studenti);
            cmbSpecializare.SelectedIndex = pozitie;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void A1()
        {
            specializariTableAdapter.Fill(dataSet1.Specializari);
            studentiTableAdapter.Fill(dataSet1.Studenti);

            // Protectie la modificare
            txtIdInscriere.ReadOnly = true;
            txtTotal.ReadOnly = true;
            nrcDataGridViewTextBoxColumn.ReadOnly = true;
            taxaAnualaDataGridViewTextBoxColumn.ReadOnly = true;
            idSpecializareDataGridViewTextBoxColumn.ReadOnly = true;

            if (lblOp.Text == "MODIFICARE INSCRIERE") completeazaComanda();
            else if (lblOp.Text == "INSCRIERE NOUA") cmbSpecializare.SelectedIndex = -1;

        }//umplere campuri si protectii

        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (lblOp.Text == "MODIFICARE INSCRIERE")
            {
                modificaInregistrare();
                stergeContinut();
                adaugaInregistrariComenziContinut();
                this.Close();
            }
            else if (lblOp.Text == "INSCRIERE NOUA")
            {
                generez_nr_cda();
                adaugaInregistrareComenzi();
                cautaInregistrare();
                adaugaInregistrariComenziContinut();
                golireCampuri();
            }

        }//verifica daca-i modificare sau add

        private void A3()
        {
            DataRowView current = (DataRowView)inscrieriContinutManevraBindingSource.Current;
            try
            {
                if (current != null)
                    current["Nrc"] = inscrieriContinutManevraBindingSource.Position + 1;
            }
            catch { }
            
            
        }//incrementare nrc

        private void A4()
        {
            try
            {
                if (dataGridView1.CurrentCell != null)
                {
                    if (dataGridView1.CurrentCell.ColumnIndex == 1)
                    {
                        schimba();
                    }

                    if (dataGridView1.CurrentCell.ColumnIndex == 6)
                    {
                        inscrieriContinutManevraBindingSource.EndEdit();
                        calcTotal();
                    }
                    if (dataGridView1.CurrentCell.ColumnIndex == 5)
                    {
                        inscrieriContinutManevraBindingSource.EndEdit();
                        calcTotal();
                    }
                    if (dataGridView1.CurrentCell.ColumnIndex ==4)
                    {
                        inscrieriContinutManevraBindingSource.EndEdit();
                        calcTotal();
                    }
                    if ((int)dataGridView1.CurrentRow.Cells[4].Value > (int)dataGridView1.CurrentRow.Cells[3].Value)
                    {
                        MessageBox.Show("Taxa initiala nu poate fi mai mare decat taxa anuala!");
                    }
                }
                
                
            }
            catch { }

           
        }//calculeaza total

        private void A5(DataGridViewRowCancelEventArgs e)
        {

            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (rezultat == DialogResult.No) e.Cancel = true;
        }//stergere

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            A4();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A5(e);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcTotal();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void calcTotal()
        { // Calcul total valori
            decimal t = 0;
            foreach (DataRow r in dataSet1.InscrieriContinutManevra)
            {
                if (r["Taxa Total"] != DBNull.Value)
                    t += (decimal)r["Taxa Total"];
            }

            txtTotal.Text = Convert.ToString(t);
        }

        private void generez_nr_cda()
        {
            con.ConnectionString = specializariTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;
            cmd.CommandText = "SELECT Max(Inscrieri.IdInscriere) AS NrMax FROM Inscrieri";

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            //if(!rdr.HasRows)
            //{
                txtIdInscriere.Text = Convert.ToString(rdr.GetInt32(0) + 1);
            //}
            // else
            //{
            //    txtIdInscriere.Text = "1";
            //}

           // txtIdInscriere.Text = Convert.ToString(rdr.GetInt32(0) + 1);
            rdr.Close();
            con.Close();
        }

        private bool validareCampuriObligatorii()
        {
            
            if (cmbSpecializare.Text == "")
            {
                MessageBox.Show("Completati Specializarea !");
                cmbSpecializare.Focus();
                return false;
            }

            if (inscrieriContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut Inscriere !");
                dataGridView1.Focus();
                return false;
            }
            return true;
        }

        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }

        private void completeazaComanda()
        {
            DataRowView current = (DataRowView)bs1.Current;
            DataRowView current2 = (DataRowView)bs2.Current;
            idCda = (int)current["IdInscriere"];
            txtIdInscriere.Text = Convert.ToString(current["IdInscriere"]);

            cmbSpecializare.Text = current["DenumireSpecializare"].ToString();
            txtTotal.Text = current2["Total Ramas"].ToString();


            dateTimePicker1.Value = Convert.ToDateTime(current["DataInscrierii"]);

            bs2.MoveFirst();

            dataSet1.InscrieriContinutManevra.Clear();


            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;
                current2 = (DataRowView)bs1.Current;

                DataSet1.InscrieriContinutManevraRow r = dataSet1.InscrieriContinutManevra.NewInscrieriContinutManevraRow();
                r.Nrc = Convert.ToInt16(current["Nrc"]);
                r.DenumireStudent = Convert.ToString(current["NumeStudent"]);
                r.TaxaAnuala = Convert.ToInt32(current["TaxaAnuala"]);
                r.NrAniStudiu = (short)Convert.ToDecimal(current2["NrAniStudiu"]);
                r.IdSpecializare = Convert.ToInt32(current["IdSpecializare"]);
                r.Taxa_Total = Convert.ToDecimal(current["Total Ramas"]);
                r.TaxaInitiala = Convert.ToDecimal(current["TaxaInitiala"]);
                r.AnStudiu = Convert.ToInt16(current2["AnStudiu"]);
                dataSet1.InscrieriContinutManevra.Rows.Add(r);
                bs2.MoveNext();
            }
        }

        private void inscrieriContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
        }

        private void adaugaInregistrareComenzi()// DE MODIFICAT
        {
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;

            listaCampuri = "IdInscriere, DataInscrierii, IdSpecializare,TaxaAnuala,AnStudiu";
            con.Open();

            listaValori = txtIdInscriere.Text +
                          ",#" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#,"
                               + dataGridView1.Rows[0].Cells[6].Value + "," 
                               + dataGridView1.Rows[0].Cells[3].Value + "," //val 3
                               + txtAnStudiu.Text
                             ;

            cmd.CommandText = "Insert into Inscrieri(" + listaCampuri + ") " +
                            "Select " + listaValori;

            cmd.ExecuteNonQuery();
            con.Close();
        }


        private void cautaInregistrare()
        {
            cmd.CommandText = "SELECT IdInscriere From Inscrieri Where IdInscriere = " + txtIdInscriere.Text;

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            idCda = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }

        private void adaugaInregistrariComenziContinut()
        {
            string listaCampuri = "IdInscriere, Nrc, IdStudent, TaxaInitiala";
            string listaValori;

            con.Open();
            foreach (DataRow r in dataSet1.InscrieriContinutManevra)
            {
                
                cautareIdStudent(r["DenumireStudent"].ToString());
                if (con != null && con.State == ConnectionState.Closed)
                    con.Open();

                listaValori = txtIdInscriere.Text + ","
                               + r["Nrc"] + "," 
                               + idStudentel + "," 
                               + r["TaxaInitiala"]
                             ;
                //dataGridView1.CurrentRow.Cells[3].Value
                cmd.CommandText = "Insert into InscrieriContinut(" + listaCampuri + ") " +
                            "Select " + listaValori;

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        private void cautareIdStudent(String variabila)
        {
            cmd.CommandText = "SELECT IdStudent FROM Studenti WHERE NumeStudent = '" + variabila+"'";

            if (con != null && con.State == ConnectionState.Closed)
                con.Open();

            rdr = cmd.ExecuteReader();
            rdr.Read();

            idStudentel=rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }
        private void cautareIdSpecializare(String variabila)
        {
            con.ConnectionString = specializariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "SELECT IdSpecializare FROM Specializari WHERE DenumireSpecializare = '" + variabila + "'";
            if (con != null && con.State == ConnectionState.Closed)
                con.Open();

            rdr = cmd.ExecuteReader();
            rdr.Read();

            idDeSpecializare = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }

        private void golireCampuri()
        {
            txtIdInscriere.Text = "";
            cmbSpecializare.SelectedIndex = -1;
            txtTotal.Text = "";
            dataSet1.InscrieriContinutManevra.Clear();
        }

        private void modificaInregistrare()
        {
            DateTime d1 = dateTimePicker1.Value;
            cautareIdSpecializare(cmbSpecializare.Text.ToString());
            con.ConnectionString = specializariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            var anStudiu = txtAnStudiu.Text;
            if (anStudiu == "")
            {
                anStudiu =Convert.ToString(dataGridView1.Rows[0].Cells[6].Value);
            }
                
            string clauzaWhere = " Where IdInscriere = " + idCda;

            string clauzaSet = "Set DataInscrierii = #" + d1.Month + "/"
                               + d1.Day + "/"
                               + d1.Year + "#,"
                               + "IdSpecializare = " + idDeSpecializare+","
                               + "AnStudiu = "+anStudiu;

            cmd.CommandText = "Update Inscrieri " + clauzaSet + clauzaWhere;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void stergeContinut()
        {
            cmd.CommandText = "Delete from InscrieriContinut Where IdInscriere = " + idCda;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void btnSelectie_Click(object sender, EventArgs e)
        {
            Studenti f = new Studenti();
            f.ShowDialog();
        }

        private void cmbSpecializare_SelectedValueChanged(object sender, EventArgs e)
        {
            schimba(); 
        }

        private void schimba()
        {
            if(dataGridView1.CurrentCell != null)
            {

                con.Close();
                con.ConnectionString = specializariTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Specializari WHERE DenumireSpecializare = '"+cmbSpecializare.Text+"'";
   
                
                con.Open();
                rdr = cmd.ExecuteReader();
                var idSpec =-1;
                var TaxaAnuala=-1;
                var NrAniStudiu=-1;
                if (rdr.Read())
                {
                     idSpec = rdr.GetInt32(0);
                     TaxaAnuala = rdr.GetInt32(3);
                     NrAniStudiu = rdr.GetInt32(2);
                }



                rdr.Close();
                con.Close();

                foreach (DataRow r in dataSet1.InscrieriContinutManevra)
                {
                    r["TaxaAnuala"] = TaxaAnuala;
                    r["NrAniStudiu"] = NrAniStudiu;
                    r["IdSpecializare"] = idSpec;
                }


            }
            
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           // if(cmbSpecializare.Text!= "")
           // schimba();
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (cmbSpecializare.Text != "")
                schimba();
        }

        private void btnSpecializare_Click(object sender, EventArgs e)
        {
            Specializari f = new Specializari();
            f.SetMaster(this);
            f.SetSelectVisible();
            f.ShowDialog();
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            foreach (DataRow r in dataSet1.InscrieriContinutManevra)
            {
                r["AnStudiu"] = Convert.ToString(txtAnStudiu.Text);
            }
        }
    }
}
