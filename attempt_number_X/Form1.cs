using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attempt_number_X
{
    public partial class Form1 : Form
    {
        public Button but = new Button();

        public Form1()
        {
            InitializeComponent();


            but.Text = "My Button ";
            but.Size = new Size(100, 50);
            but.Location = new Point(90, 10);
            ///////////////////////////////////////Click
            but.Click += new EventHandler(but_Click);
            this.Controls.Add(but);

            Label label1 = new Label();
            label1.Location = new Point(20, 20);
            label1.Text = "LABEL";
            Controls.Add(label1);

        }
        ////////////////////////Обработка Click
        private void but_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ciao!", "Welcome!");
        }
    }
}
