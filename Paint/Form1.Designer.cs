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
			this.rdbtnChoosePen = new System.Windows.Forms.RadioButton();
			this.rdbtnChooseRectangle = new System.Windows.Forms.RadioButton();
			this.rdbtnChooseCircle = new System.Windows.Forms.RadioButton();
			this.rdbtnChooseEraser = new System.Windows.Forms.RadioButton();
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
			this.groupBox1.Size = new System.Drawing.Size(200, 211);
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
			this.groupBox2.Controls.Add(this.rdbtnChooseEraser);
			this.groupBox2.Controls.Add(this.rdbtnChooseCircle);
			this.groupBox2.Controls.Add(this.rdbtnChooseRectangle);
			this.groupBox2.Controls.Add(this.rdbtnChoosePen);
			this.groupBox2.Location = new System.Drawing.Point(12, 14);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 180);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tools";
			// 
			// rdbtnChoosePen
			// 
			this.rdbtnChoosePen.AutoSize = true;
			this.rdbtnChoosePen.Location = new System.Drawing.Point(9, 32);
			this.rdbtnChoosePen.Name = "rdbtnChoosePen";
			this.rdbtnChoosePen.Size = new System.Drawing.Size(54, 21);
			this.rdbtnChoosePen.TabIndex = 0;
			this.rdbtnChoosePen.TabStop = true;
			this.rdbtnChoosePen.Text = "Pen";
			this.rdbtnChoosePen.UseVisualStyleBackColor = true;
			// 
			// rdbtnChooseRectangle
			// 
			this.rdbtnChooseRectangle.AutoSize = true;
			this.rdbtnChooseRectangle.Location = new System.Drawing.Point(9, 60);
			this.rdbtnChooseRectangle.Name = "rdbtnChooseRectangle";
			this.rdbtnChooseRectangle.Size = new System.Drawing.Size(93, 21);
			this.rdbtnChooseRectangle.TabIndex = 1;
			this.rdbtnChooseRectangle.TabStop = true;
			this.rdbtnChooseRectangle.Text = "Rectangle";
			this.rdbtnChooseRectangle.UseVisualStyleBackColor = true;
			// 
			// rdbtnChooseCircle
			// 
			this.rdbtnChooseCircle.AutoSize = true;
			this.rdbtnChooseCircle.Location = new System.Drawing.Point(9, 88);
			this.rdbtnChooseCircle.Name = "rdbtnChooseCircle";
			this.rdbtnChooseCircle.Size = new System.Drawing.Size(64, 21);
			this.rdbtnChooseCircle.TabIndex = 2;
			this.rdbtnChooseCircle.TabStop = true;
			this.rdbtnChooseCircle.Text = "Circle";
			this.rdbtnChooseCircle.UseVisualStyleBackColor = true;
			// 
			// rdbtnChooseEraser
			// 
			this.rdbtnChooseEraser.AutoSize = true;
			this.rdbtnChooseEraser.Location = new System.Drawing.Point(9, 116);
			this.rdbtnChooseEraser.Name = "rdbtnChooseEraser";
			this.rdbtnChooseEraser.Size = new System.Drawing.Size(71, 21);
			this.rdbtnChooseEraser.TabIndex = 3;
			this.rdbtnChooseEraser.TabStop = true;
			this.rdbtnChooseEraser.Text = "Eraser";
			this.rdbtnChooseEraser.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(807, 454);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pnlDraw);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.barPenWidth)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlDraw;
		private System.Windows.Forms.Button btnPenColor;
		private System.Windows.Forms.TrackBar barPenWidth;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rdbtnChooseEraser;
		private System.Windows.Forms.RadioButton rdbtnChooseCircle;
		private System.Windows.Forms.RadioButton rdbtnChooseRectangle;
		private System.Windows.Forms.RadioButton rdbtnChoosePen;
	}
}

