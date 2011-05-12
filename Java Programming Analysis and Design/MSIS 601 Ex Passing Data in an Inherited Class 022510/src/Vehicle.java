
public class Vehicle {
	private int wheels, range;
	
	public Vehicle(int w, int r){
		wheels=w;
		range=r;
	}
	
	public String toString(){
		return("Wheels: " + wheels + " Range: " + range);
	}
}
