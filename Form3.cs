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
                DB.updateCardHistory(selection.cardIdWithBreak);
                DialogResult = DialogResult.OK;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                selection = (CardDataEntry)listBox1.SelectedItem;
                selection.breakLevel = (int)numericUpDown1.Value;
                DB.updateCardHistory(selection.cardIdWithBreak);
                DialogResult = DialogResult.OK;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var result = DB.cardHistory.Select(x => DB.getCard(x)).ToList();
            listBox2.DataSource = result;
            listBox2.DisplayMember = "explainWithBreak";
            textBox1.Text = "";
            numericUpDown1.BackColor = Color.White;
            numericUpDown1.Value = 4;
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                selection = (CardDataEntry)listBox2.SelectedItem;
                DB.updateCardHistory(selection.cardIdWithBreak);
                DialogResult = DialogResult.OK;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection = (CardDataEntry)listBox2.SelectedItem;
            textBox1.Text = selection.cardName;
            numericUpDown1.Value = selection.breakLevel;
            numericUpDown1.BackColor = Color.Yellow;
        }
    }
}
