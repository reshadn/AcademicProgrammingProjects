import java.io.FileWriter;
import java.io.IOException;


public class SailBoat extends Boat {
	
	boolean sailUp = false;
	
	void goFast() {
		sailUp = true;
	}
	
	void goSlow() {
		sailUp = false;
	}
	
	void whatIsBoatState(FileWriter b) {
		if (sailUp){
			try {
				b.write("Sail is up. \n");
			} catch (IOException e) {
				e.printStackTrace();
			}
		} else {
			try {
				b.write("Sail is down. \n");
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
	}

}
