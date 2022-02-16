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
    public class Bill : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Bill(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }



        string details;
        string @ref;
        string taxExceptionReason;
        bool ısPrinted;
        string periodUnit;
        int period;
        DateTime billingEndDate;
        DateTime billingStartDate;
        decimal currencyPrice;
        Currency currency;
        Company company;
        string creationTime;
        DateTime orderDate;
        string orderNumber;
        string billType;
        string scenerio;
        string specializationNumber;
        string eTTN;
        string fileURL;
        string number;
        Nullable<DateTime> date;
        Position operation;

        [Association("Operation-Bills")]
        public Position Operation
        {
            get => operation;
            set => SetPropertyValue(nameof(Operation), ref operation, value);
        }


        [Nullable(true)]
        public Nullable<DateTime> Date
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


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string FileURL
        {
            get => fileURL;
            set => SetPropertyValue(nameof(FileURL), ref fileURL, value);
        }


        [Size(500), Nullable(true)]
        public string ETTN
        {
            get => eTTN;
            set => SetPropertyValue(nameof(ETTN), ref eTTN, value);
        }


        [Size(500), Nullable(true)]
        public string SpecializationNumber
        {
            get => specializationNumber;
            set => SetPropertyValue(nameof(SpecializationNumber), ref specializationNumber, value);
        }


        [Size(500), Nullable(true)]
        public string Scenerio
        {
            get => scenerio;
            set => SetPropertyValue(nameof(Scenerio), ref scenerio, value);
        }


        [Size(500), Nullable(true)]
        public string BillType
        {
            get => billType;
            set => SetPropertyValue(nameof(BillType), ref billType, value);
        }


        [Size(50), Nullable(true)]
        public string OrderNumber
        {
            get => orderNumber;
            set => SetPropertyValue(nameof(OrderNumber), ref orderNumber, value);
        }


        public DateTime OrderDate
        {
            get => orderDate;
            set => SetPropertyValue(nameof(OrderDate), ref orderDate, value);
        }

        [Size(50), Nullable(true)]
        public string CreationTime
        {
            get => creationTime;
            set => SetPropertyValue(nameof(CreationTime), ref creationTime, value);
        }


        [Association("Company-Bills")]
        public Company Company
        {
            get => company;
            set => SetPropertyValue(nameof(Company), ref company, value);
        }


        [Association("Currency-Bills")]
        public Currency Currency
        {
            get => currency;
            set => SetPropertyValue(nameof(Currency), ref currency, value);
        }


        public decimal CurrencyPrice
        {
            get => currencyPrice;
            set => SetPropertyValue(nameof(CurrencyPrice), ref currencyPrice, value);
        }


        public DateTime BillingStartDate
        {
            get => billingStartDate;
            set => SetPropertyValue(nameof(BillingStartDate), ref billingStartDate, value);
        }


        public DateTime BillingEndDate
        {
            get => billingEndDate;
            set => SetPropertyValue(nameof(BillingEndDate), ref billingEndDate, value);
        }


        public int Period
        {
            get => period;
            set => SetPropertyValue(nameof(Period), ref period, value);
        }

        [Size(50), Nullable(true)]
        public string PeriodUnit
        {
            get => periodUnit;
            set => SetPropertyValue(nameof(PeriodUnit), ref periodUnit, value);
        }


        public bool IsPrinted
        {
            get => ısPrinted;
            set => SetPropertyValue(nameof(IsPrinted), ref ısPrinted, value);
        }


        [Size(500)]
        public string TaxExceptionReason
        {
            get => taxExceptionReason;
            set => SetPropertyValue(nameof(TaxExceptionReason), ref taxExceptionReason, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Ref
        {
            get => @ref;
            set => SetPropertyValue(nameof(Ref), ref @ref, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }


        [Association("Bill-BillItems")]
        public XPCollection<BillItem> BillItems
        {
            get
            {
                return GetCollection<BillItem>(nameof(BillItems));
            }
        }

        [Association("IncomeBill-BillItems")]
        public XPCollection<BillItem> IncomeBillItems
        {
            get
            {
                return GetCollection<BillItem>(nameof(IncomeBillItems));
            }
        }

    }
}