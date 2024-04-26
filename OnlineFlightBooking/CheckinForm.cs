using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineFlightBooking
{
    public partial class CheckinForm : Form
    {
        public CheckinForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Blue;
            button1.ForeColor = Color.Black;
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            button1.ForeColor = Color.Blue;
            panel2.Visible = false;
            panel1.Visible= true;
        }

        private void CheckinForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\airplane.png");
            pictureBox2.Image = Image.FromFile("C:\\airplane.png");
            pictureBox3.Image = Image.FromFile("C:\\direction1.png");
            panel2.AutoScroll= true;
            var flightPanel2 = new Panel();

            for (int i = 0; i < 10; i++)
            {
                flightPanel2.Controls.Clear();
                flightPanel2.Controls.Add(label11);
                flightPanel2.Controls.Add(label10);
                flightPanel2.Controls.Add(button4);
                flightPanel2.Controls.Add(label9);
                flightPanel2.Controls.Add(label8);
                flightPanel2.Controls.Add(label7);
                flightPanel2.Controls.Add(label6);
                flightPanel2.Controls.Add(label5);
                flightPanel2.Controls.Add(pictureBox3);
                flightPanel2.Controls.Add(pictureBox2);
                flightPanel2.Controls.Add(pictureBox1);
                flightPanel2.Location = new System.Drawing.Point(3, 16+i*125);
                flightPanel2.Size = new System.Drawing.Size(859, 123);
                flightPanel2.Name = $"flightPanel{i + 1}";
                flightPanel2.TabIndex = i;
                panel2.Controls.Add(flightPanel2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill out the form completely.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
            }
        }
    }
}
