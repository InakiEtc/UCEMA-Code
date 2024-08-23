namespace TorresHanoi
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
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(29, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(240, 356);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(351, 41);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(240, 356);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(700, 41);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(240, 356);
            listBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(29, 414);
            button1.Name = "button1";
            button1.Size = new Size(240, 46);
            button1.TabIndex = 3;
            button1.Text = "Mover a 2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(351, 414);
            button2.Name = "button2";
            button2.Size = new Size(240, 46);
            button2.TabIndex = 4;
            button2.Text = "Mover a 1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(700, 414);
            button3.Name = "button3";
            button3.Size = new Size(240, 46);
            button3.TabIndex = 5;
            button3.Text = "Mover a 1";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(29, 586);
            button4.Name = "button4";
            button4.Size = new Size(911, 46);
            button4.TabIndex = 6;
            button4.Text = "Empezar/Reiniciar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(29, 466);
            button5.Name = "button5";
            button5.Size = new Size(240, 46);
            button5.TabIndex = 7;
            button5.Text = "Mover a 3";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Location = new Point(351, 466);
            button6.Name = "button6";
            button6.Size = new Size(240, 46);
            button6.TabIndex = 8;
            button6.Text = "Mover a 3";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Enabled = false;
            button7.Location = new Point(700, 466);
            button7.Name = "button7";
            button7.Size = new Size(240, 46);
            button7.TabIndex = 9;
            button7.Text = "Mover a 2";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 540);
            label1.Name = "label1";
            label1.Size = new Size(301, 32);
            label1.TabIndex = 10;
            label1.Text = "Cantidad de movimientos: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(348, 541);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(65, 39);
            textBox1.TabIndex = 11;
            textBox1.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 659);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Torres de Hanoi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private TextBox textBox1;
    }
}
