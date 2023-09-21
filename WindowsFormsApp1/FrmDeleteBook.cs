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
    public partial class FrmDeleteBook : Form
    {
        public FrmDeleteBook()
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
            String Book = txtSearch.Text;

            sql = "Select NameBook,Pagecount From Books Where NameBook= '" + Book + "' ";
            Command = new SqlCommand(sql, cnn);
            dataReader = Command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + "   ---  whit " + dataReader.GetValue(1) + " page is avalible .";
            }
            MessageBox.Show(Output);
        }

        private void Next_Click(object sender, EventArgs e)
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
            String Book = txtSearch.Text;

            sql = "Delete Books Where NameBook= '" + Book + "' ";
            Command = new SqlCommand(sql, cnn);
            dataReader = Command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + "   ---  whit " + dataReader.GetValue(1) + " page is avalible .";
            }
            MessageBox.Show(Output);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            this.Hide();
            frmMain.ShowDialog();
            this.Close();
        }

        private void FrmDeleteBook_Load(object sender, EventArgs e)
        {

        }
    }
}
