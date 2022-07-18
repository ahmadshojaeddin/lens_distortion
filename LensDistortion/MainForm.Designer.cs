/*
 * Created by SharpDevelop.
 * User: PHIELCY
 * Date: 6/12/2020
 * Time: 6:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LensDistortion
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pic1 = new System.Windows.Forms.PictureBox();
			this.pic2 = new System.Windows.Forms.PictureBox();
			this.trkCenter = new System.Windows.Forms.TrackBar();
			this.trkK = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trkCenter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trkK)).BeginInit();
			this.SuspendLayout();
			// 
			// pic1
			// 
			this.pic1.BackColor = System.Drawing.Color.Black;
			this.pic1.Location = new System.Drawing.Point(12, 12);
			this.pic1.Name = "pic1";
			this.pic1.Size = new System.Drawing.Size(400, 400);
			this.pic1.TabIndex = 0;
			this.pic1.TabStop = false;
			this.pic1.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic1Paint);
			// 
			// pic2
			// 
			this.pic2.BackColor = System.Drawing.Color.Black;
			this.pic2.Location = new System.Drawing.Point(418, 12);
			this.pic2.Name = "pic2";
			this.pic2.Size = new System.Drawing.Size(400, 400);
			this.pic2.TabIndex = 1;
			this.pic2.TabStop = false;
			this.pic2.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic2Paint);
			// 
			// trkCenter
			// 
			this.trkCenter.LargeChange = 10;
			this.trkCenter.Location = new System.Drawing.Point(12, 470);
			this.trkCenter.Maximum = 100;
			this.trkCenter.Minimum = -100;
			this.trkCenter.Name = "trkCenter";
			this.trkCenter.Size = new System.Drawing.Size(806, 45);
			this.trkCenter.TabIndex = 2;
			this.trkCenter.Scroll += new System.EventHandler(this.TrkCenterScroll);
			// 
			// trkK
			// 
			this.trkK.LargeChange = 10;
			this.trkK.Location = new System.Drawing.Point(12, 521);
			this.trkK.Maximum = 300;
			this.trkK.Minimum = 1;
			this.trkK.Name = "trkK";
			this.trkK.Size = new System.Drawing.Size(806, 45);
			this.trkK.TabIndex = 3;
			this.trkK.Value = 50;
			this.trkK.Scroll += new System.EventHandler(this.TrkCenterScroll);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(830, 578);
			this.Controls.Add(this.trkK);
			this.Controls.Add(this.trkCenter);
			this.Controls.Add(this.pic2);
			this.Controls.Add(this.pic1);
			this.Name = "MainForm";
			this.Text = "Lens Distortion Correction";
			((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trkCenter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trkK)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TrackBar trkK;
		private System.Windows.Forms.TrackBar trkCenter;
		private System.Windows.Forms.PictureBox pic2;
		private System.Windows.Forms.PictureBox pic1;
	}
}
