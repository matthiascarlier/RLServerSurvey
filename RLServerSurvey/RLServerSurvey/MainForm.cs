/*
 * Created by SharpDevelop.
 * User: matthias
 * Date: 28/03/2017
 * Time: 11:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace RLServerSurvey
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Thread oThread;
		String lastServerName = "testName";
		String lastServerIP = "testIP";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Debug.WriteLine("test");
		}
		
		void StartStopButtonClick(object sender, EventArgs e)
		{
			if(startStopButton.Text == "Start"){
				//start running
				startStopButton.Text = "Stop";
				 oThread = new Thread(new ThreadStart(checkFileLoop));
				 oThread.Start();
			}
			else if(startStopButton.Text == "Stop"){
				//stop running 
				startStopButton.Text = "Start";
				oThread.Abort();
				oThread.Join();
			}
			else{
				throw new System.Exception("neither \"Start\" nor \"Stop\"");
			}
		}
		
		void checkFileLoop(){
			using (var fs = new FileStream("C:\\Users\\matthias\\Documents\\My Games\\Rocket League\\TAGame\\Logs\\Launch.log", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				using (var sr = new StreamReader(fs))
				{
					sr.ReadToEnd();
	        		string s = String.Empty;
	        		while (true)
	        		{
	        			s = sr.ReadLine();
	            	   	if(s == null){
	            	   		Debug.WriteLine("line was empty");
	            	   		Thread.Sleep(1000);
	            	   	}
	            	   	else{
	            	   		Debug.WriteLine(s);
	            	   		//TODO check if line means end of game.
	            	   		if(s.Contains("end")){
	            	   			//TODO create popup
	            	   			Invoke((MethodInvoker)delegate() {
	            	   				new EndOfGamePopup(lastServerIP, lastServerName).Show(this);                  	
    							});
	            	   		}
	            	   		
	            	   		//TODO check if line has server IP and/or name
	            	   		
	            	   	}
	        		}
				}
			}
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			oThread.Abort();
			oThread.Join();
		}
	}
	
	
}
