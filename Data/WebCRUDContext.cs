#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bronzetti.christian._5H.WebCRUD.Models;

namespace bronzetti.christian._5H
{
    public class WebCRUDContext : DbContext
    {
        public WebCRUDContext (DbContextOptions<WebCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<bronzetti.christian._5H.WebCRUD.Models.Movie> Movie { get; set; }
    }
}
