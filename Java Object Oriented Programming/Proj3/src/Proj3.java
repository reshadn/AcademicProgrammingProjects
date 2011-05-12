
public class Proj3 {

	public static void main(String args[]) {
		Boat[] Boats;
		char charOne;
		char charTwo;
		int i;
		
		Boats = new Boat[args.length];
		
		for(i=0; i<args.length; i++) {
			charOne = args[i].toUpperCase().charAt(0);
			charTwo = args[i].toUpperCase().charAt(1);
			
			if ((charOne == 'B') || (charOne == 'C') || (charOne == 'N')) {
				Boats[i] = new SailBoat();
			} else {
				Boats[i] = new RaceBoat();
			}
			
			Boats[i].setName(args[i]);
			
			if ((charTwo == 'A') || (charTwo == 'E')) {
				Boats[i].goFast();
			} else {
				Boats[i].goSlow();
			}
		}
		for (i=0; i<args.length; i++) {
						
			Boats[i].printName();
			
			Boats[i].whatIsBoatState();
						
		}
	}
}
