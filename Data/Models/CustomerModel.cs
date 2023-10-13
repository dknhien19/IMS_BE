using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class CustomerModel
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string Fullname { get; set; }
    public string TaxNumber { get; set; }
    public Guid UserId { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}

public class CustomerCreateModel
{
    [Required]
    public string CompanyName { get; set; }

    [Required]
    public string TaxNumber { get; set; }

    [Required]
    public string Fullname { get; set; }

    [Required]
    public string CompanyType { get; set; }

    [Required]
    public string Address { get; set; }

    [EmailAddress]
    [Required]
    public string Email { get; set; }

    [Phone]
    [Required]
    public string PhoneNumber { get; set; }
}

public class CustomerUpdateModel
{
    [Required]
    public int Id { get; set; }

    public string? CompanyName { get; set; }

    public string? TaxNumber { get; set; }

    public string? Fullname { get; set; }

    public string? Address { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    [Phone]
    public string? PhoneNumber { get; set; }
}

public class CustomerSearchModel
{
    public string? SearchValue { get; set; } = "";
}
