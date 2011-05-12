class Shape {
	void draw() {System.out.println("I'm just a shape\n");}			
}

class Circle extends Shape {
	void draw() {
		System.out.println("I just drew a circle!\n");
	}
}

class Rect extends Shape {}

class Square extends Rect {
	void draw() {
		System.out.println("I just drew a square!\n");
	}
}

class Triangle extends Shape {
	void draw() {
		System.out.println("I just drew a triangle!\n");
	}
}

class Trapezoid extends Shape {
	void draw() {
		System.out.println("I just drew a trapezoid!\n");
	}
}

public class MyShapes1 {
	public static void main(String[] args) {
		Shape[] shapeArray = new Shape[5];
		
		shapeArray[0] = new Circle();
		shapeArray[1] = new Square();
		shapeArray[2] = new Triangle();
		shapeArray[3] = new Trapezoid();
		shapeArray[4] = new Rect();
		
		for (int i=0; i < shapeArray.length; i++) {
			shapeArray[i].draw();
		}

	}

}
