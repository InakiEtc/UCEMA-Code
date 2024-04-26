using System;
using System.Windows.Forms;

namespace ListaDeAlumnos
{
    public partial class SelectDateForm : Form
    {
        public DateTime SelectedDate { get; private set; }
        public DateTime fecha { get; }

        public SelectDateForm(DateTime fecha)
        {
            this.fecha = fecha;
            InitializeComponent(fecha);            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SelectedDate = monthCalendar1.SelectionStart;
            this.DialogResult = DialogResult.OK;
        }

        private MonthCalendar monthCalendar1;
        private Button button1;

        private void InitializeComponent(DateTime fecha)
        {
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(13, 6);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.SelectionStart = fecha;
            // 
            // button1
            // 
            button1.Location = new Point(97, 176);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SelectDateForm
            // 
            ClientSize = new Size(279, 206);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Name = "SelectDateForm";
            ResumeLayout(false);
        }
    }
}
