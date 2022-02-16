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
    public class Currency : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Currency(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }



        string details;
        string titleTR;
        string title;
        string code;
        string sign;

        [Size(5)]
        public string Sign
        {
            get => sign;
            set => SetPropertyValue(nameof(Sign), ref sign, value);
        }

        [Size(10)]
        public string Code
        {
            get => code;
            set => SetPropertyValue(nameof(Code), ref code, value);
        }

        [Size(50)]
        public string Title
        {
            get => title;
            set => SetPropertyValue(nameof(Title), ref title, value);
        }


        [Size(50)]
        public string TitleTR
        {
            get => titleTR;
            set => SetPropertyValue(nameof(TitleTR), ref titleTR, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }
        [Association("Currency-BidCompanies")]
        public XPCollection<BidCompany> BidCompanies
        {
            get
            {
                return GetCollection<BidCompany>(nameof(BidCompanies));
            }
        }

        [Association("Currency-Bids")]
        public XPCollection<Bid> Bids
        {
            get
            {
                return GetCollection<Bid>(nameof(Bids));
            }
        }

        [Association("Currency-Bills")]
        public XPCollection<Bill> Bills
        {
            get
            {
                return GetCollection<Bill>(nameof(Bills));
            }
        }
        [Association("Currency-BillItems")]
        public XPCollection<BillItem> BillItems
        {
            get
            {
                return GetCollection<BillItem>(nameof(BillItems));
            }
        }
        [Association("Currency-CompanyAccounts")]
        public XPCollection<CompanyAccount> CompanyAccounts
        {
            get
            {
                return GetCollection<CompanyAccount>(nameof(CompanyAccounts));
            }
        }
        [Association("Currency-CurrencyRates")]
        public XPCollection<CurrencyRate> CurrencyRates
        {
            get
            {
                return GetCollection<CurrencyRate>(nameof(CurrencyRates));
            }
        }
        [Association("Currency-EmployeeAccounts")]
        public XPCollection<EmployeeAccount> EmployeeAccounts
        {
            get
            {
                return GetCollection<EmployeeAccount>(nameof(EmployeeAccounts));
            }
        }
        [Association("Currency-Expenses")]
        public XPCollection<Expense> Expenses
        {
            get
            {
                return GetCollection<Expense>(nameof(Expenses));
            }
        }
        [Association("Currency-Goods")]
        public XPCollection<Good> Goods
        {
            get
            {
                return GetCollection<Good>(nameof(Goods));
            }
        }
        [Association("Currency-IncomeBills")]
        public XPCollection<IncomeBill> IncomeBills
        {
            get
            {
                return GetCollection<IncomeBill>(nameof(IncomeBills));
            }
        }
    }
}