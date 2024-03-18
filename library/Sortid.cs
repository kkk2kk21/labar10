using library;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Sortid : IComparer
    {
        public int Compare(object z, object v)
        {
            zAircraft FirstObject = z as zAircraft;
            zAircraft SecondObject = v as zAircraft;
            if (FirstObject == null && SecondObject == null) return 0;
            if (FirstObject == null) return -1;
            if (SecondObject == null) return 1;
            if (FirstObject.id.Number < SecondObject.id.Number) return -1;
            else if (FirstObject.id.Number == SecondObject.id.Number) return 0;
            return 1;
        }
    }
}
