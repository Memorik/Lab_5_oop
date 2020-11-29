using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace lab5
{
    class Square
    {
        private float length;
        private static Bitmap bitmap;
        private static Graphics graph;
        private Pen bluePen = new Pen(Color.Blue, 3);
        private PointF point1;
        private PointF point2;
        private PointF point3;
        private PointF point4;
        private  PointF[] Points;
        private Form1 f;
        public Square(Form1 form, int Length)
        {
            f = form;
            bitmap = new Bitmap(form.Width, form.Height);
            graph = Graphics.FromImage(bitmap);
            length = Length;
            point1 = new PointF(form.Width / 2, form.Height / 2 );
            point2 = new PointF(point1.X + length, point1.Y);
            point3 = new PointF(point1.X + length, point1.Y - length);
            point4 = new PointF(point1.X, point1.Y - length);
            Points = new PointF[]{point1, point2, point3, point4};
    }
        public void DrowSquare()
        {
            graph.DrawPolygon(bluePen, Points);
            f.picture.Image = bitmap;
        }
        public virtual void Left()
        {
            for(int i = 0; i < Points.Length; i++)
            {
                Points[i].X -= 20;
            }
            graph.Clear(Color.White);
            graph.DrawPolygon(bluePen, Points);
            f.picture.Image = bitmap;
        }
        public virtual void Right()
        {
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i].X += 20;
            }
            graph.Clear(Color.White);
            graph.DrawPolygon(bluePen, Points);
            f.picture.Image = bitmap;
        }

    }
}
