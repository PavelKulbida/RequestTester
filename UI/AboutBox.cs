using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.Data;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;

namespace UI
{
	
	public partial class AboutBox
	{
		public AboutBox()
		{
			InitializeComponent();
		}
		
		public void AboutBox_Load(System.Object sender, System.EventArgs e)
		{
			// Set the title of the form.
			string ApplicationTitle;
			if ((new Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase()).Info.Title != "")
			{
				ApplicationTitle = (new Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase()).Info.Title;
			}
			else
			{
				ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension((new Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase()).Info.AssemblyName);
			}
			this.Text = string.Format("About {0}", ApplicationTitle);
			// Initialize all of the text displayed on the About Box.
			// TODO: Customize the application's assembly information in the "Application" pane of the project
			//    properties dialog (under the "Project" menu).
			this.LabelProductName.Text = (new Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase()).Info.ProductName;
			this.LabelVersion.Text = string.Format("Version {0}", (new Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase()).Info.Version.ToString());
			this.LabelCopyright.Text = (new Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase()).Info.Copyright;
			this.LabelCompanyName.Text = (new Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase()).Info.CompanyName;
			this.TextBoxDescription.Text = (new Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase()).Info.Description;
		}
		
		public void OKButton_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}
		
	}
}

