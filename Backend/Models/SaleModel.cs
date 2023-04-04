using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.Backend.Models
{
    internal class SaleModel
    {
        public string UPC { get; set; }
        public string EmployeeId { get; set; }
        public string CardNumber { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public decimal VAT { get; set; }

        public SaleModel(string uPC, string employeeId, string cardNumber, DateTime date, decimal total, decimal vAT)
        {
            UPC = uPC;
            EmployeeId = employeeId;
            CardNumber = cardNumber;
            Date = date;
            Total = total;
            VAT = vAT;
        }

        public SaleModel()
        {
        }

        public override string ToString()
        {
            return $"{UPC} {EmployeeId} {CardNumber} {Date} {Total} {VAT}";
        }

    }
}
