using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Password : Form
    {
        public string PasswordUpdate { get; private set; }
        public string FilePath { get; private set; }
        public Password()
        {
            InitializeComponent();
        }

        private void UpdateForm()
        {
            this.PasswordUpdate = passwordTextBox.Text;
            this.FilePath = filePathTextBox.Text;

            bool isValidPath = false;
            try
            {
                Uri uri = new Uri(FilePath);
                if (uri.LocalPath == FilePath
                    && uri.LocalPath.IndexOfAny(Path.GetInvalidPathChars()) < 0)
                {
                    isValidPath = true;
                }
            }
            catch (Exception) { }
            finally
            {
                this.createButton.Enabled = isValidPath;
            }
        }

        private void FormNew_Load(object sender, EventArgs e)
        {
            filePathTextBox.Text = BookManager.DefaultFilePath;
            UpdateForm();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(FilePath);
            openFileDialog1.FileName = Path.GetFileName(FilePath);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePathTextBox.Text = openFileDialog1.FileName;
            }
            UpdateForm();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void filePathTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
