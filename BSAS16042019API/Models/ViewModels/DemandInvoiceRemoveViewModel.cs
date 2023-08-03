using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ViewModels
{
    public class DemandInvoiceRemoveViewModel
    {
        public string Message { get; set; }

        public int InvoiceCount { get; set; }

        public int ItemCount { get; set; }

        public int DeleteId { get; set; }
    }
}
