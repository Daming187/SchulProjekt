/*
 * Created by SharpDevelop.
 * User: leschner
 * Date: 09.11.2023
 * Time: 08:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace InformationsSystem
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Programm starten
			Console.WriteLine("Informationssystem\n**********************************\n");
			
			//Aufruf der Methode "Ausführen()" im instanziierten Klassenobjekt
			// "leschner" der projektspezifischen Klase "Leschner"
			Leschner leschner = new Leschner();
			leschner.Ausführen();
			
			// Programm anhalten
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}