namespace PilaParesImpares
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(40, 681);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(846, 73);
            button1.TabIndex = 5;
            button1.Text = "Separar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 14F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 50;
            listBox1.Location = new Point(40, 37);
            listBox1.Margin = new Padding(6, 6, 6, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(239, 604);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 14F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 50;
            listBox2.Location = new Point(363, 37);
            listBox2.Margin = new Padding(6);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(212, 604);
            listBox2.TabIndex = 8;
            // 
            // listBox3
            // 
            listBox3.Font = new Font("Segoe UI", 14F);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 50;
            listBox3.Location = new Point(688, 37);
            listBox3.Margin = new Padding(6);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(198, 604);
            listBox3.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 791);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
    }
}
