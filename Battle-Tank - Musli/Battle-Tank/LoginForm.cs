using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Battle_Tank
{
    public partial class LoginForm : Form
    {
        SqlConnection connection;
        string connectionString;
        public LoginForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Battle_Tank.Properties.Settings.UsersDatabaseConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT MAX(Points) FROM Users";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand SqlQuery = new SqlCommand(query, connection))
            {
                connection.Open();
                int result = (int)SqlQuery.ExecuteScalar();
                lblBest.Text = result.ToString();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Users VALUES(@UserName, @UserPassword, 0)";
            string query1 = "SELECT COUNT(*) FROM [Users] WHERE ([UserName] = @user)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command1 = new SqlCommand(query1, connection))
            {
                connection.Open();
                command1.Parameters.AddWithValue("@user", tbUsername.Text);

                if ((int)command1.ExecuteScalar() > 0)
                {
                    MessageBox.Show("User " + tbUsername.Text + " exists. Try another username");
                    tbUsername.Focus();
                    return;
                }
            }

            //int userExists = (int)checkUser.ExecuteScalar();

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                if (tbUsername.Text == "" || tbPassword.Text == "")
                {
                    MessageBox.Show("Username or password cannot be empty");
                    tbUsername.Focus();
                    return;
                }
                command.Parameters.AddWithValue("@UserName", tbUsername.Text);
                command.Parameters.AddWithValue("@UserPassword", tbPassword.Text);
                //   command.Parameters.AddWithValue("@Points", 0);

                command.ExecuteNonQuery();
            }

            MessageBox.Show("User Registered Succesfully");
            DialogResult = DialogResult.OK;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand checkUser = new SqlCommand("SELECT COUNT(*) FROM[Users] WHERE ([UserName] = @userName) " +
                "AND ([UserPassword] = @userPassword)", connection);
            checkUser.Parameters.AddWithValue("@userName", tbUsername.Text);
            checkUser.Parameters.AddWithValue("@userPassword", tbPassword.Text);
            int userExists = (int)checkUser.ExecuteScalar();

            if(userExists > 0)
            {
                MessageBox.Show("Log in succesfully");
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
            connection.Close();
        }

        private void lblBest_Click(object sender, EventArgs e)
        {

        }
    }
}
