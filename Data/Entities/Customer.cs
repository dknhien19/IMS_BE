using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;

public class Customer : BaseEntity
{
    public string CompanyName { get; set; }
    public string TaxNumber { get; set; }
    public Guid UserId { get; set; }
    public virtual User User { get; set; }

    public int CompanyTypeId { get; set; }
    public virtual CompanyType CompanyType { get; set; }
}