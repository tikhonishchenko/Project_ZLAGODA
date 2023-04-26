using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.Backend.Models
{
    public class SaleCheckModel
    {
        [DisplayName("Номер чеку")]
        public int CheckNumber { get; set; }
        [DisplayName("Id працівника")]
        public string EmployeeId { get; set; }
        [DisplayName("Номер картки")]
        public string CardNumber { get; set; }
        [DisplayName("Дата")]
        public DateTime PrintDate { get; set; }
        [DisplayName("Сума")]
        public decimal SumTotal { get; set; }
        [DisplayName("ПДВ")]
        public decimal VAT { get; set; }
        [DisplayName("Товари")]
        public List<SaleModel> CheckItems { get; set; }

        public SaleCheckModel(int uPC, string employeeId, string cardNumber, DateTime date, decimal total, decimal vAT, List<SaleModel> checkItems)
        {
            CheckNumber = uPC;
            EmployeeId = employeeId;
            CardNumber = cardNumber;
            PrintDate = date;
            SumTotal = total;
            VAT = vAT;
            CheckItems = checkItems;
        }

        public SaleCheckModel()
        {
            CheckItems = new List<SaleModel>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"CheckNumber: {CheckNumber}, EmployeeId: {EmployeeId}, CardNumber: {CardNumber}");
            foreach (var item in CheckItems)
            {
                sb.Append($", {item.ToString()}");
            }
            sb.Append($", PrintDate: {PrintDate}, SumTotal: {SumTotal}, VAT: {VAT}");
            return sb.ToString();
        }

    }
}
