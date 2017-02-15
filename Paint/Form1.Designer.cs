namespace Paint
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlDraw = new System.Windows.Forms.Panel();
			this.btnPenColor = new System.Windows.Forms.Button();
			this.barPenWidth = new System.Windows.Forms.TrackBar();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnChooseEraser = new System.Windows.Forms.Button();
			this.btnChooseEllipse = new System.Windows.Forms.Button();
			this.btnChooseRectangle = new System.Windows.Forms.Button();
			this.btnChooseBrush = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.barPenWidth)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlDraw
			// 
			this.pnlDraw.BackColor = System.Drawing.Color.White;
			this.pnlDraw.Location = new System.Drawing.Point(228, 6);
			this.pnlDraw.Name = "pnlDraw";
			this.pnlDraw.Size = new System.Drawing.Size(561, 436);
			this.pnlDraw.TabIndex = 0;
			this.pnlDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseDown);
			this.pnlDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseMove);
			this.pnlDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseUp);
			// 
			// btnPenColor
			// 
			this.btnPenColor.ForeColor = System.Drawing.Color.Black;
			this.btnPenColor.Location = new System.Drawing.Point(6, 122);
			this.btnPenColor.Name = "btnPenColor";
			this.btnPenColor.Size = new System.Drawing.Size(188, 38);
			this.btnPenColor.TabIndex = 1;
			this.btnPenColor.Text = "Pen Color";
			this.btnPenColor.UseVisualStyleBackColor = true;
			this.btnPenColor.Click += new System.EventHandler(this.btnPenColor_Click);
			// 
			// barPenWidth
			// 
			this.barPenWidth.Location = new System.Drawing.Point(6, 46);
			this.barPenWidth.Maximum = 20;
			this.barPenWidth.Name = "barPenWidth";
			this.barPenWidth.Size = new System.Drawing.Size(188, 56);
			this.barPenWidth.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnPenColor);
			this.groupBox1.Controls.Add(this.barPenWidth);
			this.groupBox1.Location = new System.Drawing.Point(12, 200);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 188);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pen Control";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Pen Width";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnChooseEraser);
			this.groupBox2.Controls.Add(this.btnChooseEllipse);
			this.groupBox2.Controls.Add(this.btnChooseRectangle);
			this.groupBox2.Controls.Add(this.btnChooseBrush);
			this.groupBox2.Location = new System.Drawing.Point(12, 14);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 180);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tools";
			// 
			// btnChooseEraser
			// 
			this.btnChooseEraser.BackColor = System.Drawing.Color.LightGray;
			this.btnChooseEraser.Location = new System.Drawing.Point(9, 136);
			this.btnChooseEraser.Name = "btnChooseEraser";
			this.btnChooseEraser.Size = new System.Drawing.Size(185, 32);
			this.btnChooseEraser.TabIndex = 3;
			this.btnChooseEraser.Text = "Eraser";
			this.btnChooseEraser.UseVisualStyleBackColor = false;
			this.btnChooseEraser.Click += new System.EventHandler(this.btnChooseEraser_Click);
			// 
			// btnChooseEllipse
			// 
			this.btnChooseEllipse.BackColor = System.Drawing.Color.LightGray;
			this.btnChooseEllipse.Location = new System.Drawing.Point(9, 100);
			this.btnChooseEllipse.Name = "btnChooseEllipse";
			this.btnChooseEllipse.Size = new System.Drawing.Size(185, 32);
			this.btnChooseEllipse.TabIndex = 2;
			this.btnChooseEllipse.Text = "Ellipse";
			this.btnChooseEllipse.UseVisualStyleBackColor = false;
			this.btnChooseEllipse.Click += new System.EventHandler(this.btnChooseEllipse_Click);
			// 
			// btnChooseRectangle
			// 
			this.btnChooseRectangle.BackColor = System.Drawing.Color.LightGray;
			this.btnChooseRectangle.Location = new System.Drawing.Point(9, 60);
			this.btnChooseRectangle.Name = "btnChooseRectangle";
			this.btnChooseRectangle.Size = new System.Drawing.Size(185, 32);
			this.btnChooseRectangle.TabIndex = 1;
			this.btnChooseRectangle.Text = "Rectangle";
			this.btnChooseRectangle.UseVisualStyleBackColor = false;
			this.btnChooseRectangle.Click += new System.EventHandler(this.btnChooseRectangle_Click);
			// 
			// btnChooseBrush
			// 
			this.btnChooseBrush.BackColor = System.Drawing.Color.Gray;
			this.btnChooseBrush.Location = new System.Drawing.Point(9, 22);
			this.btnChooseBrush.Name = "btnChooseBrush";
			this.btnChooseBrush.Size = new System.Drawing.Size(185, 32);
			this.btnChooseBrush.TabIndex = 0;
			this.btnChooseBrush.Text = "Brush";
			this.btnChooseBrush.UseVisualStyleBackColor = false;
			this.btnChooseBrush.Click += new System.EventHandler(this.btnChooseBrush_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(13, 395);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(199, 47);
			this.btnClear.TabIndex = 5;
			this.btnClear.Text = "Clear All";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(807, 454);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pnlDraw);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.barPenWidth)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlDraw;
		private System.Windows.Forms.Button btnPenColor;
		private System.Windows.Forms.TrackBar barPenWidth;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnChooseEraser;
		private System.Windows.Forms.Button btnChooseEllipse;
		private System.Windows.Forms.Button btnChooseRectangle;
		private System.Windows.Forms.Button btnChooseBrush;
	}
}

