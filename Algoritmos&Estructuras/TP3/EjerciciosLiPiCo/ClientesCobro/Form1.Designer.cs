namespace ClientesCobro
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(56, 60);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(248, 420);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(342, 95);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(277, 39);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(342, 199);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(277, 39);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(342, 417);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(277, 39);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(342, 307);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(277, 39);
            textBox4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 60);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 5;
            label1.Text = "Dinero a cobrar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 164);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 6;
            label2.Text = "Dinero cobrado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 272);
            label3.Name = "label3";
            label3.Size = new Size(210, 32);
            label3.TabIndex = 7;
            label3.Text = "Clientes sin cobrar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 382);
            label4.Name = "label4";
            label4.Size = new Size(234, 32);
            label4.TabIndex = 8;
            label4.Text = "Clientes ya cobrados";
            // 
            // button1
            // 
            button1.Location = new Point(56, 502);
            button1.Name = "button1";
            button1.Size = new Size(252, 46);
            button1.TabIndex = 9;
            button1.Text = "Encolar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(342, 502);
            button2.Name = "button2";
            button2.Size = new Size(277, 46);
            button2.TabIndex = 10;
            button2.Text = "Desencolar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 600);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}
