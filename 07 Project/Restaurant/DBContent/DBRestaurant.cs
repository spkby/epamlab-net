using System;
using System.Data.Entity;
using Restaurant.Models;

namespace Restaurant.DBContent
{
    public class DBRestaurant : DbContext
    {
        public DBRestaurant() : base(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
            AppDomain.CurrentDomain.GetData("DataDirectory").ToString() +
            "\\Database1.mdf;Integrated Security=True")
        {
        }

        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
    }
}
