using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;

public class Server : BaseEntity
{
    public string SerialNumber { get; set; }
    public int DNS { get; set; }
    public string Model { get; set; }

    public int DeviceId { get; set; }
    public virtual Device Device { get; set; }
}
