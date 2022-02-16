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
    public class Expense : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Expense(Session session)
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
        decimal vat;
        Currency currency;
        decimal priceInBaseCurrency;
        decimal price;
        string eTT;
        string number;
        DateTime date;
        Company company;
        Position operation;
        ExpenseType expenseType;

        [Association("ExpenseType-Expenses")]
        public ExpenseType ExpenseType
        {
            get => expenseType;
            set => SetPropertyValue(nameof(ExpenseType), ref expenseType, value);
        }


        [Association("Operation-Expenses")]
        public Position Operation
        {
            get => operation;
            set => SetPropertyValue(nameof(Operation), ref operation, value);
        }

        [Association("Company-Expenses")]
        public Company Company
        {
            get => Company;
            set => SetPropertyValue(nameof(Company), ref company, value);
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

        [Association("Currency-Expenses")]
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