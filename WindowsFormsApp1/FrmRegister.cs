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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //connect to Sql
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source = .;Initial Catalog=LibraryDB;Integrated Security = true";
            cnn = new SqlConnection(connetionString);

            cnn.Open();
            MessageBox.Show("Done  ");


            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            int Password = Convert.ToInt16(txtPassword.Text);
            String Name = txtName.Text;
            String Family = txtFamily.Text;
            String UserName = txtUserName.Text;
            string sql = "";
            sql = "Insert into Register (Name, Family, UserName, Password) values ('" + Name + "','" + Family + "','" + UserName + "'," + Password + ")";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();



            //User user = new User(txtUserName.Text, txtPassword.Text, txtName.Text, txtFamily.Text, Convert.ToInt16(txtID.Text));
            //MessageBox.Show(user.toString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
