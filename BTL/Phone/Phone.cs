using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    class Phone
    {
        private string _sPhoneID;
        private string _sBrandID;
        private string _sPhoneModel;
        private int _iQuantity;
        private int _iPrice;

        public Phone()
        {

        }

        public Phone(string sPhoneID, string sBrandID, string sPhoneModel, int iQuantity, int iPrice)
        {
            _sPhoneID = sPhoneID;
            _sBrandID = sBrandID;
            _sPhoneModel = sPhoneModel;
            _iQuantity = iQuantity;
            _iPrice = iPrice;
        }

        public string SPhoneID { get => _sPhoneID; set => _sPhoneID = value; }
        public string SBrandID { get => _sBrandID; set => _sBrandID = value; }
        public string SPhoneModel { get => _sPhoneModel; set => _sPhoneModel = value; }
        public int IQuantity { get => _iQuantity; set => _iQuantity = value; }
        public int IPrice { get => _iPrice; set => _iPrice = value; }
    }
}
