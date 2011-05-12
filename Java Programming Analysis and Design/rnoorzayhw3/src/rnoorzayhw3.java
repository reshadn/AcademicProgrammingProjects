import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 *
 * @author Reshad Noorzay
 * Course  MSIS 601 OOP Analysis and Design
 * HW 3 - 2/11/10
 */

public class rnoorzayhw3 {

	// Method to find index of the first occurrence of z and return the value
	public String strIndexZ (String strIndex)
	{
		int indexOfZ;
		//make string lowercase to find value of index of "z"
		indexOfZ = strIndex.toLowerCase().indexOf("z");
		if (indexOfZ > -1){
		strIndex = Integer.toString(indexOfZ);
		} else {
			strIndex = "No z found.";
		}
		return strIndex;
	}

	//Method to compare strings - if same exit and if not same then concatenate
	public String compareString (String cmpStrOne, String cmpStrTwo)
	{
		//variable to hold string buffer
		String sb;
		//Compare the 2 strings and exit if they are the same
		//QUES - Not sure if we should use equals or equalsIgnoreCase
		if (cmpStrOne.equals(cmpStrTwo)){
			System.out.println("The two strings are the same. Have a nice day!");
			System.exit(0);
		}
		else {
			//initialize StringBuffer and add a space at the beginning of the second string 
			sb = new StringBuffer(cmpStrTwo).insert(0, " ").toString();
			//Print out the concatenated string
			System.out.println("The two strings are not the same. \n" + "\n"
					+ "Here is the concatenated string:\n" 
					+ cmpStrOne.concat(sb));
		}
		return cmpStrOne;
	}

/**
 * @throws IOException 
*/	
	
	public static void main(String[] args) throws IOException {
		//string variables to hold user input
		String strHoldOne;
		String strHoldTwo;
		
		// initialize buffered reader
        BufferedReader inputReader = new BufferedReader 
		(new InputStreamReader(System.in));
        
        // Request user input for string 1
		System.out.println("Please enter String 1:");
        strHoldOne = inputReader.readLine();
		//Request user input for string 2
        System.out.println("Please enter String 2:");
        strHoldTwo = inputReader.readLine();
        
        //Print out the length of each string
        System.out.println("\nThe length of String 1:\n" + strHoldOne.length() 
        		+ "\n" + "The length of String 2:\n" + strHoldTwo.length()); 
        
        //Initialize class rnoorzayhw3
        rnoorzayhw3 rn3 = new rnoorzayhw3();
        
        //Use method strIndexZ to find index of z and print
        System.out.println("Index of the letter z in String 1: \n" +
        		rn3.strIndexZ(strHoldOne));
        System.out.println("Index of the letter z in String 2: \n" 
        		+ rn3.strIndexZ(strHoldTwo) + "\n");
        
        //Use method compareString to compare strings and concatenate if not the same
        rn3.compareString(strHoldOne, strHoldTwo);
	}
}
