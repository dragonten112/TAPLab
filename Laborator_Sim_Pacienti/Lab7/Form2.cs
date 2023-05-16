using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.testDateTableAdapter.Fill(this.dataSet1.TestDate);
        }
        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            string listaCampuri;
            string listaValori;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = testDateTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaCampuri = "DataAngajarii";
            listaValori = "#" + dtpDataAngajarii.Value.Month + "/" +
                                dtpDataAngajarii.Value.Day + "/" +
                                dtpDataAngajarii.Value.Year + "#";

            cmd.CommandText = "Insert into TestDate(" + listaCampuri + ") " + "Select " + listaValori;

            MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            //Refresh grid
            testDateTableAdapter.Fill(dataSet1.TestDate);
        }
    }
}

