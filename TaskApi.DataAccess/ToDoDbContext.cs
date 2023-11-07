using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace TaskApi.DataAccess
{
    public  class ToDoDbContext:DbContext
    {
        public DbSet<ToDo>? ToDos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var ConnectingString = "Server=DESKTOP-5GE1J1T;DataBase=MyToDoDb;User Id=DESKTOP-5GE1J1T\User;PassWord=''";

            var ConnectingString = "Persist Security Info=False;Integrated Security=true;Initial Catalog=MyToDoDb;server=DESKTOP-5GE1J1T";

            optionsBuilder.UseSqlServer(ConnectingString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>().HasData(new ToDo

            {
                ID = 1,
                Title = "project start- from sql server",
                Description = "Collect the existing Doc- from sql server",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = ToDoStatus.New


            }
            );
        }
    }
}

