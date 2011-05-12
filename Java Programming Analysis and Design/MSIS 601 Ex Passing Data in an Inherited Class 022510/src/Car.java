
public class Car extends Vehicle{
	private static final int NO_OF_WHEELS=4;
	private int passengers;
	
	public Car(int p, int r){
		//REQUIRED - super must be the first line
		super(NO_OF_WHEELS, r);
		passengers=p;
	}
	
	public String toString(){
		return(super.toString() + " passengers: " + passengers);
	}
}
