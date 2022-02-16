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
    public class CustomOffice : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public CustomOffice(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string details;
        string mail;
        string fax;
        string phone;
        Country country;
        string address;
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

        [Size(250), Nullable(true)]
        public string Address
        {
            get => address;
            set => SetPropertyValue(nameof(Address), ref address, value);
        }


        [Association("Country-CustomOffices")]
        public Country Country
        {
            get => country;
            set => SetPropertyValue(nameof(Country), ref country, value);
        }


        [Size(24), Nullable(true)]
        public string Phone
        {
            get => phone;
            set => SetPropertyValue(nameof(Phone), ref phone, value);
        }

        [Size(24), Nullable(true)]
        public string Fax
        {
            get => fax;
            set => SetPropertyValue(nameof(Fax), ref fax, value);
        }


        [Size(255), Nullable(true)]
        public string Mail
        {
            get => mail;
            set => SetPropertyValue(nameof(Mail), ref mail, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }

        [Association("DepartureCustomOffice-Operations")]
        public XPCollection<Position> DepartureCustomOfficeOperations
        {
            get
            {
                return GetCollection<Position>(nameof(DepartureCustomOfficeOperations));
            }
        }
        [Association("ArrivalCustomOffice-Operations")]
        public XPCollection<Position> ArrivalCustomOfficeOperations
        {
            get
            {
                return GetCollection<Position>(nameof(ArrivalCustomOfficeOperations));
            }
        }

        [Association("DepartureCustomOffice-Bids")]
        public XPCollection<Bid> DepartureCustomOfficeBids
        {
            get
            {
                return GetCollection<Bid>(nameof(DepartureCustomOfficeBids));
            }
        }
        [Association("ArrivalCustomOffice-Bids")]
        public XPCollection<Bid> ArrivalCustomOfficeBids
        {
            get
            {
                return GetCollection<Bid>(nameof(ArrivalCustomOfficeBids));
            }
        }
        

    }
}