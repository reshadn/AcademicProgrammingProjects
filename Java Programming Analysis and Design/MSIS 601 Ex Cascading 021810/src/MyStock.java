// Using cascading with dot operations

public class MyStock {
	
	private int stockNumber;
	private float price;
	
	public MyStock setStockNumber(int stockNumber)
	{
		this.stockNumber = stockNumber;
		return this;
	}
	
	public MyStock setPrice(float price)
	{
		this.price = price;
		return this;
	}
	
	public int getStockNumber()
	{
		return this.stockNumber;
	}
	
	public float getPrice()
	{
		return this.price;
	}

	public static void main(String[] args) {
		MyStock x = new MyStock(), y = new MyStock();
		//cascading - first x.setStockNumber then return object x
		// then x.setPrice
		x.setStockNumber(1235693).setPrice(123.34F);
		y.setStockNumber(1234833).setPrice(11.57F);
		
		System.out.println(x.getStockNumber() + " " + x.getPrice());
		System.out.println(y.getStockNumber() + " " + y.getPrice());
	}

}
