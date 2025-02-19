using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AlexConstruction
{
    public partial class Login: Form
    {
        private string connectionString = " ";
        public Login()
        {
            InitializeComponent();
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(usernametxtfield.Text) || string.IsNullOrWhiteSpace(passtxtfield.Text))
            {
                MessageBox.Show("Please enter both username and password", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = usernametxtfield.Text;
            string password = passtxtfield.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Clients_Load clientsForm = new Clients_Load(); // Ensure the ClientsForm class exists
                                Clients_Load.FormClosed += (s, args) => this.Show(); // Show login form again when ClientsForm closes
                                Clients_Load.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}