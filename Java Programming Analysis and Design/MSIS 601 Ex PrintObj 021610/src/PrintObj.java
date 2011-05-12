
public class PrintObj {
	public final static int NumOfTests = 2;
	String name;
	int age;
	String courseGrade;
	
	public PrintObj(String studentName, int sAge, String sGrade)
	{
		name = studentName;
		age = sAge;
		courseGrade = sGrade;
	}
	
	public PrintObj(String sName)
	{
		name = sName;
	}
	
	// if this method is commented out then the system will print out the memory address
	public String toString()
	{
		return name;
	}

	public static void main(String[] args) {
		PrintObj aStudent;
		aStudent = new PrintObj("Ghiassi", 25, "A-");
		System.out.println("Testing... " + aStudent);
		System.out.println("Testing... " + aStudent.toString()); 
		//identical to previous statement since the default println will call toString() of the object
		
		// in order to print all the variables
		System.out.println("Testing... " + aStudent.name + aStudent.age + aStudent.courseGrade);
	}

}
