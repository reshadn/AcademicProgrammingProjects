
class Point {
	int x,y;
	
	Point () {}
	Point (int x, int y) {
		//this.x is the instance variable in the class
		// x is the local variable
		this.x = x;
		this.y = y;
		System.out.println("I'm in the Point constructor!\n x and y are now initialized! \n");
	}
}

class ColoredPoint extends Point {
	//"final" keyword means - after variable is given a value it cannot be changed
	static final int WHITE = 0, BLACK = 1;
	int color;
	
	ColoredPoint(){
		
	}
	//overloaded constructors
	ColoredPoint(int x, int y) {
		this(x, y, WHITE);
		System.out.println("I'm in the first ColoredPoint constructor!\n " +
				"I just got back from calling the second constructor in ColoredPoint\n");	
	}
	
	ColoredPoint(int x, int y, int color) {
		// "super" keyword will go to the immediate parent class (based on use of "extends" keyword)
		super(x,y);
		this.color = color;
		System.out.println("I'm in the second ColoredPoint constructor!\n " +
		"I just got back from calling super class constructor! The color is now set\n");
	}
}

public class MakePoint {
	static public void main(String[] args) {
		//ColoredPoint cp = new ColoredPoint(4,3);
		ColoredPoint cp = new ColoredPoint();
		System.out.println("I'm back in main() and the object cp is now fully initialized!\n");
	}
}
