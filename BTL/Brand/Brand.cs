using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    class Brand
    {
        private string _sBrandID;
        private string _sBrandName;
        public Brand()
        {
        }

        public Brand(string sBrandID, string sBrandName)
        {
            _sBrandID = sBrandID;
            _sBrandName = sBrandName;
        }

        public string SBrandID { get => _sBrandID; set => _sBrandID = value; }
        public string SBrandName { get => _sBrandName; set => _sBrandName = value; }
    }
}
