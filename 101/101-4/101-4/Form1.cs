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

        Bitmap bmp = new Bitmap(620, 460);
        double IntersectionCoordinates_X, IntersectionCoordinates_Y;
        double zeroa = 0, zerob = 0;
        private void drawCoordinate(Bitmap bmp)
        {
            if (bmp == null) return;
            Graphics pic_g = Graphics.FromImage(bmp);
            Brush pointbrush = new SolidBrush(Color.Black);
            Brush textbrush = new SolidBrush(Color.Black);
            Font font = new Font("微軟正黑體", 12);
            Pen pic_p = new Pen(Color.Black, 3);
            pic_g.DrawLine(pic_p,
                30,
                230,
                590,
                230);
            pic_g.DrawLine(pic_p,
                310,
                20,
                310,
                440);
            pic_g.DrawString("(0,0)", font, textbrush, 320, 240);
            pic_g.DrawString("(40,0)", font, textbrush, 570, 240);
            pic_g.DrawString("(-40,0)", font, textbrush, 0, 240);
            pic_g.DrawString("(0,30)", font, textbrush, 320, 10);
            for (int i = 0; i < 9; i++)
            {
                pic_g.FillEllipse(pointbrush, 25+i*70, 226, 10, 10);
            }
            for (int i = 0; i < 8; i++)
            {
                pic_g.FillEllipse(pointbrush, 60 + i * 70, 231, 3, 3);
            }
            for (int i = 0; i < 7; i++)
            {
                pic_g.FillEllipse(pointbrush, 305, 15 + i * 70, 10, 10);
            }
            for (int i = 0; i < 6; i++)
            {
                pic_g.FillEllipse(pointbrush, 306, 50 + i * 70, 8, 3);
            }
            pic1.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawCoordinate(bmp);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(620, 460);
            pic1.Image = bmp;
            drawCoordinate(bmp);
            txtIntersectionCoordinate.Text = "";
            txtresult.Text = "";
            txtCoordinate1.Text = "";
            txtCoordinate3.Text = "";
            txtCoordinate2.Text = "";
            txtCoordinate4.Text = "";
        }

        private void btndraw_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(620, 460);
            pic1.Image = bmp;
            drawCoordinate(bmp);
            DrawFunctionalDigraph(bmp);
            if(judgement(txtCoordinate1, txtCoordinate2, txtCoordinate3, txtCoordinate4))
            {
                txtIntersectionCoordinate.Text =   IntersectionCoordinates_X.ToString("#.##") + "," + IntersectionCoordinates_Y.ToString("#.##");
                txtresult.Text = "有相交";
            }
            else
                txtresult.Text = "未相交";
        }

        private bool judgement(TextBox Coordinate1, TextBox Coordinate2, TextBox Coordinate3, TextBox Coordinate4)
        {
            double X1, X2, X3, X4, Y1, Y2, Y3, Y4,
                         X1_Coefficient, Y1_Coefficient, X2_Coefficient, Y2_Coefficient,
                         Constant1, Constant2;                     
            string[] coordinate1 = Coordinate1.Text.Split(',');
            string[] coordinate2 = Coordinate2.Text.Split(',');
            string[] coordinate3 = Coordinate3.Text.Split(',');
            string[] coordinate4 = Coordinate4.Text.Split(',');
            X1 = double.Parse(coordinate1[0]);
            X2 = double.Parse(coordinate2[0]);
            X3 = double.Parse(coordinate3[0]);
            X4 = double.Parse(coordinate4[0]);
            Y1 = double.Parse(coordinate1[1]);
            Y2 = double.Parse(coordinate2[1]);
            Y3 = double.Parse(coordinate3[1]);
            Y4 = double.Parse(coordinate4[1]);
            X1_Coefficient = Y1 - Y2;
            Y1_Coefficient = X1 - X2;
            X2_Coefficient = Y3 - Y4;
            Y2_Coefficient = X3 - X4;
            Constant1 = Y1 * Y1_Coefficient - X1 * X1_Coefficient;
            Constant2 = Y3 * Y2_Coefficient - X3 * X2_Coefficient;
            IntersectionCoordinates_X = ((-Constant1) * (-Y2_Coefficient) - ( -Constant2) * (-Y1_Coefficient)) / (X1_Coefficient * (-Y2_Coefficient) - X2_Coefficient * (-Y1_Coefficient));
            IntersectionCoordinates_Y = ((-Constant1) * X2_Coefficient - ( -Constant2) * X1_Coefficient) / ((-Y1_Coefficient) * X2_Coefficient - X1_Coefficient * (-Y2_Coefficient));

            if (IntersectionCoordinates_X.ToString() == "非數值")
                return false;
            else
                return true;
        }
        private void DrawFunctionalDigraph(Bitmap bmp)
        {
            float X1, X2, X3, X4, Y1, Y2, Y3, Y4;
            string[] coordinate1 = txtCoordinate1.Text.Split(',');
            string[] coordinate2 = txtCoordinate2.Text.Split(',');
            string[] coordinate3 = txtCoordinate3.Text.Split(',');
            string[] coordinate4 = txtCoordinate4.Text.Split(',');
            X1 = float.Parse(coordinate1[0]);
            X2 = float.Parse(coordinate2[0]);
            X3 = float.Parse(coordinate3[0]);
            X4 = float.Parse(coordinate4[0]);
            Y1 = float.Parse(coordinate1[1]);
            Y2 = float.Parse(coordinate2[1]);
            Y3 = float.Parse(coordinate3[1]);
            Y4 = float.Parse(coordinate4[1]);
            if (bmp == null) return;
            Graphics pic_g = Graphics.FromImage(bmp);
            Pen pic_p = new Pen(Color.Black, 3);
            pic_g.DrawLine(pic_p, X1*7+310, 230-Y1*7, X2*7+310, 230- Y2*7);
            pic_g.DrawLine(pic_p, X3*7+310, 230-Y3*7, X4*7+310, 230-Y4*7);
            pic1.Image = bmp;
        }
    }
}
