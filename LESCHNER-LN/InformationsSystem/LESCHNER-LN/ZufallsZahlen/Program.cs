/*
 * Created by SharpDevelop.
 * User: leschner
 * Date: 09.11.2023
 * Time: 08:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace ZufallsZahlen
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i;
			int[]zahlen = new int[100];
			Random r = new Random();
			StreamWriter streamWriter = new StreamWriter(@"STATISTIK.TXT");
			
			for(i = 0; i < zahlen.Length; i++ ){
				int rInt = r.Next(0, 1000);
				zahlen[i] = rInt;
				Console.WriteLine(zahlen[i]);
				streamWriter.WriteLine(zahlen[i]);
			}
			streamWriter.Close();
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}