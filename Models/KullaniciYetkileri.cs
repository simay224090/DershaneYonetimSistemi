using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DershaneYonetimSistemi.Models
{
    public class KullaniciYetkileri
    {
        public bool CanRead { get; set; }
        public bool CanInsert { get; set; }
        public bool CanDelete { get; set; }
        public bool CanUpdate { get; set; }
    }
}
