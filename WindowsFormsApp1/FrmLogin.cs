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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //go to main form
            FrmRegister frmRegister = new FrmRegister();
            this.Hide();
            frmRegister.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //connect to Sql
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source = .;Initial Catalog=LibraryDB;Integrated Security = true";
            cnn = new SqlConnection(connetionString);

            cnn.Open();
            MessageBox.Show("Hi User ");
            //save data to Login Tabel
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            int Password = Convert.ToInt16(txtPassword.Text);
            String UserName = txtUserName.Text;
            string sql = "";
            sql = "Insert into Login (UserName, Password) values ('" + UserName + "'," + Password + ")";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();


            //go to main form
            FrmMain frmMain = new FrmMain();
            this.Hide();
            frmMain.ShowDialog();
            this.Close();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
