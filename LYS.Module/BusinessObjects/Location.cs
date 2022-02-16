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
    public class Location : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Location(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        string code;
        Country country;
        string details;
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
        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }


        [Association("Country-Locations")]
        public Country Country
        {
            get => country;
            set => SetPropertyValue(nameof(Country), ref country, value);
        }

        [Association("DepartureLocation-Operations")]
        public XPCollection<Position> DepartureLocationOperations
        {
            get
            {
                return GetCollection<Position>(nameof(DepartureLocationOperations));
            }
        }
        [Association("TransferLocation-Operations")]
        public XPCollection<Position> TransferLocationOperations
        {
            get
            {
                return GetCollection<Position>(nameof(TransferLocationOperations));
            }
        }
        [Association("ArrivalLocation-Operations")]
        public XPCollection<Position> ArrivalLocationOperations
        {
            get
            {
                return GetCollection<Position>(nameof(ArrivalLocationOperations));
            }
        }
        [Association("AcceptanceLocation-Operations")]
        public XPCollection<Position> AcceptanceLocationOperations
        {
            get
            {
                return GetCollection<Position>(nameof(AcceptanceLocationOperations));
            }
        }
        [Association("PlaceofReceiptLocation-Operations")]
        public XPCollection<Position> PlaceofReceiptLocationOperations
        {
            get
            {
                return GetCollection<Position>(nameof(PlaceofReceiptLocationOperations));
            }
        }
        [Association("FolderPublishLocation-Operations")]
        public XPCollection<Position> FolderPublishLocationOperations
        {
            get
            {
                return GetCollection<Position>(nameof(FolderPublishLocationOperations));
            }
        }
    }
}