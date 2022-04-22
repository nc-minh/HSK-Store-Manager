using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.Orders
{
    class Orders
    {
        private int _iOrdersID;
        private int _iCustomerID;
        private int _iStaffID;
        private DateTime _dOrdersDate;
        public Orders()
        {
        }

        public Orders(int iOrdersID, int iCustomerID, int iStaffID, DateTime dOrdersDate)
        {
            _iOrdersID = iOrdersID;
            _iCustomerID = iCustomerID;
            _iStaffID = iStaffID;
            _dOrdersDate = dOrdersDate;
        }

        public int IOrdersID { get => _iOrdersID; set => _iOrdersID = value; }
        public int ICustomerID { get => _iCustomerID; set => _iCustomerID = value; }
        public int IStaffID { get => _iStaffID; set => _iStaffID = value; }
        public DateTime DOrdersDate { get => _dOrdersDate; set => _dOrdersDate = value; }
    }
}
