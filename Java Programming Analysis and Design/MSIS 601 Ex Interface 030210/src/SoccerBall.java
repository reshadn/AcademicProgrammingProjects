
public class SoccerBall extends SportsBall implements Inflatable, Kickable {
	public void inflate(){
		System.out.println("Inflate a soccerball.");
	}
	
	public void kick(){
		System.out.println("Kicking a soccerball.");
	}
	
	public static void g1(Inflatable x){
		x.inflate();
	}
	
	public static void g2(Kickable y){
		y.kick();
	}
	
	public static void g3(SportsBall z){
		z.manufacture();
	}
	
	public static void main(String[] s){
		SoccerBall ball = new SoccerBall();
		ball.inflate();
		ball.kick();
		ball.manufacture();
		
		g1(ball);
		g2(ball);
		g3(ball);
		
	}

}
