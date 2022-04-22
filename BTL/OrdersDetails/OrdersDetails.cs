using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.OrdersDetails
{
    class OrdersDetails
    {
        private int _iOrdersDetailID;
        private int _iOrdersID;
        private string _sPhoneID;
        private int _iQuantity;
        private int _iPrice;
        public OrdersDetails()
        {
        }

        public OrdersDetails(int iOrdersDetailID, int iOrdersID, string sPhoneID, int iQuantity, int iPrice)
        {
            _iOrdersDetailID = iOrdersDetailID;
            _iOrdersID = iOrdersID;
            _sPhoneID = sPhoneID;
            _iQuantity = iQuantity;
            _iPrice = iPrice;
        }

        public int IOrdersID { get => _iOrdersID; set => _iOrdersID = value; }
        public string SPhoneID { get => _sPhoneID; set => _sPhoneID = value; }
        public int IQuantity { get => _iQuantity; set => _iQuantity = value; }
        public int IPrice { get => _iPrice; set => _iPrice = value; }
        public int IOrdersDetailID { get => _iOrdersDetailID; set => _iOrdersDetailID = value; }
    }
}
