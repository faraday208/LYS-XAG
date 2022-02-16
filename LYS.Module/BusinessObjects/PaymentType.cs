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
    public class PaymentType : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public PaymentType(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string details;
        int freeInterestDays;
        int ınterestDays;
        string code;

        [Size(50)]
        public string Code
        {
            get => code;
            set => SetPropertyValue(nameof(Code), ref code, value);
        }


        public int InterestDays
        {
            get => ınterestDays;
            set => SetPropertyValue(nameof(InterestDays), ref ınterestDays, value);
        }

        public int FreeInterestDays
        {
            get => freeInterestDays;
            set => SetPropertyValue(nameof(FreeInterestDays), ref freeInterestDays, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }

        [Association("PaymentType-Bids")]
        public XPCollection<Bid> Bids
        {
            get
            {
                return GetCollection<Bid>(nameof(Bids));
            }
        }

        [Association("PaymentType-Companies")]
        public XPCollection<Company> Companies
        {
            get
            {
                return GetCollection<Company>(nameof(Companies));
            }
        }

        [Association("PaymentType-Operations")]
        public XPCollection<Position> Operations
        {
            get
            {
                return GetCollection<Position>(nameof(Operations));
            }
        }
        [Association("SupplierPaymentType-Operations")]
        public XPCollection<Position> SupplierPaymentTypeOperations
        {
            get
            {
                return GetCollection<Position>(nameof(SupplierPaymentTypeOperations));
            }
        }
        
    }
}