/**
 *
 * @author Reshad Noorzay
 * Course  MSIS 601 OOP Analysis and Design
 * HW 1  2/11/10
 */

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class rnoorzayhw1resubmit {

    /**
     * @param args the command line arguments
     * @throws IOException
     */
    public static void main(String[] args) throws IOException {
        // String variable to hold user input
        String sInput;
        
        //Initialize the buffered reader
        BufferedReader inputReader = new BufferedReader
                (new InputStreamReader (System.in));

        // Promtpt user to enter their name
        System.out.println("Hi, what's your name?");

        // Read the user input
        sInput = inputReader.readLine();

        // Continue to print the name and request a new name until the user enters "exit"
        while (!sInput.toUpperCase().equals("EXIT")) {
            // Print out the user input and sentence
            System.out.println("\n" + sInput + ", it's so nice to meet you!" + "\n");

            // Promtpt user to enter their name
            System.out.println("Hi, what's your name?");

            // Read the user input
            sInput = inputReader.readLine();
        }
    }
}