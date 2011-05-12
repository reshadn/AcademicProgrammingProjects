
public class Counted {
	private int value; 
	private static int count = 0;
	
	public Counted()
	{
		++count;
		System.out.println("Creating a Counted Obj");
		value = -1;
	}
	
	public void finalize () {
	-- count;
	System.out.println("Destroying counted obj");
	}
	
	public static int getCount()
	{
		return count;
	}
	
	public Counted setValue(int newValue)
	{
		value = newValue;
		return this;
	}
	
	public int getValue()
	{
		return value;
	}

	public static void main(String[] args) {	
		Counted a = new Counted();
		Counted b = new Counted();
		Counted c = new Counted();
		System.out.println("There are " + Counted.getCount() + " Counted Objs");
		// Can also use Counted.count which is a private static variable in the same class.
		
		Counted d = new Counted();
		System.out.println("There are " + Counted.getCount() + " Counted Objs");
		System.out.println("Count " + count);
		a = null;
		System.gc(); //start garbage collector
		System.runFinalization(); //
		System.out.println("There are " + a.getCount() + " Counted Objs");

	}
}


