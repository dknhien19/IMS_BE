﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model;

public class ResultModel
{
    public string ErrorMessage { get; set; }
    public object Data { get; set; }
    public bool Succeed { get; set; }
    public int Code { get; set; }
}
