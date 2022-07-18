/*
 * Created by SharpDevelop.
 * User: PHIELCY
 * Date: 6/12/2020
 * Time: 6:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LensDistortion
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		lensCorrection lc;
		
		public MainForm()
		{
			InitializeComponent();
			
			lc = new lensCorrection(/*0.00005f, new PointF(0,0)*/);
			
			float rd = lc.calc_rd(2.8f);
			float ru = lc.calc_ru(rd);
			
		}
		
		
		List<PointF> calcPoints(int w, int h, int left_right) {
			
			List<PointF> points = new List<PointF> ();
			
			float xc = w/2f;
			float xc_lense = w/2f + left_right * ((trkCenter.Value/100f)*(w/2f));
			float yc = h/2f;
			
			int y_step = h / 19;
			int x_step = w / 19;
			
			lc.center.X = xc - xc_lense;
			lc.center.Y = yc - yc;
			lc.k = trkK.Value / 5000000f;
			
			for (int y = 0; y <= h; y+=y_step) {
				
				for (int x = 0; x <= w; x+=x_step) {
					
					float xK = x - xc;
					float yK = yc - y;
					
					PointF p = lc.uncorrect(new PointF(xK, yK));
					
					PointF p2 = new PointF(xc + p.X,   yc - p.Y);
					
					points.Add(p2);
					
				}
				
			}
			
			return points;
			
		}
		
		
		void Pic1Paint(object sender, PaintEventArgs e)
		{
			
			Graphics g = e.Graphics;
			
			int w = pic1.Width;
			int h = pic1.Height;
			
			List<PointF> ps = calcPoints(w, h, -1);
			
			foreach (PointF p in ps) {
				
				g.DrawEllipse(Pens.Cyan, p.X-1, p.Y-1, 2,2);
				
			}
			
		}


		
		void Pic2Paint(object sender, PaintEventArgs e)
		{
			
			Graphics g = e.Graphics;
			
			int w = pic2.Width;
			int h = pic2.Height;
			
			List<PointF> ps = calcPoints(w, h, +1);
			
			foreach (PointF p in ps) {
				
				g.DrawEllipse(Pens.Cyan, p.X-1, p.Y-1, 2,2);
				
			}
			
		}
		
		

		void TrkCenterScroll(object sender, EventArgs e)
		{
			pic1.Invalidate();
			pic2.Invalidate();
		}

		
	}
	
}
