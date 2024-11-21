namespace EjThreadsParcial
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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            listBox4 = new ListBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(134, 79);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(325, 452);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(570, 79);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(325, 452);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(1026, 79);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(325, 452);
            listBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(134, 606);
            button1.Name = "button1";
            button1.Size = new Size(223, 46);
            button1.TabIndex = 3;
            button1.Text = "Stop";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 44);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 4;
            label1.Text = "En preparacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(570, 44);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 5;
            label2.Text = "Empaque";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1026, 44);
            label3.Name = "label3";
            label3.Size = new Size(72, 32);
            label3.TabIndex = 6;
            label3.Text = "Envio";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.Location = new Point(1478, 79);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(325, 452);
            listBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1478, 44);
            label4.Name = "label4";
            label4.Size = new Size(133, 32);
            label4.TabIndex = 8;
            label4.Text = "Entregados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1896, 705);
            Controls.Add(label4);
            Controls.Add(listBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private ListBox listBox4;
        private Label label4;
    }
}
