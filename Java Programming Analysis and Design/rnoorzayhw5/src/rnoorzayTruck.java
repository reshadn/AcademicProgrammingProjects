
public class rnoorzayTruck extends rnoorzayAuto {
	//declare truck class private fields
	private int towCapacity, groundClearance;
	//truck constructor inheriting from auto using super
	public rnoorzayTruck(String truckMake, String truckTransmission, String truckColor, 
			int truckCylinders, int truckTowCapacity, int truckGroundClearance) {
		super(truckMake, truckTransmission, truckColor, truckCylinders);
		towCapacity = truckTowCapacity;
		groundClearance = truckGroundClearance;
	}
	
	//print method for truck class
	public String printInfo(){
		return(super.printInfo() + " truck with " + towCapacity + " lbs of towing capacity and " 
				+ groundClearance + " inches of ground clearance.");
	}
}
