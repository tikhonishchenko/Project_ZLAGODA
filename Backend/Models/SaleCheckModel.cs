using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.Backend.Models
{
    internal class SaleCheckModel
    {
        public string CheckNumber { get; set; }
        public string EmployeeId { get; set; }
        public string CardNumber { get; set; }
        public DateTime PrintDate { get; set; }
        public decimal SumTotal { get; set; }
        public decimal VAT { get; set; }

        public SaleCheckModel(string uPC, string employeeId, string cardNumber, DateTime date, decimal total, decimal vAT)
        {
            CheckNumber = uPC;
            EmployeeId = employeeId;
            CardNumber = cardNumber;
            PrintDate = date;
            SumTotal = total;
            VAT = vAT;
        }

        public SaleCheckModel()
        {
        }

        public override string ToString()
        {
            return $"{CheckNumber} {EmployeeId} {CardNumber} {PrintDate} {SumTotal} {VAT}";
        }

    }
}
