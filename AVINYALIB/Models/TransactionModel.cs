using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVINYALIB.Models
{
    public class TransactionModel
    {
        public int TransactionId { get; set; }
        public int? FromAccountId {  get; set; }
        public int? ToAccountId { get; set; }
        public string? Amount {  get; set; }
        public string? Date { get; set; }
        public string? Status { get; set; }


    }
}
