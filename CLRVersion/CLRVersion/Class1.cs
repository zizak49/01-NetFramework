using System;
using System.Windows.Forms;

namespace CLRVersion
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Console.WriteLine(Environment.Version);
            Button b = new Button();
			Console.Read();
		}
	}
}
