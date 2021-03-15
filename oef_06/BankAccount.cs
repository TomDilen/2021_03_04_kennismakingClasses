
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_06
{
    public enum BankAccountState
    {
        OK,
        Blocked,
    }
    class BankAccount
    {
        public BankAccountState AccountState { get; private set; } = BankAccountState.OK;
        //-------------------------------------------------------
        private string _name = "unknow_Name";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //------------------------------------------------------ !! normaal een decimal ipv int !!
        private int _saldo = 0;
        //public int Saldo
        //{
        //    get { return _saldo; }
        //    private set { _saldo = value; }
        //}
        //------------------------------------------------------
        private string _bankAccountNumber = "unknow_BankNumber"; 
        public string BankAccountNumber
        {
            get { return _bankAccountNumber; }
            set { _bankAccountNumber = value; }
        }
        //------------------------------------------------------

        //=======================================================================================
        /// <summary>
        /// returns -1 if the account is blocked, else the withdrawn value 
        /// </summary>
        public int WithDrawFunds(int aValue) //geld afhaling
        {
            if (AccountState == BankAccountState.Blocked)
            {
                return -1;
            }
            if (aValue > _saldo)
            {
                int terug = _saldo;
                _saldo = 0;
                return terug;
            }
            else
            {
                _saldo -= aValue;
                return aValue;
            }
        }

        //-------------------------------------------------------------------------
        /// <summary>
        /// return -1 if the account is blocked, else the new saldo
        /// </summary>
        public int PayInFunds(int aValue)
        {
            if(AccountState == BankAccountState.Blocked)
            {
                return -1;
            }
            else { 
                _saldo += aValue;
                return _saldo;
            }
        }
        //-------------------------------------------------------------------------
        public int GetBalance()
        {
            return _saldo;
        }
        //-------------------------------------------------------------------------
        public void ChangeState(BankAccountState aBankAcountState)
        {
            AccountState = aBankAcountState;
        }
        //-------------------------------------------------------------------------

        public override string ToString()
        {
            return $"{Name} with nr {BankAccountNumber} has a saldo of" +
               $" {_saldo},   the state of the account is {AccountState.ToString()}";
        }
    }
}
