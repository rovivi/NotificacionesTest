using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificacionesTest
{
    using Microsoft.EntityFrameworkCore;
    using NotificacionesTest.Models;

    namespace TodoApi.Models
    {
        public class TodoContext : DbContext
        {
            public TodoContext(DbContextOptions<TodoContext> options)
                : base(options)
            {
            }

            public DbSet<Mail> TodoItems { get; set; }
        }
    }
}
