using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaOfShapes
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Calculate_Click(object sender, EventArgs e)
        {
            //let's get all the values for the sides of the triangle
            double side1, side2, side3;
			side1 = double.Parse(traingle_side1.Text);
			side2 = double.Parse(triangle_side2.Text);
			side3 = double.Parse(triangle_side3.Text);

			//now we calculate the area of the triangle
			double area_triangle;
			double s = (side1 + side2 + side3) / 2;
			area_triangle = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
			//set the value of the label for the area to the result of the calculation
			triangle_area.Text = area_triangle.ToString();

			//let's get all the values for the sides of the rectangle
			double length, width;
			length = double.Parse(rectangle_length.Text);
			width = double.Parse(rectangle_width.Text);

			//now we calculate the area of the rectangle
			double area_rectangle = length * width;
			//set the value of the label for the area to the result of the calculation
			rectangle_area1.Text = area_rectangle.ToString();

			//let's now get the value for the radius of the circle
			double radius;
			radius = double.Parse(radius1.Text);

			//now we calculate the area of the circle
			double circle_area = Math.PI * Math.Pow(radius, 2);
			//set the value of the label for the area to the result of the calculation
			circle_area1.Text = circle_area.ToString();
		}
	}
}
