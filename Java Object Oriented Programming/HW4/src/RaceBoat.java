import java.io.FileWriter;
import java.io.IOException;


public class RaceBoat extends Boat {
	boolean throttleState = false;
	
	void goFast() {
		throttleState = true;
	}
	
	void goSlow() {
		throttleState = false;
	}
	
	void whatIsBoatState(FileWriter b) {
		if (throttleState) {
			try {
				b.write("Throttle forward. \n");
			} catch (IOException e) {
				e.printStackTrace();
			}
		} else {
			try {
				b.write("Throttle back. \n");
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
	}

}
