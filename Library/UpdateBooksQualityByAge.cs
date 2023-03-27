using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class UpdateBooksQualityByAge : Form
    {
        public string Quality { get; private set; }
        private readonly List<string> qualityList = new List<string>();
        public List<string> QualityList
        {
            get
            {
                return qualityList;
            }
        }

        public int Age { get; private set; }

        public UpdateBooksQualityByAge()
        {
            InitializeComponent();
        }
        private void UpdateBooksQualityByYear_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(qualityList.ToArray());
            numericUpDown1.Minimum = InputValidator.AgeMinimum;
            numericUpDown1.Maximum = InputValidator.AgeMaximum;
            numericUpDown1.Value = InputValidator.AgeDefault;
            UpdateForm();
        }

        private void UpdateForm()
        {
            Age = Convert.ToInt32(numericUpDown1.Value);
            Quality = comboBox1.Text;
            button1.Enabled = InputValidator.validateAge(Age) &&
                InputValidator.validateQuality(Quality);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}

