using cspracSaveloader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCSSM
{
    public partial class renameDialog : Form
    {
        public string rename = "";
        public string savePath = "";
        public renameDialog(string renamePath)
        {
            InitializeComponent();
            rename = Path.GetFileName(renamePath);
            savePath = Path.GetDirectoryName(renamePath);
            textBox1.Text = rename;
            this.Text = $"Rename save file";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show($"Are you sure you want to rename the save?\n{rename} to {textBox1.Text}", "Confirm Rename", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                File.Copy(@$"{savePath}\{rename}.dat", @$"{savePath}\{textBox1.Text}.dat", true);
                File.Delete(@$"{savePath}\{rename}.dat");

                Form1 f1 = (Form1)Application.OpenForms["Form1"];
                f1.loadList();

                this.Close();
            }

        }
    }
}
