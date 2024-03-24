namespace EjercicioDados
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            hScrollBar1 = new HScrollBar();
            label4 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(165, 258);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "Tirar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 87);
            label1.Margin = new Padding(1);
            label1.Name = "label1";
            label1.Padding = new Padding(25, 18, 25, 25);
            label1.Size = new Size(112, 112);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(278, 87);
            label2.Margin = new Padding(1);
            label2.Name = "label2";
            label2.Padding = new Padding(25, 18, 25, 25);
            label2.Size = new Size(112, 112);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(517, 87);
            label3.Margin = new Padding(1);
            label3.Name = "label3";
            label3.Padding = new Padding(25, 18, 25, 25);
            label3.Size = new Size(282, 112);
            label3.TabIndex = 3;
            label3.Text = "Total: -";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(914, 87);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(603, 657);
            textBox1.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // hScrollBar1
            // 
            hScrollBar1.LargeChange = 100;
            hScrollBar1.Location = new Point(50, 545);
            hScrollBar1.Maximum = 2099;
            hScrollBar1.Minimum = 100;
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(801, 43);
            hScrollBar1.TabIndex = 5;
            hScrollBar1.Value = 1000;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 624);
            label4.Name = "label4";
            label4.Size = new Size(45, 32);
            label4.TabIndex = 6;
            label4.Text = "ms";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(50, 493);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(256, 36);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Tiradas automaticas";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1628, 910);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(hScrollBar1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private HScrollBar hScrollBar1;
        private Label label4;
        private CheckBox checkBox1;
    }
}
