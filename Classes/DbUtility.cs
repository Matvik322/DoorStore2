using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorStoreV2.Classes
{
    public class DbUtility
    {
        public static string ConnectionString { get; } =
            "server = localhost; user=root; password=anezer200;database=doorstore;";
    }
}
