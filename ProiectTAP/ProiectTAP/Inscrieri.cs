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
    public partial class Inscrieri : Form
    {
        public Inscrieri()
        {
            InitializeComponent();
        }

        private void Inscrieri_Load(object sender, EventArgs e)
        {

            refreshGrid();
            filtreazaDetaliu();

        }
        private void refreshGrid()
        {
            inscrieri1TableAdapter.Fill(dataSet1.Inscrieri1);
            inscrieriContinut1TableAdapter.Fill(dataSet1.InscrieriContinut1);
        }
        private void filtreazaDetaliu()
        {
            try
            {
                inscrieriContinut1BindingSource.Filter = "IdInscriere=" + txtIdInscriere.Text;
            }
            catch { }
        }



        private void btnAdaugareInregistrare_Click(object sender, EventArgs e)
        {
            FInscrieriAct f = new FInscrieriAct();
            f.completeazaTitlu("INSCRIERE NOUA");
            f.ShowDialog();
            refreshGrid();
        }

        private void btnModificareInregistrare_Click(object sender, EventArgs e)
        {
            FInscrieriAct f = new FInscrieriAct();
            f.completeazaTitlu("MODIFICARE INSCRIERE");
            f.bs1 = inscrieri1BindingSource;
            f.bs2 = inscrieriContinut1BindingSource;
            f.ShowDialog();
            refreshGrid();

        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";

            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = inscrieri1TableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            // Sterg continut comanda
            cmd.CommandText = "Delete From InscrieriContinut Where IdInscriere = " + txtIdInscriere.Text;

            

            con.Open();

            cmd.ExecuteNonQuery();

            cmd.CommandText = "Delete From Inscrieri Where IdInscriere = " + txtIdInscriere.Text;

            cmd.ExecuteNonQuery();

            con.Close();

            refreshGrid();
            filtreazaDetaliu();

        }

        private void inscrieriBindingSource_PositionChanged_1(object sender, EventArgs e)
        {
            filtreazaDetaliu();
        }
    }
}
