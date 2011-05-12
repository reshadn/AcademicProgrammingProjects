public class Proj2 {
	public static void main(String args[]){

		String str; 
		
		for (int i=0; i < args.length; i++){
			Boat myBoat;
		
			
			myBoat = new Boat();
			
			myBoat.setName(args[i]);
			myBoat.printName();
			
			str = args[i].toUpperCase();
			char c = str.charAt(0);
			
	    	if (c == 'B' || c == 'C' || c == 'N') {
	    		myBoat.goFast();
	    	}
	    	else {
	    		myBoat.goSlow();
	    	}
	    	myBoat.whereIsTheSail();	
		}
	}
}
