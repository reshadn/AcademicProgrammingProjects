/**
 *
 * @author Reshad Noorzay
 * Course  MSIS 601 OOP Analysis and Design
 * HW 2


import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class rnoorzayhw2 {
	
	 public void sortIntArray() throws IOException {
		 	//declare an array of integers and allocate space for 6 elements
	        int[] arrayToSort = new int[6];
	        // String variables to hold the initial string from user
	        String s1, s2, s3, s4, s5, s6;
	        
	        BufferedReader inputReader = new BufferedReader 
			(new InputStreamReader(System.in));
	        System.out.println("Input 1:");
	        s1 = inputReader.readLine();
	        arrayToSort[0] =  Integer.parseInt(s1);
	        
	        BufferedReader inputReader2 = new BufferedReader 
			(new InputStreamReader(System.in));	        
	        System.out.println("Input 2:");
	        s2 = inputReader2.readLine();
	        arrayToSort[1] =  Integer.parseInt(s2);
	        
	        BufferedReader inputReader3 = new BufferedReader 
			(new InputStreamReader(System.in));	
	        System.out.println("Input 3:");
	        s3 = inputReader3.readLine();
	        arrayToSort[2] =  Integer.parseInt(s3);
	        
	        BufferedReader inputReader4 = new BufferedReader 
			(new InputStreamReader(System.in));	   
	        System.out.println("Input 4:");
	        s4 = inputReader4.readLine();
	        arrayToSort[3] =  Integer.parseInt(s4);
	        
	        BufferedReader inputReader5 = new BufferedReader 
			(new InputStreamReader(System.in));	        
	        System.out.println("Input 5:");
	        s5 = inputReader5.readLine();
	        arrayToSort[4] =  Integer.parseInt(s5);
	        
	        BufferedReader inputReader6 = new BufferedReader 
			(new InputStreamReader(System.in));        
	        System.out.println("Input 6:");
	        s6 = inputReader6.readLine();
	        arrayToSort[5] =  Integer.parseInt(s6);
	        
	        Arrays.sort(arrayToSort);
	        
	        System.out.println("\n" + "Integer array sorted in ascending order:");
	        
	        for (int i = 0; i < arrayToSort.length; i++)
	            System.out.println(arrayToSort[i]);
	 }
	 
	 public static void main(String[] args) throws IOException {
		 rnoorzayhw2 rn2 = new rnoorzayhw2();
		 rn2.sortIntArray();
	 }
}
 */