using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;

public class Device : BaseEntity
{
    public string Type { get; set; }
    public string NumberOfPort { get; set; }
    public DeviceStatus Status { get; set; }
    public int Size { get; set; }
    public int BasePower { get; set; }
}
