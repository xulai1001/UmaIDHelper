namespace UmaIDHelper
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 423);
            button1.Name = "button1";
            button1.Size = new Size(282, 27);
            button1.TabIndex = 1;
            button1.Text = "知道了";
            button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(12, 279);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(256, 138);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "马娘ID查询/测卡辅助工具\n\n测卡的简单GUI\n\nGithub: ";
            // 
            // AboutWindow
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 450);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutWindow";
            Text = "关于本工具";
            Load += AboutWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private RichTextBox richTextBox1;
    }
}