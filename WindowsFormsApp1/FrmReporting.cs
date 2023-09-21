using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmReporting : Form
    {
        public FrmReporting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connect to Sql
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source = .;Initial Catalog=LibraryDB;Integrated Security = true";
            cnn = new SqlConnection(connetionString);

            cnn.Open();
            //MessageBox.Show("Connection Open ");

            SqlCommand Command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "Select BookID,NameBook,Authorld,Genre From Books ";
            Command = new SqlCommand(sql, cnn);
            dataReader = Command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + " by "+dataReader.GetValue(2)+" Genre "+ dataReader.GetValue(3)+"\n";
            }
            MessageBox.Show(Output);
            dataReader.Close();
            Command.Dispose();
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            this.Hide();
            frmMain.ShowDialog();
            this.Close();
        }

        private void FrmReporting_Load(object sender, EventArgs e)
        {

        }
    }
}
