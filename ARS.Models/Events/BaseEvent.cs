﻿using ARS.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Models.Events
{
    public class BaseEvent
    {

        public DateTime TimeStamp { get; set; }

        public EntityStatus Status { get; set; }

    }
}
