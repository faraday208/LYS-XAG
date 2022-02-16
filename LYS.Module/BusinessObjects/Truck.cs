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
    public class Truck : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Truck(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        string details;
        decimal height;
        decimal lenght;
        decimal width;
        string capacity;
        string tonage;
        string year;
        string model;
        string brand;
        string plateNumber;
        string chassisNumber;
        Country country;
        Company ownerCompany;

        [Association("Company-Trucks")]
        public Company OwnerCompany
        {
            get => ownerCompany;
            set => SetPropertyValue(nameof(OwnerCompany), ref ownerCompany, value);
        }


        [Association("Country-Trucks")]
        public Country Country
        {
            get => country;
            set => SetPropertyValue(nameof(Country), ref country, value);
        }

        [Size(50), Nullable(true)]
        public string ChassisNumber
        {
            get => chassisNumber;
            set => SetPropertyValue(nameof(ChassisNumber), ref chassisNumber, value);
        }

        [Size(50), Nullable(true)]
        public string PlateNumber
        {
            get => plateNumber;
            set => SetPropertyValue(nameof(PlateNumber), ref plateNumber, value);
        }

        [Size(50), Nullable(true)]
        public string Brand
        {
            get => brand;
            set => SetPropertyValue(nameof(Brand), ref brand, value);
        }

        [Size(50), Nullable(true)]
        public string Model
        {
            get => model;
            set => SetPropertyValue(nameof(Model), ref model, value);
        }

        [Size(50), Nullable(true)]
        public string Year
        {
            get => year;
            set => SetPropertyValue(nameof(Year), ref year, value);
        }

        [Size(50), Nullable(true)]
        public string Tonage
        {
            get => tonage;
            set => SetPropertyValue(nameof(Tonage), ref tonage, value);
        }

        [Size(50), Nullable(true)]
        public string Capacity
        {
            get => capacity;
            set => SetPropertyValue(nameof(Capacity), ref capacity, value);
        }

        public decimal Width
        {
            get => width;
            set => SetPropertyValue(nameof(Width), ref width, value);
        }

        public decimal Lenght
        {
            get => lenght;
            set => SetPropertyValue(nameof(Lenght), ref lenght, value);
        }

        public decimal Height
        {
            get => height;
            set => SetPropertyValue(nameof(Height), ref height, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }

        [Association("MainTruck-Operations")]
        public XPCollection<Position> MainTruckOperations
        {
            get
            {
                return GetCollection<Position>(nameof(MainTruckOperations));
            }
        }
        [Association("TransitTruck-Operations")]
        public XPCollection<Position> TransitTruckOperations
        {
            get
            {
                return GetCollection<Position>(nameof(TransitTruckOperations));
            }
        }
        [Association("Truck-LoadingUnits")]
        public XPCollection<LoadingUnit> LoadingUnits
        {
            get
            {
                return GetCollection<LoadingUnit>(nameof(LoadingUnits));
            }
        }
    }
}