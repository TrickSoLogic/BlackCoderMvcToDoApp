#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlackCoderMvcToDoApp.Models;

namespace BlackCoderMvcToDoApp.Data
{
    public class BlackCoderMvcToDoAppContext : DbContext
    {
        public BlackCoderMvcToDoAppContext (DbContextOptions<BlackCoderMvcToDoAppContext> options)
            : base(options)
        {
        }

        public DbSet<BlackCoderMvcToDoApp.Models.ToDoList> ToDoList { get; set; }
    }
}
