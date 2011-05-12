
public abstract class Boat {
	String boatName;
	
	void setName(String name) {
		boatName = name;
	}
	
	void printName() {
		System.out.println("This boat's name is " + boatName);
	}
	
	abstract void goFast();
	abstract void goSlow();
	abstract void whatIsBoatState();
	
}