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
    public partial class Studenti : Form
    {

        public Studenti()
        {
            InitializeComponent();
        }

        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;

            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;

        }

        private void legareControale(bool v)
        {
            if (v)
            {
                txtNumeStudent.DataBindings.Add("Text", studentiBindingSource, "NumeStudent");
                txtCNP.DataBindings.Add("Text", studentiBindingSource, "CNP");
                txtNrTelefon.DataBindings.Add("Text", studentiBindingSource, "NrTelefon");
                txtSpPoza.DataBindings.Add("Text", studentiBindingSource, "SpImagine");
                pb.DataBindings.Add("ImageLocation", studentiBindingSource, "SpImagine");
                txtIdStudent.DataBindings.Add("Text", studentiBindingSource, "IdStudent");
            }
            else
            {
                txtNumeStudent.DataBindings.Clear();
                txtCNP.DataBindings.Clear();
                txtNrTelefon.DataBindings.Clear();
                txtSpPoza.DataBindings.Clear();
                pb.DataBindings.Clear();
                txtIdStudent.DataBindings.Clear();
            }
        }

        private void protectiePanel(bool v)
        {
            txtNumeStudent.ReadOnly = v;
            txtCNP.ReadOnly = v;
            txtNrTelefon.ReadOnly = v;
            txtSpPoza.ReadOnly = v;
        }

        private void golireCampuri()
        {
            txtNumeStudent.Text = "";
            txtCNP.Text = "";
            txtNrTelefon.Text = "";
            txtSpPoza.Text = "";
            pb.ImageLocation = "";
            txtIdStudent.Text = "";
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Salariu, Localitate
            if (txtNumeStudent.Text == "")
            {
                MessageBox.Show("Completati Numele Studentului !");
                txtNumeStudent.Focus();
                return false;
            }
            if (txtCNP.Text == "")
            {
                MessageBox.Show("Completati CNP-ul !");
                txtCNP.Focus();
                return false;
            }
            if (txtNrTelefon.Text == "")
            {
                MessageBox.Show("Completati Numarul de telefon !");
                txtNrTelefon.Focus();
                return false;
            }

            return true;
        }

        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = studentiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaCampuri = "NumeStudent, CNP, NrTelefon, SpImagine";
            listaValori = "'" + txtNumeStudent.Text + "'" +
                          "," + txtCNP.Text +
                          ",'" + txtNrTelefon.Text + "'" +
                          ",'" + txtSpPoza.Text + "'";

            cmd.CommandText = "Insert into Studenti(" + listaCampuri + ") " +
                              "Select " + listaValori;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void refresh_grid(int p)
        {
            studentiTableAdapter.Fill(dataSet1.Studenti);
            studentiBindingSource.Position = p;
        }

        private void modifica_inregistrare()
        {
            string listaSet;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = studentiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;
        
            listaSet = "NumeStudent = '" + txtNumeStudent.Text + "'," +
                       "CNP = '" + txtCNP.Text + "'," +
                       "NrTelefon = '" + txtNrTelefon.Text + "'," +
                       "SpImagine = '" + txtSpPoza.Text + "'";

            cmd.CommandText = "Update Studenti Set " + listaSet + " Where IdStudent=" + txtIdStudent.Text;

            MessageBox.Show(cmd.CommandText);

            con.Open();
            
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void A1()
        {

            studentiTableAdapter.Fill(dataSet1.Studenti);

            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            txtIdStudent.ReadOnly = true;

            A3();
        }

        private void A2()
        {
            configureazaButoane(false);

            legareControale(false);

            protectiePanel(false);

            lblOp.Text = "ADAUGARE";

            txtNumeStudent.Focus();

            golireCampuri();
        }

        private void A3()
        {
            lblOp.Text = "";

            configureazaButoane(true);

            protectiePanel(true);

            legareControale(true);

        }

        private void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii()) return;

                adauga_inregistrare();

                golireCampuri();

                //Pune cursor pe primul camp
                txtNumeStudent.Focus();
                refresh_grid(studentiBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(studentiBindingSource.Position);
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void A5(TextBox txtB)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            if (lblOp.Text == "") return;
            if (txtB.Text == "") return;
            if (btnRenuntare.Focused) return;

            try { p = Convert.ToDecimal(txtB.Text); }
            catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
            con.ConnectionString = studentiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            if (lblOp.Text == "ADAUGARE")
            {
                cmd.CommandText = "Select NumeStudent From Studenti where CNP=" + txtCNP.Text;
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("CNP deja existent");
                    txtCNP.Focus();
                }
                con.Close();
            }

            else if (lblOp.Text == "MODIFICARE")
            {
                cmd.CommandText = "Select NumeStudent From Studenti where CNP=" + txtCNP.Text +
                                  " and IdStudent  <> " + txtIdStudent.Text;
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("CNP deja existent");
                    txtCNP.Focus();
                }
                con.Close();
            }
        }

        private void A6()
        {
            if (lblOp.Text == "")
                return;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSpPoza.Text = openFileDialog1.FileName;
                pb.ImageLocation = txtSpPoza.Text;
            }
        }

        private void A7()
        {
            configureazaButoane(false);

            legareControale(false);

            protectiePanel(false);

            lblOp.Text = "MODIFICARE";

            txtNumeStudent.Focus();
        }

        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            con.ConnectionString = studentiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Select IdStudent From InscrieriContinut where IdStudent=" + txtIdStudent.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Studentul este deja inscris la o specializare! Nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();




            cmd.CommandText = "Delete From Studenti Where IdStudent = " + txtIdStudent.Text;

            MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            refresh_grid(studentiBindingSource.Position);

        }


        private void Studenti_Load(object sender, EventArgs e)
        {
            txtIdStudent.Clear();
            A1();

        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A8();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }

        private void txtSpPoza_DoubleClick(object sender, EventArgs e)
        {
            A6();
        }

        private void txtCNP_Leave(object sender, EventArgs e)
        {
            A5(txtCNP);
        }

        private void txtNrTelefon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
