using SCSSM;
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
        public string savePath = @"P:\studio pixel games\doukutsu\csprac\save";

        private void Form1_Load(object sender, EventArgs e)
        {

            if (!Directory.Exists("save"))
            {
                Directory.CreateDirectory("save");
            }
            savePath = Path.Combine(Directory.GetCurrentDirectory(), "save");
            gamePath = Directory.GetCurrentDirectory();

            Debug.WriteLine(gamePath);

            loadList();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists($@"{savePath}\{saveList.GetItemText(saveList.SelectedItem)}.dat"))
            {
                File.Copy($@"{savePath}\{saveList.GetItemText(saveList.SelectedItem)}.dat", @$"{gamePath}\Profile.dat", true);
            }
            else
            {
                MessageBox.Show($"The selected save doesn't exist", "Err", MessageBoxButtons.OK);
                loadList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nameBox.Text.Length > 0)
            {
                if (File.Exists(@$"{gamePath}\Profile.dat"))
                {
                    var confirmResult = MessageBox.Show($"Are you sure you want to save a new save with the name?\n{nameBox.Text}", "Confirm Save", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        File.Copy(@$"{gamePath}\Profile.dat", @$"{savePath}\{nameBox.Text}.dat", true);
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
            saveList.Items.Clear();
            string[] files = Directory.GetFiles(savePath);
            Array.Sort(files);
            if (files.Length > 0)
            {
                foreach (string file in files)
                {
                    if (Path.GetExtension(file) == ".dat")
                    {
                        saveList.Items.Add(Path.GetFileNameWithoutExtension(file));
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (File.Exists($@"{savePath}\{saveList.GetItemText(saveList.SelectedItem)}.dat"))
            {
                var confirmResult = MessageBox.Show($"Are you sure you want to delete the save?\n{saveList.GetItemText(saveList.SelectedItem)}", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    File.Delete($@"{savePath}\{saveList.GetItemText(saveList.SelectedItem)}.dat");
                }
            }
            else
            {
                MessageBox.Show($"Selected save doesn't exist", "Err", MessageBoxButtons.OK);
            }

            loadList();
        }

        private void savelistMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (saveList.SelectedItems.Count < 1)
            {
                saveList.ContextMenuStrip.Items[0].Enabled = false;
                saveList.ContextMenuStrip.Items[1].Enabled = false;
            }
            else
            {
                saveList.ContextMenuStrip.Items[0].Enabled = true;
                saveList.ContextMenuStrip.Items[1].Enabled = true;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(@$"{savePath}\{saveList.GetItemText(saveList.SelectedItem)}.dat"))
            {
                var confirmResult = MessageBox.Show($"Are you sure you want to delete the save?\n{saveList.GetItemText(saveList.SelectedItem)}", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    File.Delete(@$"{savePath}\{saveList.GetItemText(saveList.SelectedItem)}.dat");
                }
            }
            else
            {
                MessageBox.Show($"Selected save doesn't exist", "Err", MessageBoxButtons.OK);
            }

            loadList();
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renameDialog renameDialog = new renameDialog(@$"{savePath}\{saveList.GetItemText(saveList.SelectedItem)}");
            renameDialog.ShowDialog();
        }

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadList();
        }
    }
}