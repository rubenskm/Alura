﻿using System;
using System.Windows.Forms;

namespace Caelum.CaixaEletronico
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)new Form1());
		}
	}
}
