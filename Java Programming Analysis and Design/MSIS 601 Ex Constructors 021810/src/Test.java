// example of overloaded constructors and initializing objects from constructors
public class Test {

	private int num, den, x, y;
	
	public Test(){
		this (0,5);
	}
	
	public Test(int initNum){
		this(initNum, 7);
	}
	
/*	public Test(int initNum, int initDen){
		num = initNum;
		if(0==initDen){
			initDen = 1;
		}
		den = initDen;
	}
*/	
	public static void main(String[] args) {
		Test a = new Test();
		Test b = new Test(2);
		//Test c = new Test(3,4);
		System.out.println("a.num " + a.num + "  a.den " + a.den);
		System.out.println("b.num " + b.num + "  b.den " + b.den);
		//System.out.println("c.num " + c.num + "  c.den " + c.den);
	}

}
