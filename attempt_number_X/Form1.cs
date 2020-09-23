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

        public Button but1 = new Button();
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            


            but1.Text = "My Button ";
            but1.ForeColor = Color.Fuchsia;
            but1.Size = new Size(100, 50);
            but1.Location = new Point(90, 10);
            ///////////////////////////////////////Click
            but1.Click += new EventHandler(but1_Click);
            this.Controls.Add(but1);

            Label label1 = new Label();
            label1.Location = new Point(120, 20);
            label1.Text = "LABEL 1";
            Controls.Add(label1);

        }
        ////////////////////////Обработка Click
        private void but1_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            Pen penLemonChiffon = new Pen(Color.LemonChiffon, 3);
            Pen penMintCream = new Pen(Color.MintCream, 3);
            Pen penOldLace = new Pen(Color.OldLace, 3);
            Pen penNavajoWhite = new Pen(Color.NavajoWhite, 3);
            Pen penMistyRose = new Pen(Color.MistyRose, 3);
            gr.DrawLine(penNavajoWhite, 20, 110, 20, 180);//K
            gr.DrawLine(penNavajoWhite, 20, 150, 55, 110);//K
            gr.DrawLine(penNavajoWhite, 30, 135, 60, 180);//K
            gr.DrawLine(penLemonChiffon, 100, 110, 85, 180);//A
            gr.DrawLine(penLemonChiffon, 100, 110, 115, 180);//A
            gr.DrawLine(penLemonChiffon, 93, 150, 107, 150);//A
            gr.DrawLine(penMintCream, 140, 110, 140, 180);//P
            gr.DrawArc(new Pen(Brushes.MintCream, 3), 30, 110, 140, 40, -20, 40);//P
            gr.DrawLine(penLemonChiffon, 190, 110, 190, 180);//И
            gr.DrawLine(penLemonChiffon, 190, 180, 220, 110);//И
            gr.DrawLine(penLemonChiffon, 220, 110, 220, 180);//И
            gr.DrawLine(penMistyRose, 245, 110, 245, 180);//H
            gr.DrawLine(penMistyRose, 245, 140, 275, 140);//H
            gr.DrawLine(penMistyRose, 275, 110, 275, 180);//H
            gr.DrawLine(penLemonChiffon, 305, 110, 295, 180);//A
            gr.DrawLine(penLemonChiffon, 300, 150, 315, 150);//A
            gr.DrawLine(penLemonChiffon, 305, 110, 320, 180);//A
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("OKR 3");
        }
    }
}
