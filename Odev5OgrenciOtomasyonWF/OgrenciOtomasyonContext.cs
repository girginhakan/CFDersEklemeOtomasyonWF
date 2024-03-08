using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5OgrenciOtomasyonWF
{
    public class OgrenciOtomasyonContext:DbContext
    {
        public OgrenciOtomasyonContext()
        {
            
        }
       public DbSet<Ders> Dersler {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=HakanPC;Initial Catalog=OgrenciOtomasyonDb;Integrated Security=true;Encrypt=False");
        }
    }
}
