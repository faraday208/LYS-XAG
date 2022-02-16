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
    public class Country : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Country(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        string details;
        string flag;
        string numCode;
        string ıSO3;
        string ıSO2;
        string titleTR;
        string title;

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

        [Size(2)]
        public string ISO2
        {
            get => ıSO2;
            set => SetPropertyValue(nameof(ISO2), ref ıSO2, value);
        }

        [Size(3)]
        public string ISO3
        {
            get => ıSO3;
            set => SetPropertyValue(nameof(ISO3), ref ıSO3, value);
        }


        [Size(3)]
        public string NumCode
        {
            get => numCode;
            set => SetPropertyValue(nameof(NumCode), ref numCode, value);
        }


        [Size(1024)]
        public string Flag
        {
            get => flag;
            set => SetPropertyValue(nameof(Flag), ref flag, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }

        [Association("Country-Companies")]
        public XPCollection<Company> Companies
        {
            get
            {
                return GetCollection<Company>(nameof(Companies));
            }
        }
        [Association("Country-CustomOffices")]
        public XPCollection<CustomOffice> CustomOffices
        {
            get
            {
                return GetCollection<CustomOffice>(nameof(CustomOffices));
            }
        }
        [Association("Country-Locations")]
        public XPCollection<Location> Locations
        {
            get
            {
                return GetCollection<Location>(nameof(Locations));
            }
        }
        [Association("Country-Ports")]
        public XPCollection<Port> Ports
        {
            get
            {
                return GetCollection<Port>(nameof(Ports));
            }
        }
        [Association("Country-Trucks")]
        public XPCollection<Truck> Trucks
        {
            get
            {
                return GetCollection<Truck>(nameof(Trucks));
            }
        }
        [Association("Country-Drivers")]
        public XPCollection<Driver> Drivers
        {
            get
            {
                return GetCollection<Driver>(nameof(Drivers));
            }
        }
    }
}