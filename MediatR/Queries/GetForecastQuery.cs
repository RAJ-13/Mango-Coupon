namespace MediatR.Queries
{
	public class GetForecastQuery
	{
		public GetForecastQuery(string city)
		{
			this.City = city;
		}
		public string City { get; set; }
		public int Celcius { get; set; }
	}
}
