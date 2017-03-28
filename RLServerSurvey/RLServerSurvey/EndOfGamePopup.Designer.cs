/*
 * Created by SharpDevelop.
 * User: matthias
 * Date: 28/03/2017
 * Time: 13:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RLServerSurvey
{
	partial class EndOfGamePopup
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label serverNameLabel;
		private System.Windows.Forms.Label serverIPLabel;
		private System.Windows.Forms.TextBox commentsTextBox;
		private System.Windows.Forms.Button AcceptButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.TrackBar ratingTrackBar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.serverNameLabel = new System.Windows.Forms.Label();
			this.serverIPLabel = new System.Windows.Forms.Label();
			this.commentsTextBox = new System.Windows.Forms.TextBox();
			this.AcceptButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.ratingTrackBar = new System.Windows.Forms.TrackBar();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ratingTrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 14);
			this.label1.TabIndex = 1;
			this.label1.Text = "Server name";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Server IP";
			// 
			// serverNameLabel
			// 
			this.serverNameLabel.Location = new System.Drawing.Point(77, 9);
			this.serverNameLabel.Name = "serverNameLabel";
			this.serverNameLabel.Size = new System.Drawing.Size(71, 14);
			this.serverNameLabel.TabIndex = 3;
			this.serverNameLabel.Text = "?????????????????????????";
			// 
			// serverIPLabel
			// 
			this.serverIPLabel.Location = new System.Drawing.Point(77, 27);
			this.serverIPLabel.Name = "serverIPLabel";
			this.serverIPLabel.Size = new System.Drawing.Size(71, 15);
			this.serverIPLabel.TabIndex = 4;
			this.serverIPLabel.Text = "??";
			// 
			// commentsTextBox
			// 
			this.commentsTextBox.Location = new System.Drawing.Point(12, 78);
			this.commentsTextBox.Multiline = true;
			this.commentsTextBox.Name = "commentsTextBox";
			this.commentsTextBox.Size = new System.Drawing.Size(260, 142);
			this.commentsTextBox.TabIndex = 5;
			// 
			// AcceptButton
			// 
			this.AcceptButton.Location = new System.Drawing.Point(8, 226);
			this.AcceptButton.Name = "AcceptButton";
			this.AcceptButton.Size = new System.Drawing.Size(75, 23);
			this.AcceptButton.TabIndex = 6;
			this.AcceptButton.Text = "Accept";
			this.AcceptButton.UseVisualStyleBackColor = true;
			this.AcceptButton.Click += new System.EventHandler(this.AcceptButtonClick);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(90, 227);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// ratingTrackBar
			// 
			this.ratingTrackBar.LargeChange = 1;
			this.ratingTrackBar.Location = new System.Drawing.Point(154, 27);
			this.ratingTrackBar.Maximum = 5;
			this.ratingTrackBar.Minimum = 1;
			this.ratingTrackBar.Name = "ratingTrackBar";
			this.ratingTrackBar.Size = new System.Drawing.Size(118, 45);
			this.ratingTrackBar.TabIndex = 8;
			this.ratingTrackBar.Value = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(154, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 14);
			this.label3.TabIndex = 9;
			this.label3.Text = "Rating";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 15);
			this.label4.TabIndex = 10;
			this.label4.Text = "Comments";
			// 
			// EndOfGamePopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ratingTrackBar);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.AcceptButton);
			this.Controls.Add(this.commentsTextBox);
			this.Controls.Add(this.serverIPLabel);
			this.Controls.Add(this.serverNameLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "EndOfGamePopup";
			this.Text = "EndOfGamePopup";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.ratingTrackBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
