using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Npgsql;
using System.Windows.Forms;


namespace DBConfigTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntestconnection_Click(object sender, EventArgs e)
        {
            string connString = GenerateConnectionString();
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    MessageBox.Show("Connection successful!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}");
            }
        }

        private void btnGenerateConfig_Click(object sender, EventArgs e)
        {
            string directoryPath = txtPath.Text;
            string fileName = "DBConnectionString.ini";
            string filePath = Path.Combine(directoryPath, fileName);

            try
            {
                if (File.Exists(filePath))
                {
                    // File exists, read and decrypt the existing configuration
                    string encryptedConnString = File.ReadAllText(filePath);
                    string decryptedConnString = Decrypt(encryptedConnString); // Decrypt connection string
                    ParseConnectionString(decryptedConnString);
                    MessageBox.Show("Config file already exists and was read successfully.");
                }
                else
                {
                    // File does not exist, create new file with encrypted connection string
                    string connString = GenerateConnectionString();
                    string encryptedConnString = Encrypt(connString); // Encrypt connection string
                    File.WriteAllText(filePath, encryptedConnString);
                    MessageBox.Show("New configuration file created successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error handling config file: {ex.Message}");
            }
        }

        private void btnReadConfig_Click(object sender, EventArgs e)
        {

            string directoryPath = txtPath.Text;
            string fileName = "DBConnectionString.ini";
            string filePath = Path.Combine(directoryPath, fileName);

            try
            {
                if (File.Exists(filePath))
                {
                    // Read the encrypted connection string from the file
                    string encryptedConnString = File.ReadAllText(filePath);
                    // Decrypt the connection string
                    string decryptedConnString = Decrypt(encryptedConnString);
                    // Parse the decrypted connection string and populate the text boxes
                    ParseConnectionString(decryptedConnString);
                    MessageBox.Show("Configuration file read successfully!");
                }
                else
                {
                    MessageBox.Show("Configuration file does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading config file: {ex.Message}");
            }
        }

        private string GenerateConnectionString()
        {
            return $"Host={txtIP.Text};Port={txtPort.Text};Username={txtUsername.Text};Password={txtPassword.Text};";
        }

        private string Encrypt(string plainText)
        {
            // Implement your encryption logic here
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(plainText));
        }

        private string Decrypt(string encryptedText)
        {
            // Implement your decryption logic here
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(encryptedText));
        }

        private void ParseConnectionString(string connString)
        {
            var builder      = new NpgsqlConnectionStringBuilder(connString);
            txtIP.Text       = builder.Host;
            txtPort.Text     = builder.Port.ToString();
            txtUsername.Text = builder.Username;
            txtPassword.Text = builder.Password;
        }
        
    }
}