using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.Staff
{
    class Staff
    {
        private int _iStaffID;
        private string _sFullName;
        private string _sAddress;
        private DateTime _dDateOfBirth;
        private string _sPhoneNumber;
        private float _fBasicSalary;
        private float _fGrant;
        public Staff()
        {
        }

        public Staff(int iStaffID, string sFullName, string sAddress, 
            DateTime dDateOfBirth, string sPhoneNumber, float fBasicSalary, float fGrant)
        {
            _iStaffID = iStaffID;
            _sFullName = sFullName;
            _sAddress = sAddress;
            _dDateOfBirth = dDateOfBirth;
            _sPhoneNumber = sPhoneNumber;
            _fBasicSalary = fBasicSalary;
            _fGrant = fGrant;
        }

        public int IStaffID { get => _iStaffID; set => _iStaffID = value; }
        public string SFullName { get => _sFullName; set => _sFullName = value; }
        public string SAddress { get => _sAddress; set => _sAddress = value; }
        public DateTime DDateOfBirth { get => _dDateOfBirth; set => _dDateOfBirth = value; }
        public string SPhoneNumber { get => _sPhoneNumber; set => _sPhoneNumber = value; }
        public float FBasicSalary { get => _fBasicSalary; set => _fBasicSalary = value; }
        public float FGrant { get => _fGrant; set => _fGrant = value; }
    }
}
