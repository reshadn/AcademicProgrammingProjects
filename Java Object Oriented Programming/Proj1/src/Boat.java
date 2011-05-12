
public class Boat {
	String boatName;
	boolean sailUp = false;
	
	void setName(String name){
		boatName = name;		
	}
	
	void printName(){
		System.out.println("This boat's name is " + boatName);
	}
	
	void goFast() {
		System.out.println("Raising the sail.");
		sailUp = true;
	}
	
	void goSlow(){
		System.out.println("Lowering the sail.");
		sailUp = false;
	}
	
	void whereIsTheSail(){
		if (sailUp){
			System.out.println("The sail is up.");
		} else {
			System.out.println("The sail is down.");
		}
	}
}
