using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Day_2.Models
{

    /*
        DataContext class represents the connection with the DB
        Will use it to access the different tables/classes
        Store and retrieve information/records

     */
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //specify which classes will be related to the DB tables
        public DbSet<Car> Cars { get; set; }

        public DbSet<Representative> Representatives { get; set; }
    }
}