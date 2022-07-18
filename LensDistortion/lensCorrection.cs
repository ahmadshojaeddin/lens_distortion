/*
 * Created by SharpDevelop.
 * User: PHIELCY
 * Date: 6/15/2020
 * Time: 3:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace LensDistortion
{
	/// <summary>
	/// Description of lensCorrection.
	/// </summary>
	public class lensCorrection
	{

		// lense distorsion factor
		public float k = 0.3f;
		
		// center of lense
		public PointF center = new PointF(0f, 0f);
		
		
		
		// url: https://stackoverflow.com/questions/6199636/formulas-for-barrel-pincushion-distortion/6227310#6227310
		public float calc_ru(float rd) {
			return rd * ( 1 + k * (rd * rd) );
		}
		
		
		// cube root ( n ^ 1/3 )
		public float cbrt(float n) {
			return (float)Math.Pow(n, 1f / 3f);
		}
		
		// square root ( n ^ 1/2 )
		public float sqrt(float n) {
			return (float)Math.Sqrt(n);
		}
		
		// float power ( x ^ y )
		public float pow(float x, float y) {
			return (float)Math.Pow(x, y);
		}
		
		
		// url: https://stackoverflow.com/questions/6199636/formulas-for-barrel-pincushion-distortion/6227310#6227310
		public float calc_rd(float ru) {
			
			float a = k;
			float x = ru;
			
			float p1 = cbrt(2f / (3f * a));
			float p2 = cbrt( sqrt(3f*a) * sqrt( 27f*a*x*x + 4f ) - 9f*a*x );
			float p3 = cbrt(2f) * pow(3f*a, 2f/3f);
			
			return p1/p2 - p2/p3;
			
		}
		
		
		public float sin(float t) {
			return (float)Math.Sin(t);
		}
		
		public float cos(float t) {
			return (float)Math.Cos(t);
		}
		
		
		
		public PointF uncorrect(PointF p) {
			
			float x = p.X;
			float y = p.Y;
			float xc = center.X;
			float yc = center.Y;
			float dx = x-xc;
			float dy = y-yc;
			float r = sqrt( pow(dx,2) + pow(dy,2) );
			float tetha = (float)Math.Atan2( dy, dx );
			float r2 = calc_rd(r);
			float x2 = r2 * cos(tetha);
			float y2 = r2 * sin(tetha);
			
			return new PointF(xc + x2, yc + y2);
			
		}
		
		

		public lensCorrection(/*float init_k, PointF init_center*/)
		{
//			k = init_k;
//			center = init_center;
		}
		
	}
	
}
