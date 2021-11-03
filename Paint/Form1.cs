using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Paint
{
    public partial class Form1 : Form
    {
        private const int WIDTH = 1079;
        private const int HEIGHT = 718;
        Color color = Color.Black; //Создаем переменную типа Color присваиваем ей черный цвет.
        bool isPressed = false; //логическая переменная понадобиться для опеределения когда можно рисовать на panel
        System.Drawing.Point CurrentPoint; //Текущая точка ресунка.
        System.Drawing.Point PrevPoint; //Это начальная точка рисунка.
        Graphics g; //Создаем графический элемент.
        ColorDialog colorDialog = new ColorDialog(); //диалоговое окно для выбора цвета.
        Bitmap bitmap = new Bitmap(1080, 720);

        Bitmap Mask = new Bitmap(3, 3);

        Point LastLocationOfE = new Point();
        ListOfPoints List = new ListOfPoints();

        bool Status = true;

        Point P1 = new Point();

        public Form1()
        {
            InitializeComponent();
            label3.BackColor = Color.Black; //По умолчанию для пера задан черный цвет, поэтому мы зададим такой же фон для label2
            g = pictureBox1.CreateGraphics();

            List.AddPoint(P1);
        }
         
        private Color GetUZ(int X, int Y)
        {
            Color C = new Color();
            C = Mask.GetPixel(X % 3, Y % 3);
            return C;
        }
         
        private Point СheckingАorПoingФbroad(object sender, MouseEventArgs e)
        {
            if (e.Location.X < 1080 && e.Location.X > 0 && e.Location.Y < 720 && e.Location.Y > 0)
            {
                LastLocationOfE = e.Location;
                return e.Location;
            }
            else
                return LastLocationOfE;
        }
         
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentPoint = СheckingАorПoingФbroad(sender, e);
            isPressed = true;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed == true)
            {
                PrevPoint = CurrentPoint;
                CurrentPoint = СheckingАorПoingФbroad(sender, e);
                if (Pen.Checked)
                    my_Pen2();
                else if (CirclePen.Checked)
                    my_Pen3();
            }
        }
         
        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
                label3.BackColor = colorDialog.Color;
            }
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            Bitmap bitmap2 = new Bitmap(1080, 720);
            bitmap = bitmap2;
            pictureBox1.Image = bitmap;
        }
         

        private void my_Pen2()
        {
            DrowLine();

            pictureBox1.Image = bitmap;
        }

        private void my_Pen3()
        {
            int dxy = Convert.ToInt32(Math.Sqrt(Math.Pow(CurrentPoint.X - PrevPoint.X, 2) + Math.Pow(CurrentPoint.Y - PrevPoint.Y, 2)));
            DrowCircle(dxy);
            pictureBox1.Image = bitmap;
        }
          
        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        { 
            Pen pen = new Pen(color, 1);
            Point B = СheckingАorПoingФbroad(sender, e);
            Color C = bitmap.GetPixel(B.X, B.Y);
            if (Line.Checked)
            {
                if (Status)
                {
                    PrevPoint = СheckingАorПoingФbroad(sender, e);
                    Status = false;
                }
                else
                {
                    CurrentPoint = СheckingАorПoingФbroad(sender, e);
                    DrowLine();
                    Status = true;
                }
            }

            else if (Circle.Checked)
            {
                if (Status)
                {
                    PrevPoint = СheckingАorПoingФbroad(sender, e);
                    Status = false;
                }
                else
                {
                    CurrentPoint = СheckingАorПoingФbroad(sender, e);
                    DrowCircle(Convert.ToInt32(Math.Sqrt(Math.Pow(CurrentPoint.X - PrevPoint.X, 2) + Math.Pow(CurrentPoint.Y - PrevPoint.Y, 2))));
                    Status = true;
                } 
            }
            else if (Bucket2.Checked)
            {
                Bucketk2(B, C, pen);
            }
            else if (Beze.Checked)
            {
                AddP(sender, e);
            }
            pictureBox1.Image = bitmap;  // по идее выведет то что начиркали в битмэпе 
        }
         
        public void AddP(object sender, MouseEventArgs e)
        {
            Point P = СheckingАorПoingФbroad(sender, e);
            List.AddPoint(P);
        }

        public void Draw()
        {
            var step = 0.001f;

            Pen pen = new Pen(color, (float)trackBar1.Value);
            Point lastPt = new Point(List.GetPoint(0).X, List.GetPoint(0).Y);

            for (float t = 0; t < 1; t += step)
            {
                float y = 0;
                float x = 0;

                for (int i = 0; i < List.Count; i++)
                {
                    var b = Polinom(i, List.Count - 1, t);

                    Point pt = List.GetPoint(i);

                    x += pt.X * b;
                    y += pt.Y * b;
                }
                PrevPoint = lastPt;
                CurrentPoint.X = Convert.ToInt32(x);
                CurrentPoint.Y = Convert.ToInt32(y);

                DrowLine();

                lastPt.X = Convert.ToInt32(x);
                lastPt.Y = Convert.ToInt32(y);
            }
        }
         
        public float Polinom(int i, int n, float t)
        {
            return (Factorial(n) / (Factorial(i) * Factorial(n - i))) * (float)Math.Pow(t, i) * (float)Math.Pow(1 - t, n - i);
        }

        public int Factorial(int numb)
        {
            int res = 1;
            for (int i = numb; i > 1; i--)
                res *= i;
            return res;
        }
         
        private void DrowCircle(int r)
        {
            int x = 0;
            int d = 3 - 2 * r; 
            while (r >= x)
            {

                Great8(x, r);
                if (d < 0)
                    d += 4 * x + 6;
                else
                {
                    d += 4 * (x - r) + 10;
                    r--;
                }
                x++;
            }
        }
         
        private void Great8(int x, int y)
        {
            bitmap.SetPixel(WidthProt(PrevPoint.X, x), HightProt(PrevPoint.Y, y), color);
            bitmap.SetPixel(WidthProt(PrevPoint.X, x), HightProt(PrevPoint.Y, -y), color);

            bitmap.SetPixel(WidthProt(PrevPoint.X, -x), HightProt(PrevPoint.Y, y), color);
            bitmap.SetPixel(WidthProt(PrevPoint.X, -x), HightProt(PrevPoint.Y, -y), color);

            bitmap.SetPixel(WidthProt(PrevPoint.X, y), HightProt(PrevPoint.Y, x), color);
            bitmap.SetPixel(WidthProt(PrevPoint.X, y), HightProt(PrevPoint.Y, -x), color);

            bitmap.SetPixel(WidthProt(PrevPoint.X, -y), HightProt(PrevPoint.Y, x), color);
            bitmap.SetPixel(WidthProt(PrevPoint.X, -y), HightProt(PrevPoint.Y, -x), color);

        }

        private int WidthProt(int Pos, int X)
        {
            if (Pos + X > WIDTH)
            {
                return WIDTH;
            }
            if (Pos + X < 0)
            {
                return 0;
            }
            else
                return Pos + X;
        }
         
        private int HightProt(int Pos, int X)
        {
            if (Pos + X > 719)
            {
                return 719;
            }
            if (Pos + X < 0)
            {
                return 0;
            }
            else
                return Pos + X;
        }

        private void Bucketk2(Point B, Color C, Pen pen)
        {
            while (bitmap.GetPixel(B.X - 1, B.Y) == C && B.X > 1 && B.X < WIDTH)
                B.X--;
            int x = B.X;
            int y = B.Y;
            while (bitmap.GetPixel(B.X, B.Y) == C && B.X < WIDTH)//  && B.X > 1 &&
            {
                bitmap.SetPixel(B.X, B.Y, pen.Color); //GetUZ(B.X, B.Y)
                B.X++;
            }
            B.X--;
            while (B.X >= x)
            {
                if (bitmap.GetPixel(B.X, B.Y + 1) == C && B.Y > 1 && B.Y < HEIGHT)
                {
                    B.Y++;
                    Bucketk2(B, C, pen);
                    B.Y--;
                }

                if (bitmap.GetPixel(B.X, B.Y - 1) == C && B.Y > 1 && B.Y < HEIGHT)
                {
                    B.Y--;
                    Bucketk2(B, C, pen);
                    B.Y++;
                }
                B.X--;
            }
        }
         
        double eightShift = 0;
        double widthShift = 0;
        double e = 0;
        private void DrowLine()
        {
            Pen pen = new Pen(color, (float)trackBar1.Value);
            double x = CurrentPoint.X - PrevPoint.X;
            double y = CurrentPoint.Y - PrevPoint.Y;
            eightShift = Math.Abs(y / x);
            widthShift = Math.Abs(x / y);
            int xx = 0;
            int yy = 0;

            if (Math.Abs(x) > Math.Abs(y))
                e = eightShift - 0.5;
            else
                e = widthShift - 0.5;

            for (int i = 0; i < (Math.Abs(x) > Math.Abs(y) ? Math.Abs(x) : Math.Abs(y)); i++)
            {
                if (Math.Abs(x) > Math.Abs(y))
                {
                    if (e >= 0)
                    {
                        yy++;
                        e = e + eightShift - 1;
                    }
                    else
                    {
                        e = e + eightShift;
                    }
                    xx++;
                }
                else
                {
                    if (e >= 0)
                    {
                        xx++;
                        e = e + widthShift - 1;

                    }
                    else
                    {
                        e = e + widthShift;
                    }
                    yy++;
                }
                bitmap.SetPixel(PrevPoint.X + (x < 0 ? -xx : xx), PrevPoint.Y + (y < 0 ? -yy : yy), pen.Color);
            }
        }

        private void Circle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Draw();
            List.Count = 0;
            pictureBox1.Image = bitmap;
        }
    }
}
