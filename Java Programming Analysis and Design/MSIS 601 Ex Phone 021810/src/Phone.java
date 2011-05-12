
public class Phone {
	

	public static void main(String[] args) {
		String numbers[][] = {{"Tom", "555-3232"}, {"Mary", "555-1212"}, 
		{"John", "555-1313"}, {"Ken", "555-1234"}};
		int i;
		
		if (args.length !=1){
			System.out.println("Usage: Java Phone <name>");
		} else {
			for(i=0; i<numbers.length; i++){
				if(numbers[i][0].equals(args[0])){
					System.out.println(numbers[i][0] + ":" + numbers[1][1]);
					break;
				}
					
			}
		
		if(i == numbers.length){
			System.out.println("Name not found.");
		}

	}

}
