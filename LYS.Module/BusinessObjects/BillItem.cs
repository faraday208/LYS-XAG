using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace LYS.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    [Persistent("BillItems")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class BillItem : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public BillItem(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string details;
        decimal vat;
        Currency currency;
        decimal unitPrice;
        string quantityUnit;
        decimal quantity;
        string goodService;
        int ındexOrder;
        Bill ıncomeBill;
        Bill bill;

        [Association("Bill-BillItems")]
        public Bill Bill
        {
            get => bill;
            set => SetPropertyValue(nameof(Bill), ref bill, value);
        }


        [Association("IncomeBill-BillItems")]
        public Bill IncomeBill
        {
            get => ıncomeBill;
            set => SetPropertyValue(nameof(IncomeBill), ref ıncomeBill, value);
        }



        public int IndexOrder
        {
            get => ındexOrder;
            set => SetPropertyValue(nameof(IndexOrder), ref ındexOrder, value);
        }


        [Size(500), Nullable(true)]
        public string GoodService
        {
            get => goodService;
            set => SetPropertyValue(nameof(GoodService), ref goodService, value);
        }

        public decimal Quantity
        {
            get => quantity;
            set => SetPropertyValue(nameof(Quantity), ref quantity, value);
        }


        [Size(50), Nullable(true)]
        public string QuantityUnit
        {
            get => quantityUnit;
            set => SetPropertyValue(nameof(QuantityUnit), ref quantityUnit, value);
        }

        public decimal UnitPrice
        {
            get => unitPrice;
            set => SetPropertyValue(nameof(UnitPrice), ref unitPrice, value);
        }


        [Association("Currency-BillItems")]
       
        public Currency Currency
        {
            get => currency;
            set => SetPropertyValue(nameof(Currency), ref currency, value);
        }

        public decimal Vat
        {
            get => vat;
            set => SetPropertyValue(nameof(Vat), ref vat, value);
        }


        [Size(500), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }



    }
}