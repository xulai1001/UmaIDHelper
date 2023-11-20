using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmaIDHelper
{
    public partial class Form3 : Form
    {
        public CardDataEntry selection;
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                var result = DB.matchCard(textBox1.Text);
                foreach (var card in result)
                    card.breakLevel = (int)numericUpDown1.Value;
                listBox1.DataSource = result;
                listBox1.DisplayMember = "explain";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                selection = (CardDataEntry)listBox1.SelectedItem;
                selection.breakLevel = (int)numericUpDown1.Value;
                DialogResult = DialogResult.OK;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                selection = (CardDataEntry)listBox1.SelectedItem;
                selection.breakLevel = (int)numericUpDown1.Value;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
