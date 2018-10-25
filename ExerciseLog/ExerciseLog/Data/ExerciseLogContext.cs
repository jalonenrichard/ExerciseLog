using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExerciseLog.Models
{
    public class ExerciseLogContext : DbContext
    {
        public ExerciseLogContext (DbContextOptions<ExerciseLogContext> options)
            : base(options)
        {
        }

        public DbSet<ExerciseLog.Models.Exercise> Exercise { get; set; }
    }
}
