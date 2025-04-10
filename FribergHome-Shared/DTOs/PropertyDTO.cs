using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FribergHome_Shared.DTOs
{
	public class PropertyDTO
	{
		public int Id { get; set; }

		[DataType(DataType.Currency)]
		public decimal ListingPrice { get; set; }

		public decimal LivingSpace { get; set; }

		public decimal SecondaryArea { get; set; }

		public decimal LotSize { get; set; }
		public string Description { get; set; }
		public int NumberOfRooms { get; set; }

		[DataType(DataType.Currency)]
		public decimal MonthlyFee { get; set; }

		[DataType(DataType.Currency)]
		public decimal OperationalCostPerYear { get; set; }
		public int YearBuilt { get; set; }
		public PropertyType PropertyType { get; set; }
	}
}
