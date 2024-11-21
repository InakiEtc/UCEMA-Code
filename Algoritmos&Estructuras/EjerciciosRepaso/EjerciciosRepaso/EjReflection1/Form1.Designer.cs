namespace EjReflection1
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
            listBox2 = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(103, 96);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(583, 420);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(103, 33);
            button1.Name = "button1";
            button1.Size = new Size(276, 46);
            button1.TabIndex = 1;
            button1.Text = "Ver Propiedades";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(702, 96);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(583, 420);
            listBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(702, 33);
            button2.Name = "button2";
            button2.Size = new Size(384, 46);
            button2.TabIndex = 3;
            button2.Text = "Cargar Propiedad";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 651);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private ListBox listBox2;
        private Button button2;
    }
}
