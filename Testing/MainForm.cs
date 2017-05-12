/*
 * Created by SharpDevelop.
 * User: kboronka
 * Date: 2015-11-12
 * Time: 1:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using sar.Socket;
using sar.Tools;

namespace Testing
{
	public partial class MainForm : Form
	{
		private SocketClient client1;
		private SocketClient client2;
		
		public MainForm()
		{
			InitializeComponent();
			
			this.timer1.Interval = 100;
			
			client1 = new SocketClient("127.1.1.1", 911);
			client2 = new SocketClient("127.1.1.1", 911);

			client1.SetValue("Testing", AssemblyInfo.Version, true);
			
			this.timer1.Enabled = true;
			
			this.socketMemCacheList1.Client = client1;
		}
		
		private int counter = 0;
		void Timer1Tick(object sender, EventArgs e)
		{
			if (client1.Connected) client1.SetValue("x", counter++.ToString(), true);
		}
	}
}
