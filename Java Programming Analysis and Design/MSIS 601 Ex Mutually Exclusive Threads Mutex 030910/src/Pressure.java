
public class Pressure extends Thread {
	//"static synchronized" will create a locking mechanism so that multiple threads cannot access at the same time
	// synchronized does not have to be static only
	//static synchronized 
	void RaisePressure(){
		if(P.pressureGauge < P.safeLimit - 15){
			try{
				sleep(100);
			}catch(Exception e){
				P.pressureGauge += 15;
			}
		}else;
	}
	
	public void run(){
		RaisePressure();
	}
}
