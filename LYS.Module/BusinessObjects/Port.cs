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
    public class Port : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Port(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string details;
        Country country;
        string code;
        string title;

        [Size(50)]
        public string Title
        {
            get => title;
            set => SetPropertyValue(nameof(Title), ref title, value);
        }

        [Size(10)]
        public string Code
        {
            get => code;
            set => SetPropertyValue(nameof(Code), ref code, value);
        }

        [Association("Country-Ports")]
        public Country Country
        {
            get => country;
            set => SetPropertyValue(nameof(Country), ref country, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }

        [Association("DeparturePort-Bids")]
        public XPCollection<Bid> DeparturePortBids
        {
            get
            {
                return GetCollection<Bid>(nameof(DeparturePortBids));
            }
        }
        [Association("ArrivalPort-Bids")]
        public XPCollection<Bid> ArrivalPortBids
        {
            get
            {
                return GetCollection<Bid>(nameof(ArrivalPortBids));
            }
        }

        [Association("LoadingPort-Operations")]
        public XPCollection<Position> LoadingPortOperations
        {
            get
            {
                return GetCollection<Position>(nameof(LoadingPortOperations));
            }
        }
        [Association("TransferPort-Operations")]
        public XPCollection<Position> TransferPortOperations
        {
            get
            {
                return GetCollection<Position>(nameof(TransferPortOperations));
            }
        }
        [Association("DischargePort-Operations")]
        public XPCollection<Position> DischargePortOperations
        {
            get
            {
                return GetCollection<Position>(nameof(DischargePortOperations));
            }
        }
    }
}