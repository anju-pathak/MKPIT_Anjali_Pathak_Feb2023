﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emply
{
    internal class ENGG:emp
    {
        public int bonus = 800;
        public override int calsalary(int sal)
        {
            sal = bonus + sal;
            return sal;
        }
    }
}
