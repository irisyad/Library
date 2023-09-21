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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            String sql,Output = "";
            String Book = txtSearch.Text;

            sql = "Select NameBook,Pagecount From Books Where NameBook= '" + Book + "' ";
            Command = new SqlCommand(sql,cnn);
            dataReader = Command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + "   ---  whit " + dataReader.GetValue(1) + " page is avalible .";
            }
            MessageBox.Show(Output);
        }

        private void button2_Click(object sender, EventArgs e)
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
            String Genre = txtSearch.Text;

            sql = "Select NameBook From Books Where Genre= '" + Genre + "' ";
            Command = new SqlCommand(sql, cnn);
            dataReader = Command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) +" is avalible ."+"\n";
            }
            MessageBox.Show(Output);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //go to main form
            FrmInsertBook frmInsertBook = new FrmInsertBook();
            this.Hide();
            frmInsertBook.ShowDialog();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //go to Delete form
            FrmDeleteBook frmDeleteBook = new FrmDeleteBook();
            this.Hide();
            frmDeleteBook.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //go to Update form
            FrmUpdate frmUpdate = new FrmUpdate();
            this.Hide();
            frmUpdate.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmReporting frmReporting = new FrmReporting();
            this.Hide();
            frmReporting.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmReportLogin frmReportLogin = new FrmReportLogin();
            this.Hide();
            frmReportLogin.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmReportAuthor frmReportAuthor = new FrmReportAuthor();
            this.Hide();
            frmReportAuthor.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmSearchUser frmSearchUser = new FrmSearchUser();
            this.Hide();
            frmSearchUser.ShowDialog();
            this.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
