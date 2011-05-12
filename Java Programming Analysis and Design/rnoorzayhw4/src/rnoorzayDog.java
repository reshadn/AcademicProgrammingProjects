/**
 *
 * @author Reshad Noorzay
 * Course  MSIS 601 OOP Analysis and Design
 * HW 4 - 2/25/10
 */

public class rnoorzayDog {
	//dog attributes
	private int dogID;
	private int dogWeight;
	private int dogAge;
	private String dogName;
	private String dogColor;
	private String dogBreed;
	private String dogDisposition;
	private boolean dogEuth;
	private boolean dogAdopt;
	
	//static variables - initialized
	private static int dogCurrentHoused = 0;
	private static int dogHistHoused = 0;
	private static int dogJoinedFamily = 0;
	
	//Get methods for static variables	
	public static int getDogCurrentHoused() {
		return dogCurrentHoused;
	}
	
	public static int getDogHistHoused() {
		return dogHistHoused;
	}
	
	public static int getDogJoinedFamily() {
		return dogJoinedFamily;
	}

	//creating setter and getter methods for each private field
	//no setDogID because dogID is set by the program
	public int getDogID() {
		return dogID;
	}
	
	public void setDogWeight(int dogWeight){
		this.dogWeight = dogWeight;
	}
	
	public int getDogWeight(){
		return dogWeight;
	}

	public void setDogAge(int dogAge) {
		this.dogAge = dogAge;
	}

	public int getDogAge() {
		return dogAge;
	}

	public void setDogName(String dogName) {
		this.dogName = dogName;
	}

	public String getDogName() {
		return dogName;
	}

	public void setDogColor(String dogColor) {
		this.dogColor = dogColor;
	}

	public String getDogColor() {
		return dogColor;
	}
	
	public void setDogBreed(String dogBreed) {
		this.dogBreed = dogBreed;
	}

	public String getDogBreed() {
		return dogBreed;
	}

	public void setDogDisposition(String dogDisposition) {
		this.dogDisposition = dogDisposition;
	}

	public String getDogDisposition() {
		return dogDisposition;
	}

	public void setDogEuth(boolean dogEuth) {
		this.dogEuth = dogEuth;
	}

	public boolean isDogEuth() {
		return dogEuth;
	}

	public void setDogAdopt(boolean dogAdopt) {
		this.dogAdopt = dogAdopt;
	}

	public boolean isDogAdopt() {
		return dogAdopt;
	}
	
	// Default constructor will call the main constructor and pass default values
	public rnoorzayDog(){
		this(-1, -1, "unknown", "unknown", "unknown", "unknown");
	}
	
	//Main constructor will take all the rnoorzayDog fields as parameters
	public rnoorzayDog(int dogWeight, int dogAge,
			String dogName, String dogColor, String dogBreed, 
			String dogDisposition){
		this.dogWeight = dogWeight;
		this.dogAge = dogAge;
		this.dogName = dogName;
		this.dogColor = dogColor;
		this.dogBreed = dogBreed;
		this.dogDisposition = dogDisposition;
		this.dogEuth= false;
		this.dogAdopt = false;
		dogCurrentHoused++;
		dogHistHoused++;
		this.dogID = dogHistHoused;
		
		if (dogAge <= 0){
			System.out.println("\nCongratulations, dog number " 
					+ dogID 
					+ " has been successfully entered with UNKNOWN description.\n");
		} else{
			System.out.println("\nCongratulations, dog number " 
					+ dogID 
					+ " has been successfully entered with description.\n");
		}	
	}
	
	//Function that displays dog information - no return variable
	public void displayDogInfo() {
		if (dogHistHoused == 0){
			System.out.println("Sorry there are no dogs in JVHS yet. Please create a dog first.");
		} else {
		System.out.println("\nJVHS Dog Information \n\n"
				+ "ID Number: " + dogID + "\n"
				+ "Name: " + dogName + "\n"
				+ "Color: " + dogColor + "\n"
				+ "Breed: " + dogBreed + "\n"
				+ "Disposition: " + dogDisposition + "\n"
				+ "Weight: " + dogWeight + "\n"
				+ "Age: " + dogAge + "\n"
				+ "Adopted: " + dogAdopt + "\n"
				+ "Euthanized: " + dogEuth + "\n");
		}
	}
	
	//Function that displays JVHS information
	public static void displayJVHSInfo(){
		System.out.println("Java Valley Humane Society Information"
				+ "\nJVHS is currently housing " + dogCurrentHoused + " dog(s)."
				+ "\nJVHS has historically housed " + dogHistHoused + " dog(s)."
				+ "\nJVHS has successfully joined " + dogJoinedFamily + " dog(s) with loving families.\n");
	}
	
	//Function to adopt a dog
	public boolean adoptDog(){	
		if (dogAdopt || dogEuth) {
			System.out.println("Sorry cannot adopt this dog. This dog has already been adopted or euthanized.\n");
			return false;
		} 
			dogJoinedFamily++;
			dogCurrentHoused--;
			this.dogAdopt = true;
			System.out.println("Congratulations, dog number " + this.dogID
					+ " has been successfully adopted.\n");
			return true;
	}
	//Function to euthanize a dog
	public boolean euthanizeDog(){
		if (dogAdopt || dogEuth) {
			System.out.println("Sorry cannot euthanize this dog. This dog has already been euthanized or adopted.\n");
			return false;
		} 
		dogCurrentHoused--;
		this.dogEuth = true;
		System.out.println("Dog number " 
				+ this.dogID + " has been destroyed.\n");
		return true;
	}

}
