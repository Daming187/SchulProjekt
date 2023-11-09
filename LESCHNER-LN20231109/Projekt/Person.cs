/*
 * Created by SharpDevelop.
 * User: leschner
 * Date: 19.10.2023
 * Time: 09:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Projekt
{
	/// <summary>
	/// Description of Leschner.
	/// </summary>
	public class Person
	{
		// Attribute, Eigenschaften, "Instanzvariablen"
		// Attribute vorerst immer mit der Sichtbarkeit private
		// Sichtbarkeiten werden auch Zugriffsrechte genannt
		// sog. Zugriffsrechteverteilung		
		private string vorname;
		private string nachname;
		private string strasse;
		private string plz;
		private string stadt;
		private string land;
		
		
		// Konstruktoren, Erzeugungsverfahren, "Instanzierungen"
		// Konsturktoren vorerst immer mit der Sichtbarkeit public
		// Leerer Konsturktor (ist ohne Angaben auch implizit vorhanden)
		public Person() // explizit formuliert(also angegeben)
		{
			// Muss man nicht machen
			// Sinnvoll Initialiesirungswerte setzen
			// (auch wenn der Compiler dies bereits leistet)
			this.vorname = "";
			this.nachname = "";
			this.strasse= "";
			this.plz= "";
			this.stadt= "";
			this.land= "";
		}
		
		// KONSTRUKTORÜBERLADUNG
		public Person(string vorname, string nachname,string strasse, string plz, string stadt, string land) : this()
		{
			// Zuweisung vom Attributwerten
			// this ist die Selbstreferenz auf das Objekt,
			// also das Objekt selbst
			this.vorname = vorname;
		    this.nachname = nachname;
			this.strasse= strasse;
			this.plz= plz;
			this.stadt= stadt;
			this.land= land;
		}
		
	
		// KONSTRUKTORVERKETTUNG
		// METHODENÜBERLADUNG
		
		//Methoden
		/*public void SetPerson(string vorname, string nachname,string strasse, string plz, string stadt, string land)
		{
			this.vorname = vorname;
		    this.nachname = nachname;
			this.strasse= strasse;
			this.plz= plz;
			this.stadt= stadt;
			this.land= land;
		}*/
		
		public string Singen()
		{
			return "Die Person "+this.vorname+" Singt.";
		}
		
		public void Info()
		{
			 Console.WriteLine("Person:\n"+
								"Vorname:"+ this.vorname + "\n"+
								"Nachname:"+ this.nachname + "\n"+
								"Strasse:"+ this.strasse + "\n"+
								"PLZ:"+ this.plz + "\n"+
								"Stadt:"+ this.stadt + "\n"+
								"Land:"+ this.land );
		}
		
	}
}
