
public class HasXY extends HasX{
	private int y;
	public void setY(int inputY){
		y=inputY;
	}
	public int getY(){
		return y;
	}
	public void showY(){
		System.out.println(y);
	}
	public void showX(){
		System.out.println(getX());
	}
	
	public static void main(String[] s){
		HasXY obj = new HasXY();
		obj.setY(20);
		obj.setX(10);
		obj.showY();
		obj.showX();
	}

}
