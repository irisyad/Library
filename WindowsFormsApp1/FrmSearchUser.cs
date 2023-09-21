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
    public partial class FrmSearchUser : Form
    {
        public FrmSearchUser()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            //connect to Sql
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source = .;Initial Catalog=LibraryDB;Integrated Security = true";
            cnn = new SqlConnection(connetionString);

            cnn.Open();
            SqlCommand Command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "Select FirstName,LastName,Number,City From Admin ";
            Command = new SqlCommand(sql, cnn);
            dataReader = Command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1)+  " - " + dataReader.GetValue(2) + " - " + dataReader.GetValue(3) + "\n";
            }
            MessageBox.Show(Output);
            dataReader.Close();
            Command.Dispose();
            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connect to Sql
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source = .;Initial Catalog=LibraryDB;Integrated Security = true";
            cnn = new SqlConnection(connetionString);

            cnn.Open();
            SqlCommand Command;
            SqlDataReader dataReader;
            String sql, Output = "";
            String LastName = txtSearch.Text;

            sql = "Select FirstName,LastName,Number,City From Admin Where LastName = '"+ LastName +"' ";
            Command = new SqlCommand(sql, cnn);
            dataReader = Command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + " - " + dataReader.GetValue(3) + "\n";
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

        private void FrmSearchUser_Load(object sender, EventArgs e)
        {

        }
    }
}
