using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace StockMarketBar.Admin
{
    public partial class LoginForm : Form
    {
        private readonly IMongoCollection<BsonDocument> userCollection;

        // Connection link to MongoDB database
        private const string ATLAS_CONNECTION_STRING = "mongodb+srv://eckoghost:changeme@logincluster.k94bu.mongodb.net/?retryWrites=true&w=majority&appName=loginCluster";

        public LoginForm()
        {
            InitializeComponent();

            try
            {
                // Connect to MongoDB Atlas
                var client = new MongoClient(ATLAS_CONNECTION_STRING);
                var database = client.GetDatabase("stockMarketBar");
                userCollection = database.GetCollection<BsonDocument>("users");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to database: {ex.Message}", "Connection Error");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }

            try
            {
                // Look for user in database
                var filter = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Eq("username", txtUsername.Text),
                    Builders<BsonDocument>.Filter.Eq("password", txtPassword.Text)
                );

                var user = userCollection.Find(filter).FirstOrDefault();

                if (user != null)
                {
                    MessageBox.Show("Login successful!");
                    var adminDashboard = new AdminDashboard();
                    this.Hide();
                    adminDashboard.FormClosed += (s, args) => this.Close();
                    adminDashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                    txtPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}", "Error");
            }
        }
    }

    public class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            this.Text = "Admin Dashboard";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Add a label to show we're connected
            var label = new Label
            {
                Text = "Connected to MongoDB Atlas!",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(label);
        }
    }
}