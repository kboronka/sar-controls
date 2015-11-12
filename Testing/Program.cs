/*
 * Created by SharpDevelop.
 * User: kboronka
 * Date: 2015-11-12
 * Time: 1:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace Testing
{
	internal sealed class Program : sar.Base.Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
