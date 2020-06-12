using Scanner.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scanner
{
    public partial class ScannerMain : Form
    {
        public ScannerMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Welcome Message to viewers
            MessageBox.Show("Welcome to the scanner App!", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You have connected successfully to {Settings.Default.ConnectionString}", "Database Connection ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
