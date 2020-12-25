using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MurmanRybApp.Entities;

namespace MurmanRybApp.Classes
{
    public class DBConnection
    {
        public static MurmanRybEntities Connection = new MurmanRybEntities();

        static public string User;

        static public string Role;
    }
}
