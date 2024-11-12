using Pool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool
{
    internal class ConnectDb
    {
        public static PoolEntities Connect { get; set; } = new PoolEntities();
    }
}
