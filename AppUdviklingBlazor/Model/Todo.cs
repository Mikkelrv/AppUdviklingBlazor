namespace AppUdviklingBlazor.Model
{
	public class ToDo : IComparable<ToDo>
	{
        public string Title { get; set; }
        public bool isDone { get; set; }


		
		public int CompareTo(ToDo other)
		{
			if (other == null) return 1; 
			return this.isDone.CompareTo(other.isDone);
		}

	
	}
}
