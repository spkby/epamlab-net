using Restaurant.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Restaurant.DBContent
{
    public class DBRestaurantInit : DropCreateDatabaseIfModelChanges<DBRestaurant>
    {
        protected override void Seed(DBRestaurant context)
        {
            var dishes = new List<Dish>
            {
                new Dish {DishId = 1, Dishname = "Appetizer1", Desc = "Appetizer", Price = 1000, Course = 0},
                new Dish {DishId = 2, Dishname = "Appetizer2", Desc = "Appetizer", Price = 1000, Course = 0},

                new Dish {DishId = 3, Dishname = "Salads1", Desc = "Salads", Price = 1000, Course = 1},
                new Dish {DishId = 4, Dishname = "Salads2", Desc = "Salads", Price = 1000, Course = 1},

                new Dish {DishId = 5, Dishname = "Tapas1", Desc = "Tapas", Price = 1000, Course = 2},
                new Dish {DishId = 6, Dishname = "Tapas2", Desc = "Tapas", Price = 1000, Course = 2},

                new Dish {DishId = 7, Dishname = "Entrees1", Desc = "Entrees", Price = 1000, Course = 3},
                new Dish {DishId = 8, Dishname = "Entrees1", Desc = "Entrees", Price = 1000, Course = 3},

                new Dish {DishId = 9, Dishname = "Beverages1", Desc = "Beverages", Price = 1000, Course = 4},
                new Dish {DishId = 10, Dishname = "Beverages2", Desc = "Beverages", Price = 1000, Course = 4},
            };

            dishes.ForEach(d => context.Dishes.Add(d));

            var accounts = new List<Account>
            {
                new Account {AccountId = 1, Login = "admin", Password = "a01234"}
            };

            accounts.ForEach(a => context.Accounts.Add(a));

            context.SaveChanges();
        }
    }
}