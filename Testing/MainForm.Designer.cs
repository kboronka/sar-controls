/*
 * Created by SharpDevelop.
 * User: kboronka
 * Date: 2015-11-12
 * Time: 1:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Testing
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private sarControls.FolderSelect folderSelect1;
		private sar.Controls.SocketMemCacheList socketMemCacheList1;
		private sar.Controls.SocketClientControl socketClientControl1;
		private sar.Controls.BooleanIndicator booleanIndicator1;
		private sar.Controls.ReadOnlyTextBox readOnlyTextBox1;
		private System.Windows.Forms.Timer timer1;
		
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
			this.components = new System.ComponentModel.Container();
			this.folderSelect1 = new sarControls.FolderSelect();
			this.socketMemCacheList1 = new sar.Controls.SocketMemCacheList();
			this.socketClientControl1 = new sar.Controls.SocketClientControl();
			this.booleanIndicator1 = new sar.Controls.BooleanIndicator();
			this.readOnlyTextBox1 = new sar.Controls.ReadOnlyTextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// folderSelect1
			// 
			this.folderSelect1.Location = new System.Drawing.Point(12, 12);
			this.folderSelect1.Name = "folderSelect1";
			this.folderSelect1.Path = null;
			this.folderSelect1.Size = new System.Drawing.Size(414, 21);
			this.folderSelect1.TabIndex = 0;
			// 
			// socketMemCacheList1
			// 
			this.socketMemCacheList1.FullRowSelect = true;
			this.socketMemCacheList1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.socketMemCacheList1.Location = new System.Drawing.Point(12, 39);
			this.socketMemCacheList1.Name = "socketMemCacheList1";
			this.socketMemCacheList1.Size = new System.Drawing.Size(440, 376);
			this.socketMemCacheList1.TabIndex = 1;
			this.socketMemCacheList1.UseCompatibleStateImageBehavior = false;
			this.socketMemCacheList1.View = System.Windows.Forms.View.Details;
			// 
			// socketClientControl1
			// 
			this.socketClientControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.socketClientControl1.Location = new System.Drawing.Point(503, 26);
			this.socketClientControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.socketClientControl1.Name = "socketClientControl1";
			this.socketClientControl1.Size = new System.Drawing.Size(465, 370);
			this.socketClientControl1.TabIndex = 2;
			// 
			// booleanIndicator1
			// 
			this.booleanIndicator1.Caption = "booleanIndicator";
			this.booleanIndicator1.Font = new System.Drawing.Font("Arial", 9.75F);
			this.booleanIndicator1.Location = new System.Drawing.Point(659, 3);
			this.booleanIndicator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.booleanIndicator1.MaximumSize = new System.Drawing.Size(500, 16);
			this.booleanIndicator1.MinimumSize = new System.Drawing.Size(100, 16);
			this.booleanIndicator1.Name = "booleanIndicator1";
			this.booleanIndicator1.Size = new System.Drawing.Size(187, 16);
			this.booleanIndicator1.Status = false;
			this.booleanIndicator1.TabIndex = 3;
			// 
			// readOnlyTextBox1
			// 
			this.readOnlyTextBox1.BackColor = System.Drawing.Color.White;
			this.readOnlyTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.readOnlyTextBox1.Location = new System.Drawing.Point(533, 417);
			this.readOnlyTextBox1.Multiline = true;
			this.readOnlyTextBox1.Name = "readOnlyTextBox1";
			this.readOnlyTextBox1.ReadOnly = true;
			this.readOnlyTextBox1.Size = new System.Drawing.Size(241, 20);
			this.readOnlyTextBox1.TabIndex = 4;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(980, 481);
			this.Controls.Add(this.readOnlyTextBox1);
			this.Controls.Add(this.booleanIndicator1);
			this.Controls.Add(this.socketClientControl1);
			this.Controls.Add(this.socketMemCacheList1);
			this.Controls.Add(this.folderSelect1);
			this.Name = "MainForm";
			this.Text = "Testing";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
