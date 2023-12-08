using Newtonsoft.Json;
using System.Collections;
using System.ComponentModel;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.CodeDom;

namespace UmaIDHelper
{
    public partial class Form1 : Form
    {
        UmaDataEntry selectedUma;
        BindingList<CardDataEntry> selectedCards;

        public Form1()
        {
            InitializeComponent();
        }

        private void saveConfig(TestAiScoreConfig conf)
        {
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented
            };
            try
            {
                File.WriteAllText("testConfig.json", JsonConvert.SerializeObject(conf, settings), Encoding.UTF8);
            }
            catch (Exception e)
            {
                MessageBox.Show("����testConfig.json����\n" + e.Message, "�������ó���");
            }
        }

        private void runTest()
        {
            string binaryFile = "testAiScore.exe";
            if (radioButton2.Checked)
                binaryFile = "testAiScoreNN.exe";
            if (!File.Exists(binaryFile))
            {
                MessageBox.Show($"δ�ҵ��⿨����({binaryFile})�����AI����ͬһĿ¼��", "����");
            }
            else
            {
                button5.Enabled = false;
                Process proc = Process.Start(binaryFile);
                proc.EnableRaisingEvents = true;
                proc.Exited += (sender, e) => button5.Invoke(new MethodInvoker(delegate
                {
                    button5.Enabled = true;
                }));
            }
        }

        private int calcInheritAttribute()
        {
            int total = 0;
            int[] remainBlues = { 0, 5, 12 };

            total += (int)numericUpDown1.Value / 3 * 21 + remainBlues[(int)numericUpDown1.Value % 3];
            total += (int)numericUpDown2.Value / 3 * 21 + remainBlues[(int)numericUpDown2.Value % 3];
            total += (int)numericUpDown3.Value / 3 * 21 + remainBlues[(int)numericUpDown3.Value % 3];
            total += (int)numericUpDown4.Value / 3 * 21 + remainBlues[(int)numericUpDown4.Value % 3];
            total += (int)numericUpDown5.Value / 3 * 21 + remainBlues[(int)numericUpDown5.Value % 3];

            total += (int)numericUpDown6.Value + (int)numericUpDown7.Value + (int)numericUpDown8.Value
                   + (int)numericUpDown9.Value + (int)numericUpDown10.Value;

            return total;
        }

        private void updateInherit()
        {
            lblInherit.Text = $"{calcInheritAttribute()} + {numericUpDown11.Value} Pt";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DB.load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("����/֧Ԯ����������������鵱ǰĿ¼���Ƿ���db�ļ��С�������Ϣ��\n" + ex.Message, "�������ݳ���");
                Application.Exit();
            }
            selectedCards = new BindingList<CardDataEntry>();
            listBox1.DataSource = selectedCards;
            listBox1.DisplayMember = "explainWithBreak";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            if (form.ShowDialog() == DialogResult.OK)
            {
                selectedUma = form.selection;
                textBox1.Text = selectedUma.explain;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedCards.Count >= 6)
            {
                button2.Text = "�Ѿ�ѡ��";
            }
            else
            {
                Form3 form = new Form3();
                if (form.ShowDialog() == DialogResult.OK && !selectedCards.Contains(form.selection))
                {
                    selectedCards.Add(form.selection);
                }
                if (selectedCards.Count >= 6)
                {
                    button2.Text = "�Ѿ�ѡ��";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedCards.Clear();
            if (selectedCards.Count < 6)
            {
                button2.Text = "���";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedCards.Count > 0 && listBox1.SelectedIndex >= 0)
                selectedCards.RemoveAt(listBox1.SelectedIndex);
            if (selectedCards.Count < 6)
            {
                button2.Text = "���";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // check 1
            if (selectedUma == null)
            {
                MessageBox.Show("δѡ������");
                return;
            }
            if (selectedCards.Count != 6)
            {
                MessageBox.Show("֧Ԯ��δѡ�����");
                return;
            }

            // make AIConfig
            TestAiScoreConfig conf = new TestAiScoreConfig
            {
                umaId = selectedUma.gameId,
                cards = selectedCards.Select(x => x.cardIdWithBreak).ToList(),
                zhongmaBlue = new List<int>
                {
                    (int)numericUpDown1.Value,
                    (int)numericUpDown2.Value,
                    (int)numericUpDown3.Value,
                    (int)numericUpDown4.Value,
                    (int)numericUpDown5.Value
                },
                zhongmaBonus = new List<int>
                {
                    (int)numericUpDown6.Value,
                    (int)numericUpDown7.Value,
                    (int)numericUpDown8.Value,
                    (int)numericUpDown9.Value,
                    (int)numericUpDown10.Value,
                    (int)numericUpDown11.Value
                },
                allowedDebuffs = new List<bool>
                {
                    checkBox1.Checked,
                    checkBox2.Checked,
                    checkBox3.Checked,
                    checkBox4.Checked,
                    checkBox5.Checked,
                    checkBox6.Checked,
                    checkBox7.Checked,
                    checkBox8.Checked,
                    false
                },
                totalGames = Int32.Parse(textBox2.Text),
                eventStrength = (int)numericUpDown12.Value
            };
            // MessageBox.Show(JsonConvert.SerializeObject(conf));
            // check 2
            int zhongmaCount = conf.zhongmaBlue.Sum();
            if (zhongmaCount > 18)
                MessageBox.Show("����������>18", "����");
            conf.cardHistory = DB.cardHistory;
            saveConfig(conf);
            runTest();
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            new AboutWindow().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateInherit();
        }
    }
}