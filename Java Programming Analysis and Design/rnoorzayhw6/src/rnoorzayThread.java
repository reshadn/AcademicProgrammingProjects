
public class rnoorzayThread extends Thread {
	//private member variables
	private String stringToPrint;
	private int times;
	
	//constructor
	public rnoorzayThread(String s, int t){
		stringToPrint = s;
		times = t;
	}
	
	//override the run method
	public void run(){
		for(int i=0; i<times; i++){
			System.out.println(stringToPrint);
		}
	}
		
	
}
