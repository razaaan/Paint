using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paint
{
	public partial class Form1 : Form
	{
		Graphics g;
		bool startPaint = false;
		bool startPaintRectangle; //repeat for ellipse?
		int? coordX = null;
		int? coordY = null;
		Point startPos;
		Point endPos;
		
		bool brush = true;
		bool rectangle = false;
		bool ellipse = false;
		bool eraser = false;
		
		public Form1()
		{
			InitializeComponent();
			g = pnlDraw.CreateGraphics();
			
		}

		//opens color picker 
		private void btnPenColor_Click(object sender, EventArgs e)
		{
			ColorDialog c = new ColorDialog();
			if (c.ShowDialog() == DialogResult.OK)
				btnPenColor.BackColor = c.Color;
			if (btnPenColor.BackColor == Color.Black)
				btnPenColor.ForeColor = Color.White;
		}

		private void pnlDraw_MouseMove(object sender, MouseEventArgs e)
		{
			if (startPaint)
			{

				Pen pen;
				//set pen to options
				
				if (eraser)
				{
					pen = new Pen(pnlDraw.BackColor, barPenWidth.Value);
				}
				else
				{
					pen = new Pen(btnPenColor.BackColor, barPenWidth.Value);
				}
				if (brush || eraser)
				{

					g.DrawLine(pen, new Point(coordX ?? e.X, coordY ?? e.Y), new Point(e.X, e.Y));
					/* ?? returns left if not null, else returns right
					 * coordX ?? e.X equivalent to:
					 * if (coordX != null)
					 *    use e.X
					 * else
					 *    use coordX
					 *    
					 */

					//places latest location as previous location allows line to cont.
					coordX = e.X;
					coordY = e.Y;
				}
				if (rectangle && !startPaintRectangle)
				{
					g.DrawRectangle(pen, new Rectangle(startPos, new Size(endPos.X - startPos.X, endPos.Y - startPos.Y)));
				}
			}
		}

		private void pnlDraw_MouseDown(object sender, MouseEventArgs e)
		{
			startPaint = true; //allows pnlDraw_MouseMove to work
			startPaintRectangle = true;
			startPos = new Point(e.X, e.Y);
		}

		private void pnlDraw_MouseUp(object sender, MouseEventArgs e)
		{
			startPaintRectangle = false;
			endPos = new Point(e.X, e.Y);
			coordX = null;
			coordY = null;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			g.Clear(pnlDraw.BackColor);
		}

		private void btnChooseBrush_Click(object sender, EventArgs e)
		{
			brush = true;
			rectangle = false;
			ellipse = false;
			eraser = false;
			btnChooseBrush.BackColor = Color.Gray;
			btnChooseRectangle.BackColor = Color.LightGray;
			btnChooseEllipse.BackColor = Color.LightGray;
			btnChooseEraser.BackColor = Color.LightGray;
		}

		private void btnChooseRectangle_Click(object sender, EventArgs e)
		{
			brush = false;
			rectangle = true;
			ellipse = false;
			eraser = false;
			btnChooseBrush.BackColor = Color.LightGray;
			btnChooseRectangle.BackColor = Color.Gray;
			btnChooseEllipse.BackColor = Color.LightGray;
			btnChooseEraser.BackColor = Color.LightGray;
		}

		private void btnChooseEllipse_Click(object sender, EventArgs e)
		{
			brush = false;
			rectangle = false;
			ellipse = true;
			eraser = false;
			btnChooseBrush.BackColor = Color.LightGray;
			btnChooseRectangle.BackColor = Color.LightGray;
			btnChooseEllipse.BackColor = Color.Gray;
			btnChooseEraser.BackColor = Color.LightGray;
		}

		private void btnChooseEraser_Click(object sender, EventArgs e)
		{
			brush = false;
			rectangle = false;
			ellipse = false;
			eraser = true;
			btnChooseBrush.BackColor = Color.LightGray;
			btnChooseRectangle.BackColor = Color.LightGray;
			btnChooseEllipse.BackColor = Color.LightGray;
			btnChooseEraser.BackColor = Color.Gray;
		}
	}
}
