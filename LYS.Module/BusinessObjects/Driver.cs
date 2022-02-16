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
    public class Driver : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Driver(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string details;
        string licenceNumber;
        string name;
        Country country;
        Company company;

        [Association("Company-Drivers")]
        public Company Company
        {
            get => company;
            set => SetPropertyValue(nameof(Company), ref company, value);
        }

        [Association("Country-Drivers")]
        public Country Country
        {
            get => country;
            set => SetPropertyValue(nameof(Country), ref country, value);
        }

        [Size(50), Nullable(true)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }


        [Size(50), Nullable(true)]
        public string LicenceNumber
        {
            get => licenceNumber;
            set => SetPropertyValue(nameof(LicenceNumber), ref licenceNumber, value);
        }


        [Size(SizeAttribute.Unlimited),Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }

        [Association("MainDriver-Operations")]
        public XPCollection<Position> MainDriverOperations
        {
            get
            {
                return GetCollection<Position>(nameof(MainDriverOperations));
            }
        }
        [Association("TransitDriver-Operations")]
        public XPCollection<Position> TransitDriverOperations
        {
            get
            {
                return GetCollection<Position>(nameof(TransitDriverOperations));
            }
        }
    }
}