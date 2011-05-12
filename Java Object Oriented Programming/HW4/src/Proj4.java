import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;


public class Proj4 {
	
	public static void main(String[] args) throws IOException {
		Boat[] Boats;
		char charOne;
		char charTwo;
		int i;
		BufferedReader fin = null; 
		String s = null;
		String[] strArray;
		FileWriter fout = null;
		
		try {
			fin = new BufferedReader(new FileReader("test.txt"));
		} catch (FileNotFoundException e) {
			e.printStackTrace();
			System.exit(-1);
		}
		
		try {
			s = fin.readLine();
		} catch (IOException e) {
			e.printStackTrace();
			System.exit(-1);
		}
		
		strArray = s.split(" ");
		
		Boats = new Boat[strArray.length];
		
		for(i=0; i<strArray.length; i++) {
			charOne = strArray[i].toUpperCase().charAt(0);
			charTwo = strArray[i].toUpperCase().charAt(1);
			
			if ((charOne == 'B') || (charOne == 'C') || (charOne == 'N')) {
				Boats[i] = new SailBoat();
			} else {
				Boats[i] = new RaceBoat();
			}
			
			Boats[i].setName(strArray[i]);
			
			if ((charTwo == 'A') || (charTwo == 'E')) {
				Boats[i].goFast();
			} else {
				Boats[i].goSlow();
			}
		}
		
		try {
			fout = new FileWriter("Output.txt");
		} catch (IOException e) {
			System.err.println("error creating file");
			e.printStackTrace();
		}
		
		for (i=0; i<strArray.length; i++) {
						
			Boats[i].printName(fout);
			
			Boats[i].whatIsBoatState(fout);
						
		}
		
		try {
			fin.close();
		} catch (IOException e) {
			e.printStackTrace();
		}
		try {
			fout.close();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

}
