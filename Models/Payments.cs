using System;
using System.Collections.Generic;

namespace SugarBakers.Models
{
    public partial class Payments
    {
        public int CustomerId { get; set; }
        public DateTime PmtDate { get; set; }
        public decimal? Amt { get; set; }

        public virtual Customers Customer { get; set; }
    }
}
