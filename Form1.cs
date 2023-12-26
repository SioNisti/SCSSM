using System.Diagnostics;

namespace cspracSaveloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string gamePath = @"P:\studio pixel games\doukutsu\csprac";
        public string savePath = @"P:\studio pixel games\doukutsu\csprac\save";/*
        public string gamePath = @"";
        public string savePath = @"";*/

        private void Form1_Load(object sender, EventArgs e)
        {

            if (!Directory.Exists("save"))
            {
                Directory.CreateDirectory("save");
            }
            savePath = Path.Combine(Directory.GetCurrentDirectory(), "save");
            gamePath = Directory.GetCurrentDirectory();

            loadList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists($"{savePath}/{listBox1.GetItemText(listBox1.SelectedItem)}.dat"))
            {
                File.Copy($"{savePath}/{listBox1.GetItemText(listBox1.SelectedItem)}.dat", $"{gamePath}/Profile.dat", true);
            }
            else
            {
                MessageBox.Show($"The selected save doesn't exist", "Err", MessageBoxButtons.OK);
                loadList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (File.Exists($"{gamePath}/Profile.dat"))
                {
                    var confirmResult = MessageBox.Show($"Are you sure you want to save a new save with the name?\n{textBox1.Text}", "Confirm Save", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        File.Copy($"{gamePath}/Profile.dat", $"{savePath}/{textBox1.Text}.dat", true);
                        loadList();
                    }
                }
                else
                {
                    MessageBox.Show($"There is no currently saved game in the game directory", "Err", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show($"Please give the save a name", "Err", MessageBoxButtons.OK);
            }
        }

        public void loadList()
        {
            listBox1.Items.Clear();
            string[] files = Directory.GetFiles(savePath);
            Array.Sort(files);
            if (files.Length > 0)
            {
                foreach (string file in files)
                {
                    if (Path.GetExtension(file) == ".dat")
                    {
                        listBox1.Items.Add(Path.GetFileNameWithoutExtension(file));
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists($"{savePath}/{listBox1.GetItemText(listBox1.SelectedItem)}.dat"))
            {
                var confirmResult = MessageBox.Show($"Are you sure you want to delete the save?\n{listBox1.GetItemText(listBox1.SelectedItem)}", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    File.Delete($"{savePath}/{listBox1.GetItemText(listBox1.SelectedItem)}.dat");
                }
            }
            else
            {
                MessageBox.Show($"Selected save doesn't exist", "Err", MessageBoxButtons.OK);
            }

            loadList();
        }
    }
}