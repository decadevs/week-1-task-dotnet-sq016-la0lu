using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SureBank.Models
{
    public class AccountInfos
    {
        public int accountId { get; set; } = 0;

        // public int Id { get; set; }
        public int AccountId { get; set; } = 0;
       // public string AccountNum { get; set; }
        public string AccountType { get; set; }
        public decimal AccountBal { get; set; }
        public string Note { get; set; }
      
        public AccountInfos(string accountNum, string accountType, decimal accountBal, string note)
        {
            accountId = accountId++;
           // AccountNum = accountNum;
            AccountType = accountType;
            AccountBal = accountBal;
            Note = note;
        }



    }
}
