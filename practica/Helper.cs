using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practica.Models;

namespace practica
{
    internal class Helper
    {
            private static Entities tyr_Entities;

            public static Entities GetContext()
            {
                if (tyr_Entities == null)
                {
                    tyr_Entities = new Entities();
                }
                return tyr_Entities;
            }
    }
}


