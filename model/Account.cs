using System;

namespace BankAPI.model
{
    public class Account
    {    

        public int AccountId { get; set; }
        public int CsId { get; set; }
        public string AccountType { get; set; }
        public string Balance { get; set; }
        public DateTime DateOpened { get; set; }
        public string Status { get; set; }

    }
}
