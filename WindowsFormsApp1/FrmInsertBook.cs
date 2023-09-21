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
    public partial class FrmInsertBook : Form
    {
        public FrmInsertBook()
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
            MessageBox.Show("Connection Open ");
            //save data to Login Tabel
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            int BookID = Convert.ToInt16(txtBookID.Text);
            int PageCount = Convert.ToInt16(txtNum.Text);
            String Name = txtName.Text;
            int AuthorID = Convert.ToInt16(txtAuthorId.Text);
            String Gener = txtGenre.Text;
            string sql = "";
            sql = "Insert into Books (NameBook, Authorld, BookID, Pagecount, Genre) values ('" + Name + "','" + AuthorID + "'," + BookID + "," + PageCount + ",'" + Gener + "')";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //go to main form
            FrmMain frmMain = new FrmMain();
            this.Hide();
            frmMain.ShowDialog();
            this.Close();
        }

        private void FrmInsertBook_Load(object sender, EventArgs e)
        {

        }
    }
}
