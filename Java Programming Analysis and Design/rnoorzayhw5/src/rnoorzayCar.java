
public class rnoorzayCar extends rnoorzayAuto {
	//declare car private fields
	private int doors, mpg;
	
	//constructor for car inheriting from auto with super
	public rnoorzayCar(String carMake, String carTransmission, String carColor, 
			int carCylinders, int carDoors, int carMPG) {
		super(carMake, carTransmission, carColor, carCylinders);
		doors = carDoors;
		mpg = carMPG;
	}
	
	//print method for car
	public String printInfo(){
		return(super.printInfo() + " car with " + doors + " doors getting " 
				+ mpg + " MPG.");
	}
}
