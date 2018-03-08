using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSVC.DAL
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public Guid TransactionId { get; set; }
        public long OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public  decimal OrderTotal { get; set; }

        public string PaymentMode { get; set; }
        public string PaymentStatus { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

  
    }
}
