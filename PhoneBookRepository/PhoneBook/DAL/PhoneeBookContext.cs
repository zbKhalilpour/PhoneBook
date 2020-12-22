using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhoneeBookContext:DbContext
    {
        static PhoneeBookContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PhoneeBookContext>());
        }
        public DbSet<PhoneBook> PhoneBookList { get; set; }
    }
}
