using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Restaurant.Models;

namespace Restaurant.DBContent
{
    public class DBRestaraunt : DbContext
    {

        public DBRestaraunt() : base(
            "workstation id=restaurant.mssql.somee.com;packet size=4096;user id=user;pwd=pass;" +
            "data source=restaurant.mssql.somee.com;persist security info=False;initial catalog=restaurant")
        {
        }

        /*public DBRestaraunt() : base(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
            AppDomain.CurrentDomain.GetData("DataDirectory").ToString() +
            "\\Database1.mdf;Integrated Security=True")
        {
        }*/

        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }

    }
}