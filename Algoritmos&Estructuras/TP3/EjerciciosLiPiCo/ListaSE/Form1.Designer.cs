namespace ListaSE
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(36, 33);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(392, 73);
            button1.TabIndex = 3;
            button1.Text = "Agregar al Principio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 14F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 50;
            listBox1.Location = new Point(1028, 33);
            listBox1.Margin = new Padding(6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(420, 604);
            listBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(36, 118);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(392, 73);
            button2.TabIndex = 4;
            button2.Text = "Agregar al Final";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(36, 621);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(392, 73);
            button3.TabIndex = 5;
            button3.Text = "Cantidad";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F);
            button4.Location = new Point(36, 203);
            button4.Margin = new Padding(6);
            button4.Name = "button4";
            button4.Size = new Size(392, 73);
            button4.TabIndex = 6;
            button4.Text = "Agregar Posición N";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14F);
            button5.Location = new Point(36, 536);
            button5.Margin = new Padding(6);
            button5.Name = "button5";
            button5.Size = new Size(392, 73);
            button5.TabIndex = 7;
            button5.Text = "Nodo Posición N";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14F);
            button6.Location = new Point(452, 33);
            button6.Margin = new Padding(6);
            button6.Name = "button6";
            button6.Size = new Size(392, 73);
            button6.TabIndex = 8;
            button6.Text = "Borrar Primer Nodo";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14F);
            button7.Location = new Point(452, 118);
            button7.Margin = new Padding(6);
            button7.Name = "button7";
            button7.Size = new Size(392, 73);
            button7.TabIndex = 9;
            button7.Text = "Borrar Ultimo Nodo";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 14F);
            button8.Location = new Point(452, 203);
            button8.Margin = new Padding(6);
            button8.Name = "button8";
            button8.Size = new Size(392, 73);
            button8.TabIndex = 10;
            button8.Text = "Borrar Nodo Pos N";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 14F);
            button9.Location = new Point(36, 451);
            button9.Margin = new Padding(6);
            button9.Name = "button9";
            button9.Size = new Size(392, 73);
            button9.TabIndex = 11;
            button9.Text = "Swapear Nodos";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}
