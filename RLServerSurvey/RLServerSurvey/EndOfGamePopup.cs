/*
 * Created by SharpDevelop.
 * User: matthias
 * Date: 28/03/2017
 * Time: 13:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace RLServerSurvey
{
	/// <summary>
	/// Description of EndOfGamePopup.
	/// </summary>
	public partial class EndOfGamePopup : Form
	{
		String serverIP;
		String serverName;
		public EndOfGamePopup(String IP, String name)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			serverIP = IP;
			serverName = name;
			
			serverNameLabel.Text = serverName;
			serverIPLabel.Text = serverIP;
		}
		void CancelButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void AcceptButtonClick(object sender, EventArgs e)
		{
			//TODO add traceroute to ip
			String[] lines = {DateTime.Now + "\t" + serverIP + "\t" + serverName + "\t" + commentsTextBox.Text + "\t" + ratingTrackBar.Value};
			File.AppendAllLines("RLServerSurvey.log", lines);
			this.Close();
		}
	}
}
