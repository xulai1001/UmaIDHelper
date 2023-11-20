namespace UmaIDHelper
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            cardDataEntryBindingSource = new BindingSource(components);
            umaDataEntryBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cardDataEntryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)umaDataEntryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 0;
            label1.Text = "查询马娘";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(94, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 28);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 291);
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
            listBox1.Size = new Size(356, 256);
            listBox1.TabIndex = 0;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // cardDataEntryBindingSource
            // 
            cardDataEntryBindingSource.DataSource = typeof(CardDataEntry);
            // 
            // umaDataEntryBindingSource
            // 
            umaDataEntryBindingSource.DataSource = typeof(UmaDataEntry);
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 357);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "查询马娘";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cardDataEntryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)umaDataEntryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private BindingSource cardDataEntryBindingSource;
        private BindingSource umaDataEntryBindingSource;
    }
}