namespace UmaIDHelper
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "查询支援卡";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(98, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 28);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 206);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "查询结果（双击添加）";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(16, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(460, 172);
            listBox1.TabIndex = 0;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(259, 23);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 3;
            label2.Text = "突破等级";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(339, 20);
            numericUpDown1.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(58, 28);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(416, 21);
            button1.Name = "button1";
            button1.Size = new Size(92, 27);
            button1.TabIndex = 5;
            button1.Text = "添加";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 271);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            Text = "查询支援卡";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button button1;
    }
}