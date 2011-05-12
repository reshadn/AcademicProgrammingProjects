// ScopeExample

class t1 {
	int j;
	
	void m1(){
		System.out.println("Whose j? " + j);
		System.out.println("Whose j now? " + this.j);	
	}
}

class derived extends t1 {
	int j;
	void assign(int j){
		System.out.println("Local j                    - " + j);
		System.out.println("Super j (initialized to 0) - " + super.j);
		System.out.println("This j (initialized to 0) - " + this.j);
		
		super.j = j;
		this.j = j + 1;
		
		System.out.println("Local j                    - " + j);
		System.out.println("Super j                    - " + super.j);
		System.out.println("This j                     - " + this.j);
		
		((t1)this).j = j+2;
		System.out.println("Local j                    - " + j);
		System.out.println("t1 j                       - " + ((t1)this).j);
		System.out.println("This j                     - " + this.j);
		
		m1();
	}
}
public class SuperThis {
	static public void main (String[] args) {
		derived d1 = new derived();
		d1.assign(4);
	}
}
