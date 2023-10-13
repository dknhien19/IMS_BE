using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;

public class IP : BaseEntity
{
    public string Octet1 { get; set; }
    public string Octet2 { get; set; }
    public string Octet3 { get; set; }
    public string Octet4 { get; set; }
    public string Class { get; set; }
}
