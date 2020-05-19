using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_301041366
{
    public static class FacultyIDService
    {
        private static int lastId;
        public static int GetNewId()
        {
            return ++lastId;
        }
    }
}
