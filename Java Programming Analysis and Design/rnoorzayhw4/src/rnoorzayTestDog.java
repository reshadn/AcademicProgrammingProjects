/**
 *
 * @author Reshad Noorzay
 * Course  MSIS 601 OOP Analysis and Design
 * HW 4 - 2/25/10
 */

import java.util.Scanner;

public class rnoorzayTestDog {
	
	//Main method - entry point for program
	public static void main(String[] args) {
		//declare variables
		int holdSelection = -1;	
		boolean bool = true;

		
		//create an array to hold 20 objects
		rnoorzayDog[] arrayOfDogs = new rnoorzayDog[20];
		
		//initialize Scanner to read input
		Scanner scanner = new Scanner(System.in);
		
		while(bool){
			//Default system menu for JVHS to display options
			System.out.println("Welcome to the Java Valley Humane Society! What would you like to do?\n" 
				+ "1. Admit a new dog (description Unknown).\n"
				+ "2. Admit a new dog (description known).\n"
				+ "3. Display information about a particular dog.\n"
				+ "4. Adopt a dog.\n"
				+ "5. Euthanize a dog.\n"
				+ "6. Display information about the JVHS.\n"
				+ "7. Exit\n"
				+ "Selection:");
		
			//Read user input and assign to variable
			try {
				holdSelection = scanner.nextInt();
			}
			catch(Exception e)
			{
				System.out.println("Invalid entry! Please enter a number from 1-7.");
				scanner.nextLine();
			}

			int holdCheck;
			switch(holdSelection){
				//Create Dog1 with no information
				case 1: 
					rnoorzayDog dogNewUnknown = new rnoorzayDog();
					arrayOfDogs[dogNewUnknown.getDogID()] = dogNewUnknown;
					break;
					
				//Create dog with known initial values
				case 2: 
					System.out.println("Please enter the dog's name: ");
					String holdDogName = scanner.next();
					
					System.out.println("Please enter the dog's color: ");
					String holdDogColor = scanner.next();
					
					System.out.println("Please enter the dog's breed: ");
					String holdDogBreed = scanner.next();
					
					System.out.println("Please enter the dog's disposition: ");
					String holdDogDisposition = scanner.next();
					
					System.out.println("Please enter the dog's weight: ");
					int holdDogWeight= -1;
					while(holdDogWeight <= 0){
					try{
						holdDogWeight = scanner.nextInt();
						if (holdDogWeight <= 0) {
								System.out.println("Please enter a weight greater than 0.");
							}
						} catch (Exception e){
							System.out.println("Invalid entry! Please enter a number for the dog's weight.");
							scanner.nextLine();
						}
					}
					
					System.out.println("Please enter the dog's age: ");
					int holdDogAge = -1;
					while(holdDogAge <= 0){
						try{
							holdDogAge = scanner.nextInt();
							if(holdDogAge <= 0){
								System.out.println("Please enter a weight greater than 0.");
							}
						} catch(Exception e){
							System.out.println("Invalid entry! Please enter a number for the dog's age.");
							scanner.nextLine();
						}
					}
					
					rnoorzayDog dogNewKnown = new rnoorzayDog(holdDogWeight, holdDogAge, holdDogName, holdDogColor, holdDogBreed, holdDogDisposition);
					arrayOfDogs[dogNewKnown.getDogID()] = dogNewKnown;
					break;
					
				//Call method to print dog information
				case 3: 
					System.out.println("Please enter the ID number of the dog you wish to display: ");
					try{
					holdCheck = scanner.nextInt();
					if (holdCheck > 0 && holdCheck <= rnoorzayDog.getDogCurrentHoused()) {
						int holdDogID = holdCheck;
						arrayOfDogs[holdDogID].displayDogInfo();
						break;
					} else{
						System.out.println("Sorry this Dog ID does not exist. \n");
						break;
					}
					}catch(Exception e){
						System.out.println("Invalid entry! Please enter number for Dog ID.");
						scanner.nextLine();
					}
					
				//Adopt a dog option
				case 4: 
					System.out.println("Please enter the ID number of the dog you wish to adopt: ");
					try{
					holdCheck = scanner.nextInt();
					if (holdCheck > 0 && holdCheck <= rnoorzayDog.getDogCurrentHoused()) {
						int idNumberAdopt = holdCheck;
						arrayOfDogs[idNumberAdopt].adoptDog();
						break;
					} else{
						System.out.println("Sorry this Dog ID does not exist. \n");
						break;
					}
					}catch(Exception e){
						System.out.println("Invalid entry! Please enter number for Dog ID.");
						scanner.nextLine();
					}
					
				//Euthanize a dog option
				case 5:
					System.out.println("Please enter the ID number of the dog you wish to euthanize: ");
					try{
					holdCheck = scanner.nextInt();
					if (holdCheck > 0 && holdCheck <= rnoorzayDog.getDogCurrentHoused()) {
						int idNumberEuth = holdCheck;
						arrayOfDogs[idNumberEuth].euthanizeDog();	
						break;
					} else{
						System.out.println("Sorry this Dog ID does not exist. \n");
						break;
					}
					}catch(Exception e){
						System.out.println("Invalid entry! Please enter number for Dog ID.");
						scanner.nextLine();
					}
				
				//Call method to display JVHS information
				case 6: 
					rnoorzayDog.displayJVHSInfo();
					break;
					
				//Exit program
				case 7: 
					System.out.println("Goodbye!");
					System.exit(0);
			}	
		}	
	}
}
