using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//телефон та адреса працівників за прізвищем
//постійні клієнти із певним відсотком (за прізвищем)
//товарів за категорією (за назвою)
//товар за UPC
//акційні товари (за кількістю)
//акційні товари(за назвою)
//не акційні товари (за кількістю)
//не акційні товари (за назвою)
//чеки за касиром, за період часу
//чеки за період часу
//сума проданих товарів за касиром, за період часу
//сума проданих товарів за період часу
//кількість проданого певного товару за період часу
namespace Project_ZLAGODA.Frontend
{
    public enum Query
    {
        PhoneAddressEmployeeBySurname,
        CustomersByDiscountSortedSurname,
        ProductByCategorySortedName,
        StoreProductByUPC,
        PromotionalStoreProductSortedQuantity,
        PromotionalStoreProductSortedName,
        OrdinaryStoreProductSortedQuantity,
        OrdinaryStoreProductSortedName,
        SaleCheckByCashierByPeriod,
        SaleCheckByPeriod,
        SumStoreProductByCashierByPeriod,
        SumStoreProductByPeriod,
        QuantityStoreProductByPeriod
    }
}
