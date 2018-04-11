﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OrderRestaurant.Models
{
	public class OrderRestaurantDb : DbContext
	{
		public OrderRestaurantDb() : base("name=DefaultConnection") 
		{
			
		}

		public DbSet<Restaurant> Restaurants { get; set; }
		public DbSet<RestaurantReview> Reviews { get; set; }
	}
}