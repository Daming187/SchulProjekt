/*
 * Created by SharpDevelop.
 * User: damia
 * Date: 12.10.2023
 * Time: 08:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace Dateien
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			char[] frequency = new char[256];
			
			StreamReader streamReader = new StreamReader(@"INPUT.TXT");
			
			while (streamReader.EndOfStream == false)
			{
				string line = streamReader.ReadLine();
				
				for (int symbol = 0; symbol < line.Length; symbol++)
				{
					int asciiCode = line[symbol];
					
					if ( asciiCode >= 0 && asciiCode <= 255)
					{
						frequency[asciiCode]++;
					}							
				}
			}
			
			streamReader.Close();
			
			StreamWriter streamWriter = new StreamWriter(@"OUTPUT.TXT");
			
			for (int i = 0; i < frequency.Length; i++)
			{
				if(frequency[i] > 0)
				{
					Console.WriteLine("Das Zeichen {0} kommt {1,4} Mal vor",
				                  	(char)i,
				                  	(int)frequency[i]);
					streamWriter.WriteLine("Zeichen: {0} Anzahl: {1}",
				                       	(char)i,
				                       	(int)frequency[i]);
				}
			}
			
			streamWriter.Close();
			
			
			Console.WriteLine(streamReader);
			Console.ReadKey(true);
		}
	}
}