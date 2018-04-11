namespace OrderRestaurant.Migrations
{
	using Models;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<OrderRestaurant.Models.OrderRestaurantDb>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			ContextKey = "OrderRestaurant.Models.OrderRestaurantDb";
		}

		protected override void Seed(OrderRestaurant.Models.OrderRestaurantDb context)
		{
			context.Restaurants.AddOrUpdate(r => r.Name,
				new Restaurant { Name = "La Mar", City = "Lima", Country = "Peru" },
				new Restaurant { Name = "Nazca", City = "Bogota", Country = "Colombia" },
				new Restaurant
				{
					Name = "Gaucho",
					City = "London",
					Country = "UK",
					Reviews = 
						new List<RestaurantReview> {
							new RestaurantReview { Rating = 9, Body = "Great!", ReviewerName = "Henry" }
						}
				});

		}
	}
}
