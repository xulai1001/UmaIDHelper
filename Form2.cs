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
    public partial class Form2 : Form
    {
        public int id = 0;
        public UmaDataEntry selection;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                var result = DB.matchUma(textBox1.Text);
                listBox1.DataSource = result;
                listBox1.DisplayMember = "explain";
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                selection = (UmaDataEntry)listBox1.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
