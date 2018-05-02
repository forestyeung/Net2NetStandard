#if NETSTANDARD2_0
using Microsoft.EntityFrameworkCore;

namespace FullNetLibrary
{
  public class PersonContext : DbContext
  {
    public DbSet<Person> Persons { get; set; }
  }

  public class PersonFactory
  {
    public void GetPerson()
    {
      using (var db = new PersonContext())
      {

      }
    }
  }
}
#else
using System.Data.Entity;

namespace FullNetLibrary
{
  public class PersonFactory
  {
    public void GetPerson()
    {
      using (var db = new DbContext(""))
      {
      }
    }
  }
}
#endif