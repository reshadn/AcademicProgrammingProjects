import java.util.Scanner;

// test class will take in user input for an automobile, truck and car and create an object for each
public class rnoorzayTestAuto {
	
	public static void main (String[] args) {
		//declare variables to hold values for each object
		String make, transmission, color;
		int cylinders = 0, towCapacity = 0, groundClearance = 0, doors = 0, mpg = 0;
		boolean bool; 
		
		//print out welcome lines
		System.out.println("Welcome to Greasy Gus' Auto Inventory\n");
		
		//initialize scanner to read user input
		Scanner scanner = new Scanner(System.in);	
		
		//Take user input for the automobile and assign values
		System.out.println("Let's start by entering an automobile:");
		System.out.println("What's the make?");
		make = scanner.nextLine();
		
		System.out.println("How many cylinders? (Please enter a number)");	
		do {
		try {
			cylinders = scanner.nextInt();
			scanner.nextLine();
				if(cylinders <=0){
					System.out.println("Please enter a number greater than 0.");
				}
			} catch (Exception e) {
				System.out.println("Please enter a valid number.");
				scanner.nextLine();
			}
		}while(cylinders <=0);
		
		
		System.out.println("What transmission? (Manual or Auto)");
		transmission = scanner.nextLine();
	
		System.out.println("What color?");
		color = scanner.nextLine();
		
		//create the automobile object
		rnoorzayAuto newAuto = new rnoorzayAuto(make, transmission, color, cylinders);	
		
		//Take the user input for the truck and assign to the variables
		System.out.println("Ok now enter a truck:");
		System.out.println("What's the make?");
		make = scanner.nextLine();
		
		System.out.println("How many cylinders? (Please enter a number)");
		do{
			cylinders = -1;
		try {
			cylinders = scanner.nextInt();
			scanner.nextLine();
			} catch (Exception e) {
				System.out.println("Please enter a valid number.");
				scanner.nextLine();
			}
		}while(cylinders <= 0);
		
		System.out.println("What transmission? (Manual or Auto)");
		transmission = scanner.nextLine();
		
		System.out.println("What color?");
		color = scanner.nextLine();
		
		System.out.println("How many pounds of towing?");
		do{
			bool = true;
		try {
			towCapacity = scanner.nextInt();
			scanner.nextLine();
			bool = false;
		} catch (Exception e) {
			System.out.println("Please enter a valid number.");
			scanner.nextLine();
			}
		}while(bool);
		
		System.out.println("How many inches of ground clearance?");
		do{
			bool = true;
		try {
			groundClearance = scanner.nextInt();
			scanner.nextLine();
			bool = false;
		} catch (Exception e) {
			System.out.println("Please enter a valid number.");
			scanner.nextLine();
			}
		}while(bool);
		
		//create the truck object
		rnoorzayTruck newTruck = new rnoorzayTruck(make, transmission, color, cylinders, towCapacity, groundClearance);
		
		//Take the user input for the car and assign the variables
		System.out.println("Finally, enter a car:");
		System.out.println("What's the make?");
		make = scanner.nextLine();
		
		System.out.println("How many cylinders? (Please enter a number)");
		do{
			cylinders = -1;
		try {
			cylinders = scanner.nextInt();
			scanner.nextLine();
			} catch (Exception e) {
				System.out.println("Please enter a valid number.");
				scanner.nextLine();
			}
		}while(cylinders <= 0);
		
		System.out.println("What transmission? (Manual or Auto)");
		transmission = scanner.nextLine();
		
		System.out.println("What color?");
		color = scanner.nextLine();
		
		System.out.println("How many doors?");
		do{
			bool = true;
		try {
			doors = scanner.nextInt();
			scanner.nextLine();
			bool = false;
		}catch (Exception e) {
			System.out.println("Please enter a valid number.");
			scanner.nextLine();
			}
		}while(bool);
		
		System.out.println("How many MPG?");
		do{
			bool = true;
		try {
			mpg = scanner.nextInt();
			scanner.nextLine();
			bool = false;
		} catch (Exception e) {
			System.out.println("Please enter a valid number.");
			scanner.nextLine();
			}
		}while(bool);
		
		//Create the car object
		rnoorzayCar newCar = new rnoorzayCar(make, transmission, color, cylinders, doors, mpg);
		
		//Print out the auto, truck and car
		System.out.println("Alright, Greasy Gus is selling the following vehicles you've entered:\n");
		System.out.println(newAuto.printInfo() + " automobile.\n");
		System.out.println(newTruck.printInfo() + "\n");
		System.out.println(newCar.printInfo() + "\n");
		
		//Exit the program
		System.exit(0);	
	}
}
