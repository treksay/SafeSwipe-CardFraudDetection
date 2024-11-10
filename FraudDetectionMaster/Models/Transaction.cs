using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FraudDetectionMaster.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public String Step { get; set; }
        public String Type { get; set; }
        public String Amount { get; set; }
        public String NameOrig { get; set; }
        public String OldBalanceOrg { get; set; }
        public String NewBalanceOrg { get; set; }
        public String NameDest { get; set; }
        public String OldBalanceDest { get; set; }
        public String newbalanceDest { get; set; }
        public String IsFraud { get; set; }


    }
}