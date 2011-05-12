
public class rnoorzayAuto {
	//declare auto private fields
	private String make, transmission, color;
	private int cylinders;
	
	//auto class constructor
	public rnoorzayAuto(String autoMake, String autoTransmission, String autoColor, int autoCylinders){
		make = autoMake;
		transmission = autoTransmission;
		color = autoColor;
		cylinders = autoCylinders;
	}
	
	//auto print method
	public String printInfo(){
		return("A " + color + ", " + transmission + " transmission, v" + cylinders 
				+ " " + make);
	}

}
