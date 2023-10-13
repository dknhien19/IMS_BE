using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class CompanyType : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual List<Customer> Customer { get; set; }
}
