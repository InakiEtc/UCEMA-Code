namespace EjerciciosOperPrimitivasPila
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
            button1 = new Button();
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
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(125, 259);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(159, 12);
            button1.Name = "button1";
            button1.Size = new Size(173, 23);
            button1.TabIndex = 1;
            button1.Text = "Imprimir Contenido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(159, 43);
            button2.Name = "button2";
            button2.Size = new Size(173, 23);
            button2.TabIndex = 2;
            button2.Text = "Colocar en el fondo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(159, 72);
            button3.Name = "button3";
            button3.Size = new Size(173, 23);
            button3.TabIndex = 3;
            button3.Text = "Cantidad elementos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(159, 101);
            button4.Name = "button4";
            button4.Size = new Size(173, 23);
            button4.TabIndex = 4;
            button4.Text = "Eliminar ocurrencias";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(159, 130);
            button5.Name = "button5";
            button5.Size = new Size(173, 23);
            button5.TabIndex = 5;
            button5.Text = "Intercambiar tope y fin";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(159, 159);
            button6.Name = "button6";
            button6.Size = new Size(173, 23);
            button6.TabIndex = 6;
            button6.Text = "Duplicar contenido";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(159, 188);
            button7.Name = "button7";
            button7.Size = new Size(173, 23);
            button7.TabIndex = 7;
            button7.Text = "Ver palindormo";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(160, 217);
            button8.Name = "button8";
            button8.Size = new Size(172, 23);
            button8.TabIndex = 8;
            button8.Text = "Calcular suma";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(159, 246);
            button9.Name = "button9";
            button9.Size = new Size(173, 23);
            button9.TabIndex = 9;
            button9.Text = "Calcular maximos";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 319);
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
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
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
