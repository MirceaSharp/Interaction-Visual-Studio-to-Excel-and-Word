namespace Interactie_met_andere_applicaties {
	class Student {
		// 
		// Fields
		//

		//
		// Constructors
		//
		public Student(string naam, string geslacht, double punten) {
			Naam = naam;
			Geslacht = geslacht;
			Punten = punten;
		}

		//
		// Properties
		//
		public double Punten { get; set; }
		public string Geslacht { get; set; }
		public string Naam { get; set; }

		//
		// Methodes
		//
		public override string ToString( )
			=> $"{Naam}";

	}
}
