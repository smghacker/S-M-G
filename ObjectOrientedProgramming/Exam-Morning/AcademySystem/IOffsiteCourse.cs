﻿using System;
using System.Linq;

namespace SoftwareAcademy
{
    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }
}