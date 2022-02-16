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
    [Persistent("BidCompanies")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class BidCompany : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public BidCompany(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        string details;
        bool ısAccepted;
        Currency currency;
        decimal priceInBaseCurrency;
        decimal vat;
        decimal price;
        decimal quantity;
        ExpenseType expenseType;
        Company company;
        Bid bid;

        [Association("Bid-BidCompanies")]
        public Bid Bid
        {
            get => bid;
            set => SetPropertyValue(nameof(Bid), ref bid, value);
        }


        [Association("Company-BidCompanies")]
        public Company Company
        {
            get => company;
            set => SetPropertyValue(nameof(Company), ref company, value);
        }


        [Association("ExpenseType-BidCompanies")]
        public ExpenseType ExpenseType
        {
            get => expenseType;
            set => SetPropertyValue(nameof(ExpenseType), ref expenseType, value);
        }


        public decimal Quantity
        {
            get => quantity;
            set => SetPropertyValue(nameof(Quantity), ref quantity, value);
        }


        public decimal Price
        {
            get => price;
            set => SetPropertyValue(nameof(Price), ref price, value);
        }


        public decimal Vat
        {
            get => vat;
            set => SetPropertyValue(nameof(Vat), ref vat, value);
        }


        public decimal PriceInBaseCurrency
        {
            get => priceInBaseCurrency;
            set => SetPropertyValue(nameof(PriceInBaseCurrency), ref priceInBaseCurrency, value);
        }


        [Association("Currency-BidCompanies")]
        public Currency Currency
        {
            get => currency;
            set => SetPropertyValue(nameof(Currency), ref currency, value);
        }


        public bool IsAccepted
        {
            get => ısAccepted;
            set => SetPropertyValue(nameof(IsAccepted), ref ısAccepted, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }

    }
}