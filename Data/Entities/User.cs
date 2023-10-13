using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

public class User : IdentityUser<Guid>
{
    [Column(TypeName = "varchar(1000)")]
    public string Fullname { get; set; }
    public string Address { get; set; }
    public bool IsDeleted { get; set; }
    public int CurrenNoticeCount { get; set; } = 0;

    public virtual ICollection<UserRole> UserRoles { get; set; }
}
