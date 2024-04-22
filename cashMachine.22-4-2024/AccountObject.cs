using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cashMachine._22_4_2024
{
    internal class AccountObject
    {
        private int pinCode = 6942;
        private float currentAcountValue = 420.69f;

        #region Getter
        public int CorrectPinCode //getter
        {
            get { return pinCode; }
        }

        public float currentAV //getter
        {
            get { return currentAcountValue; }
        }
        #endregion

        #region Setter
        public void AccountWithdraw(float minAcountValue)
        {
            currentAcountValue -= minAcountValue;
        }
        public void AccountDeposit(float addedAcountValue)
        {
            currentAcountValue += addedAcountValue;
        }
        #endregion

    }
}
