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

		int? coordX = null;
		int? coordY = null;

		
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
				if (rdbtnChooseEraser.Focused)
				{
					pen = new Pen(pnlDraw.BackColor, barPenWidth.Value);
				}
				else
				{
					pen = new Pen(btnPenColor.BackColor, barPenWidth.Value);
				}
				g.DrawLine(pen, new Point(coordX ?? e.X, coordY ?? e.Y), new Point(e.X, e.Y));
				/* ?? returns left if not null, else returns right
				 * coordX ?? e.X equivalent to:
				 * if (coordX != null)
				 *    use e.X
				 * else
				 *    use coordX
				 *    
				 */

				//allows line to continue
				coordX = e.X; 
				coordY = e.Y;
			}
		}

		private void pnlDraw_MouseDown(object sender, MouseEventArgs e)
		{
			startPaint = true; //allows pnlDraw_MouseMove to work
		}

		private void pnlDraw_MouseUp(object sender, MouseEventArgs e)
		{
			startPaint = false;

			coordX = null;
			coordY = null;
		}
	}
}
