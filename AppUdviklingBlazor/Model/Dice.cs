namespace AppUdviklingBlazor.Model
{
	public class Dice
	{
		Random _r = new Random();
		public int Eyes { get; set; } = 1;

		public void Roll() => Eyes = _r.Next(1,6);


    }
}
