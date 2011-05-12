
public class OverloadOverride {
	public static void main (String[] s){
		Subclass1 x = new Subclass1();
		x.chewGum(2.4); 	// overriding subclass method
		x.walk(180.5); 	// overloading superclass method
		x.walk(89); 		// overloading subclass method
	}
}
