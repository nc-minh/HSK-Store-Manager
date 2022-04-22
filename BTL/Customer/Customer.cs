using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.Customer
{
    class Customer
    {
        private int _iCustomerID;
        private string _sFullName;
        private string _sAddress;
        private DateTime _dDateOfBirth;
        private string _sGender;
        private string _sPhoneNumber;
        public Customer()
        {
        }

        public Customer(int iCustomerID, string sFullName, string sAddress, 
            DateTime dDateOfBirth, string sGender, string sPhoneNumber)
        {
            _iCustomerID = iCustomerID;
            _sFullName = sFullName;
            _sAddress = sAddress;
            _dDateOfBirth = dDateOfBirth;
            _sGender = sGender;
            _sPhoneNumber = sPhoneNumber;
        }

        public int ICustomerID { get => _iCustomerID; set => _iCustomerID = value; }
        public string SFullName { get => _sFullName; set => _sFullName = value; }
        public string SAddress { get => _sAddress; set => _sAddress = value; }
        public DateTime DDateOfBirth { get => _dDateOfBirth; set => _dDateOfBirth = value; }
        public string SGender { get => _sGender; set => _sGender = value; }
        public string SPhoneNumber { get => _sPhoneNumber; set => _sPhoneNumber = value; }
    }
}
