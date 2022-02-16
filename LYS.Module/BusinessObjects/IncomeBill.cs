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
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class IncomeBill : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public IncomeBill(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string details;
        string fileUrl;
        string unit;
        decimal quantity;
        string eTT;
        string number;
        DateTime date;
        Currency currency;
        decimal vat;
        decimal priceInBaseCurrency;
        decimal price;
        Company company;
        LoadingUnit loadingUnit;
        Position operation;
        ExpenseType expenseType;

        [Association("ExpenseType-IncomeBills")]
        public ExpenseType ExpenseType
        {
            get => expenseType;
            set => SetPropertyValue(nameof(ExpenseType), ref expenseType, value);
        }

        [Association("Operation-IncomeBills")]
        public Position Operation
        {
            get => operation;
            set => SetPropertyValue(nameof(Operation), ref operation, value);
        }

        [Association("LoadingUnit-IncomeBills")]
        public LoadingUnit LoadingUnit
        {
            get => loadingUnit;
            set => SetPropertyValue(nameof(LoadingUnit), ref loadingUnit, value);
        }

        [Association("Company-IncomeBills")]
        public Company Company
        {
            get => company;
            set => SetPropertyValue(nameof(Company), ref company, value);
        }


        public decimal Price
        {
            get => price;
            set => SetPropertyValue(nameof(Price), ref price, value);
        }

        public decimal PriceInBaseCurrency
        {
            get => priceInBaseCurrency;
            set => SetPropertyValue(nameof(PriceInBaseCurrency), ref priceInBaseCurrency, value);
        }

        public decimal Vat
        {
            get => vat;
            set => SetPropertyValue(nameof(Vat), ref vat, value);
        }

        [Association("Currency-IncomeBills")]
        public Currency Currency
        {
            get => currency;
            set => SetPropertyValue(nameof(Currency), ref currency, value);
        }

        public DateTime Date
        {
            get => date;
            set => SetPropertyValue(nameof(Date), ref date, value);
        }


        [Size(500), Nullable(true)]
        public string Number
        {
            get => number;
            set => SetPropertyValue(nameof(Number), ref number, value);
        }

        [Size(500), Nullable(true)]
        public string ETT
        {
            get => eTT;
            set => SetPropertyValue(nameof(ETT), ref eTT, value);
        }


        public decimal Quantity
        {
            get => quantity;
            set => SetPropertyValue(nameof(Quantity), ref quantity, value);
        }

        [Size(500), Nullable(true)]
        public string Unit
        {
            get => unit;
            set => SetPropertyValue(nameof(Unit), ref unit, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string FileUrl
        {
            get => fileUrl;
            set => SetPropertyValue(nameof(FileUrl), ref fileUrl, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }
    }
}