/*
 * Created by SharpDevelop.
 * User: leschner
 * Date: 21.09.2023
 * Time: 14:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Projekt
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Personen");
			// Objekterzeugung, Instanzierungen
			Person person1 = new Person();
			Person person2 = new Person("Damian","Leschner","Schubertstraße","58509","Lüdenscheid","Deustchland");
			
			person2.Info();
			Console.WriteLine(person2.Singen());
			Console.Write(person2.Lied());
			Console.ReadLine();
		}
	}
}