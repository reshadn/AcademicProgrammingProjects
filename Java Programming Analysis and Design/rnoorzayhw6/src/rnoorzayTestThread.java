
public class rnoorzayTestThread {
	
	public static void main(String[] args){
		rnoorzayThread thread1 = new rnoorzayThread("Moe", 15);
		rnoorzayThread thread2 = new rnoorzayThread("Larry", 15);
		rnoorzayThread thread3 = new rnoorzayThread("Curly", 15);
		
		thread1.start();
		thread2.start();
		thread3.start();
	}

}
