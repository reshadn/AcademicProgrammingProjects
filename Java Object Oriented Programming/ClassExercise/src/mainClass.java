
//ListJExample

class t1{
	int j = 10;
}

class t2 extends t1{
	//int j = 20
}

class t3 extends t2{
	int j = 30;
}

class t4 extends t3{
	int j=40;
	
	void listJs(){
		System.out.println("Super j = " + super.j);
		System.out.println("This j = " + this.j);
		System.out.println("t2 j =  " + ((t2)this).j);
	}
}

public class mainClass {
	static public void main (String[] args){
		 t4 ref4 = new t4();
		 
		 ref4.j = 100;
		 ref4.listJs();
		 
		 //t3 ref3;
		 
		 //ref3 = ref4;
		 //ref3.j = 100;
		 
		 //ref4.listJs();
	}
}
