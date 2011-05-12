import java.io.*;

public class PingPong extends Thread{
	String word;
	int delay;
	
	PingPong(String whatToSay, int delayTime){
		word = whatToSay;
		delay = delayTime;
	}
	
	public void run(){
		try{
			for (;;){
				System.out.println(word + " ");
				sleep(delay);
			} 
			
		} catch(InterruptedException e){
				return;
		}
	}
	
	public static void main (String[] args){
		new PingPong("ping", 33).start();
		new PingPong("Pong", 100).start();
		new PingPong("It's just a game ", 200).start();
		}
}
