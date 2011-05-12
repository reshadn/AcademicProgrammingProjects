import java.io.FileWriter;
import java.io.IOException;


public abstract class Boat {
String boatName;
	
	void setName(String name) {
		boatName = name;
	}
	
	void printName(FileWriter b) {
	    try {
			b.write("This boat's name is " + boatName + "\n");
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	abstract void goFast();
	abstract void goSlow();
	abstract void whatIsBoatState(FileWriter b);

}
