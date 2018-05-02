using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullNetLibrary
{
  public class Person
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public string ToJson()
    {
      return JsonConvert.SerializeObject(this);
    }
  }
}
