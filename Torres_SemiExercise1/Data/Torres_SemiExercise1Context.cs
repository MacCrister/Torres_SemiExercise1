using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Torres_SemiExercise1.Models;

namespace Torres_SemiExercise1.Data
{
    public class Torres_SemiExercise1Context : DbContext
    {
        public Torres_SemiExercise1Context (DbContextOptions<Torres_SemiExercise1Context> options)
            : base(options)
        {
        }

        public DbSet<Torres_SemiExercise1.Models.ClientModel> ClientModel { get; set; }
    }
}
