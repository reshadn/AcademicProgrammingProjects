/**
 *
 * @author Reshad Noorzay
 * Course  MSIS 601 OOP Analysis and Design
 * HW 2 Resubmit 2/11/10
 */

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class rnoorzayhw2resubmit {
	
	 public void sortIntArray() throws IOException {
		 	//declare an array of integers and allocate space for 6 elements
	        int[] arrayToSort = new int[6];
	        // String variables to hold the initial string from user
	        String strHold;
	        
	        // initialize buffered reader
	        BufferedReader inputReader = new BufferedReader 
			(new InputStreamReader(System.in));
	        
	        //loop to continue requesting input from user and assigning that input to the array
	        for (int i=0; i<6; i++) {
	        	//request input from user
	        System.out.println("Input " + (i+1) + ":" );
	        //read the input and store in a string
	        strHold = inputReader.readLine();
	        //try to parse the string to an Integer
	        try {
	        	 arrayToSort[i] =  Integer.parseInt(strHold);
	        	}
	        // catch the exception if the string is not an integer
	        catch (NumberFormatException e) {
	        	//notify the user that they should enter a valid integer
	        	System.out.println("Please enter a valid integer!");
	        	//subract 1 from i in order to request the same input
	        	i--;
	        	}
	        }
	        
	        //sort the array
	        Arrays.sort(arrayToSort);
	        
	        //print out the intro to the array
	        System.out.println("\n" + "Integer array sorted in ascending order:");
	        
	        //print out the array
	        for (int i = 0; i < arrayToSort.length; i++)
	            System.out.println(arrayToSort[i]);
	 }
	 
	 public static void main(String[] args) throws IOException {
		 rnoorzayhw2resubmit rn2 = new rnoorzayhw2resubmit();
		 rn2.sortIntArray();
	 }
}
