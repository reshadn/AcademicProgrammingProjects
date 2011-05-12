
public class SailBoat extends Boat {
	
	boolean sailUp = false;
	
	void goFast() {
		sailUp = true;
	}
	
	void goSlow() {
		sailUp = false;
	}
	
	void whatIsBoatState() {
		if (sailUp){
			System.out.println("Sail is up.");
		} else {
			System.out.println("Sail is down.");
		}
	}

}
