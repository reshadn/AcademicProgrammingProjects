
public class P {
	static int pressureGauge = 0;
	static final int safeLimit = 20;
	
	public static void main(String[] args){
		Pressure P1[] = new Pressure[10];
		for(int i = 0; i < 10; i++){
			P1[i] = new Pressure();
			P1[i].start();
		}
		
		try{
			for(int i=0; i<10; i++){
				P1[i].join();
			} 
		}catch(Exception e){}
		System.out.println("Guage reads " + pressureGauge + ", safe limit is 20.");	
		
	}
}
