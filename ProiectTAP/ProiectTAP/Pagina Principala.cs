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
    public partial class PaginaPrincipala : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;

        public PaginaPrincipala()
        {
            InitializeComponent();
        }

        private void A1(Boolean v)
        {
            menuStrip1.Visible = !v;
            lblTitlu.Visible = !v;
            lblAutor.Visible = !v;
            lblParola.Visible = v;
            txtParola.Visible = v;
            lblUtilizator.Visible = v;
            txtUtilizator.Visible = v;
            if (v) btnStart.Text = "Log In";
            else btnStart.Text = "Log Out";
        }

        private Boolean Logare_OK()
        {
            if (txtUtilizator.Text == "")
            {
                MessageBox.Show("Completati utilizator !");
                txtUtilizator.Focus();
                return false;
            }
            if (txtParola.Text == "")
            {
                MessageBox.Show("Completati parola !");
                txtParola.Focus();
                return false;
            }
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                                       "Data Source=C:\\Users\\sorin\\Desktop\\proiect TAP\\Proiect\\proiect.mdb;"+
                                       "Jet OLEDB:Database Password=sorelul";

            cmd.Connection = con;
            cmd.CommandText = "Select IdUtilizator,Parola from Utilizatori " +
                              "where Nume='" + txtUtilizator.Text + "'";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (txtParola.Text != rdr.GetString(1))
                {
                    MessageBox.Show("Parola eronata");
                    txtParola.Focus();
                    con.Close();
                    return false;
                }
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Utilizator eronat");
                txtUtilizator.Focus();
                con.Close();
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            A1(true);
        }

        private void studentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studenti f = new Studenti();
            f.ShowDialog();
        }

        private void specializariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Specializari f = new Specializari();
            f.ShowDialog();
        }

        private void inscrieriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inscrieri f = new Inscrieri();
            f.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Log In")
            {
                if (Logare_OK()) A1(false);
            }
            else A1(true);
        }

        private void txtParola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnStart_Click(this, new EventArgs());
            }
        }
    }
}
