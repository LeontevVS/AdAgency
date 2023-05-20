using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdAgency
{
    class Context
    {
        private static dbAdAgencyEntities _context;

        public static dbAdAgencyEntities GetContext()
        {
            if (_context == null)
            {
                _context = new dbAdAgencyEntities();
            }

            return _context;
        }
    }
}
