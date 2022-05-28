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
   


    public partial class Specializari : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rdr;
        const int DenumireSpecializareIndex = 0;
        const int NrAniStudiuIndex = 1;
        const int TaxaAnualaIndex = 2;
        private Form master;
        private bool selectie = false;
        public void SetMaster(Form caller)
        {
            master = caller;
        }
        public void SetSelectVisible()
        {
            selectie = true;
        }

        public Specializari()
        {
            InitializeComponent();
        }

        private void Specializari_Load(object sender, EventArgs e)
        {
            //this.specializariTableAdapter.Fill(this.dataSet1.Specializari);
            config(true);
            refresh();
     

        }

        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;

            dataGridView1.Columns[DenumireSpecializareIndex].ReadOnly = v;
            dataGridView1.Columns[NrAniStudiuIndex].ReadOnly = v;
            dataGridView1.Columns[TaxaAnualaIndex].ReadOnly = v;


            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
            if (selectie)
                btnSelectie.Visible = v;
            else
                btnSelectie.Visible = !v;
        }


        private void refresh()
        {
            specializariTableAdapter.Fill(dataSet1.Specializari);
        }

        private bool completareCampuri()
        {
            bool raspuns = true;
            foreach (DataRow r in dataSet1.Specializari)
            {
                if (r.RowState == DataRowState.Deleted) continue;

                if (r["DenumireSpecializare"] == DBNull.Value)
                {
                    MessageBox.Show("Completati Denumirea Specializarii la linia cu Id " + r["IdSpecializare"]);
                    raspuns = false;
                }
                if (r["NrAniStudiu"] == DBNull.Value)
                {
                    MessageBox.Show("Completati numarul anilor de studiu la linia cu Id " + r["IdSpecializare"]);
                    raspuns = false;
                }
                if (r["TaxaAnuala"] == DBNull.Value)
                {
                    MessageBox.Show("Completati taxa anuala la linia cu Id " + r["IdSpecializare"]);
                    raspuns = false;
                }
            }
            return raspuns;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (btnRenuntare.Focused)
            {
                dataGridView1.CancelEdit();
                //A3
                config(true);
                refresh();

                return;
            }
            MessageBox.Show("Format eronat");
        }
        private int idDeSpecializare;
        private void cautareIdSpecializare(String variabila)
        {

            cmd.CommandText = "SELECT IdSpecializare FROM Specializari WHERE DenumireSpecializare = '" + variabila + "'";

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            idDeSpecializare = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }


        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";

            con.ConnectionString = specializariTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;
            cautareIdSpecializare(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cmd.CommandText = "Select IdSpecializare From Inscrieri where IdSpecializare=" + idDeSpecializare;
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                MessageBox.Show("Specializare referita in una sau mai multe inscrieri! Nu se poate sterge!");
                con.Close();
                e.Cancel = true ;
                return;

            }
            else
            {
                var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
                if (rezultat == DialogResult.No)
                    e.Cancel = true;
            }
            con.Close();


            
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            config(true);
            refresh();
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
                if (!completareCampuri()) return;
            try
            {
                specializariTableAdapter.Update(dataSet1.Specializari);
                config(true);
                refresh();
            }
            catch (Exception exc)
            {
                string s = exc.Message;

                if (s.IndexOf("duplicate values") > 0)
                    MessageBox.Show("Inregistrare deja existenta !");
                else if (s.IndexOf("cannot be deleted") > 0)
                    MessageBox.Show("Ati sters inregistrari referite in alte tabele !");
            }

        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            config(false);
        }

        private void btnSelectie_Click(object sender, EventArgs e)
        {
            FInscrieriAct f = (FInscrieriAct)master;
            f.refreshLocalitati(specializariBindingSource.Position);
            this.Close();
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            foreach (DataRow r in dataSet1.Specializari)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == r["DenumireSpecializare"])
                    MessageBox.Show("Specializare deja existenta! Nu se poate adauga!");
            }
        }
    }
}
