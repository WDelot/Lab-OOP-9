using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_OOP_9
{
    public partial class CircleForm : Form
    {
        private Circle circle;
        private float pointX, pointY;
        private bool isPointSet = false;

        public CircleForm()
        {
            InitializeComponent();
        }

        private void btnCalculateCircumference_Click(object sender, EventArgs e)
        {
            if (!UpdateCircleFromInput()) return;
            txtResult.Text = $"Довжина кола: {circle.GetCircumference():F2}";
        }
        private void btnCheckPoint_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtX.Text, out pointX) && float.TryParse(txtY.Text, out pointY))
            {
                isPointSet = true;
                panelCanvas.Invalidate(); 

                bool inside = circle.ContainsPoint(pointX, pointY);
                txtResult.Text = inside ? "Точка всередині круга" : "Точка поза кругом";
            }
            else
            {
                txtResult.Text = "Невірні координати";
            }
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (circle == null) return;

            Graphics g = e.Graphics;
            int offsetX = panelCanvas.Width / 2;
            int offsetY = panelCanvas.Height / 2;

            circle.Draw(g, Pens.Blue, offsetX, offsetY);

            if (isPointSet)
            {
                Brush brush = circle.ContainsPoint(pointX, pointY) ? Brushes.Green : Brushes.Red;
                circle.DrawPoint(g, brush, pointX, pointY, offsetX, offsetY);
            }
        }
        private void btnCalculateArea_Click(object sender, EventArgs e)
        {
            if (!UpdateCircleFromInput()) return;
            txtResult.Text = $"Площа: {circle.GetArea():F2}";
        }

        private void CircleForm_Load(object sender, EventArgs e)
        {

        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateCircleFromInput()) return;
        }

        private bool UpdateCircleFromInput()
        {
            if(!float.TryParse(txtRadius.Text, out float radius) || radius <= 0)
    {
                txtResult.Text = "Невірний радіус";
                return false;
            }

            circle = new Circle(0, 0, radius);
            panelCanvas.Invalidate();
            return true;
        }
    }
}
