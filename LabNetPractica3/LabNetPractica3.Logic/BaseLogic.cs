﻿using LabNetPractica3.Data;
using LabNetPractica3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica3.Logic
{
    public class BaseLogic
    {

            protected readonly NorthwindContext context;

            public BaseLogic()
            {
                context = new NorthwindContext();
            }
 
    }
}
