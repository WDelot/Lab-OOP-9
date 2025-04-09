using System;
using System.Drawing;
using System.Windows.Forms;

public class Circle
{
    public int X { get; set; }
    public int Y { get; set; }
    public float Radius { get; set; }
    public Circle(int x, int y, float radius)
    {
        X = x;
        Y = y;
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * Radius;
    }

    public bool ContainsPoint(double px, double py)
    {
        double distance = Math.Sqrt(Math.Pow(px - X, 2) + Math.Pow(py - Y, 2));
        return distance <= Radius;
    }

    public void Draw(Graphics g, Pen pen, int offsetX, int offsetY)
    {
        int drawX = (int)(X - Radius) + offsetX;
        int drawY = (int)(Y - Radius) + offsetY;
        int diameter = (int)(2 * Radius);

        g.DrawEllipse(pen, drawX, drawY, diameter, diameter);
    }

    public void DrawPoint(Graphics g, Brush brush, double px, double py, int offsetX, int offsetY)
    {
        int drawX = (int)px + offsetX;
        int drawY = (int)py + offsetY;
        g.FillEllipse(brush, drawX - 3, drawY - 3, 6, 6);
    }
}
