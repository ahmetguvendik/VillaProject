using System;
namespace Domain.Entities
{
	public class Room : BaseEntity
	{
		public string Title { get; set; }
		public string SubTitle { get; set; }
		public double Price { get; set; }
		public int BedroomCount { get; set; }
        public int BathroomCount { get; set; }
		public int AreaCount { get; set; }
		public int FloorCount { get; set; }
		public int ParkingCount { get; set; }
	}
}

	