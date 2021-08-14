using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random crandom = new Random();
            int decide = crandom.Next(1, 3);
            int n, m;
            if (decide == 1)
            {
                n = crandom.Next(11, 20);
                m = crandom.Next(11, 20);
                textBoxN.Text = n.ToString();
                textBoxM.Text = m.ToString();
            }
            else if (decide == 2)
            {
                n = crandom.Next(21, 30);
                m = crandom.Next(21, 30);
                textBoxN.Text = n.ToString();
                textBoxM.Text = m.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxN.Text), m = int.Parse(textBoxM.Text), answer;
            answer = n + (m - (m / 10) * 10);
            answer  *= (n / 10) * 10;
            answer = answer + (n - (n / 10) * 10) * (m - (m / 10) * 10);
            if (answer == int.Parse(textBoxAnswer.Text))
            {
                labelRight.Text = "Verygood";
                labelWrong.Text = " ";
                labelRight.Text = " ";
                labelWrong.Text = " ";
                lblProcess1.Text = " ";
                lblProcess2.Text = " ";
                lblProcess3.Text = " ";
                lblProcess4.Text = " ";
            }
            else if (answer != int.Parse(textBoxAnswer.Text))
            {
                labelWrong.Text = "is worng";
                labelRight.Text = " ";
                m = m - (m / 10) * 10;
                answer= n + (m - (m / 10) * 10);
                lblProcess1.Text = n.ToString() + "+" +m .ToString() + "=" +answer.ToString() ;
                lblProcess2.Text = answer.ToString() + "X" + ((n / 10) * 10).ToString() + "=" + (answer * (n / 10) * 10).ToString();
                lblProcess3.Text = (n-(n / 10) * 10) + "X" + (m-(m / 10) * 10)+ "=" + ((n-(n / 10) * 10)*(m- (m / 10) * 10));
                lblProcess4.Text = (answer * (n / 10) * 10) +"+"+ ((n - (n / 10) * 10) * (m - (m / 10) * 10)) + "="+(answer * (n / 10) * 10 + ((n - (n / 10) * 10) * (m - (m / 10) * 10)));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelRight.Text = " ";
            labelWrong.Text = " ";
            textBoxAnswer.Text = " ";
            lblProcess1.Text = " ";
            lblProcess2.Text = " ";
            lblProcess3.Text = " ";
            lblProcess4.Text = " ";
            Random crandom = new Random();
            int decide = crandom.Next(1, 3);
            int n, m;
            if (decide == 1)
            {
                n = crandom.Next(11, 20);
                m = crandom.Next(11, 20);
                textBoxN.Text = n.ToString();
                textBoxM.Text = m.ToString();
            }
            else if (decide == 2)
            {
                n = crandom.Next(21, 30);
                m = crandom.Next(21, 30);
                textBoxN.Text = n.ToString();
                textBoxM.Text = m.ToString();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

