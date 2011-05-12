
public class RaceBoat extends Boat {
	boolean throttleState = false;
	
	void goFast() {
		throttleState = true;
	}
	
	void goSlow() {
		throttleState = false;
	}
	
	void whatIsBoatState() {
		if (throttleState) {
			System.out.println("Throttle forward.");
		} else {
			System.out.println("Throttle back.");
		}
	}

}
