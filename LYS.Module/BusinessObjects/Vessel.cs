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
    public class Vessel : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Vessel(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string details;
        string status;
        Nullable<int> builtYear;
        Nullable<decimal> breadthExtreme;
        Nullable<decimal> lengthOverall;
        Nullable<decimal> deadWeight;
        Nullable<decimal> grossTonnage;
        string aisVesselType;
        string flag;
        string callSign;
        string mMSI;
        string ımo;
        string title;
        Company ownerCompany;

        [Association("Company-Vessels")]
        public Company OwnerCompany
        {
            get => ownerCompany;
            set => SetPropertyValue(nameof(OwnerCompany), ref ownerCompany, value);
        }

        [Size(50)]
        public string Title
        {
            get => title;
            set => SetPropertyValue(nameof(Title), ref title, value);
        }

        [Size(10)]
        public string IMO
        {
            get => ımo;
            set => SetPropertyValue(nameof(IMO), ref ımo, value);
        }

        [Size(15)]
        public string MMSI
        {
            get => mMSI;
            set => SetPropertyValue(nameof(MMSI), ref mMSI, value);
        }


        [Size(20), Nullable(true)]
        public string CallSign
        {
            get => callSign;
            set => SetPropertyValue(nameof(CallSign), ref callSign, value);
        }

        [Size(50), Nullable(true)]
        public string Flag
        {
            get => flag;
            set => SetPropertyValue(nameof(Flag), ref flag, value);
        }

        [Size(50), Nullable(true)]
        public string AisVesselType
        {
            get => aisVesselType;
            set => SetPropertyValue(nameof(AisVesselType), ref aisVesselType, value);
        }
        [Nullable(true)]
        public Nullable<decimal> GrossTonnage
        {
            get => grossTonnage;
            set => SetPropertyValue(nameof(GrossTonnage), ref grossTonnage, value);
        }
        [Nullable(true)]
        public Nullable<decimal> DeadWeight
        {
            get => deadWeight;
            set => SetPropertyValue(nameof(DeadWeight), ref deadWeight, value);
        }
        [Nullable(true)]
        public Nullable<decimal> LengthOverall
        {
            get => lengthOverall;
            set => SetPropertyValue(nameof(LengthOverall), ref lengthOverall, value);
        }

        [Nullable(true)]
        public Nullable<decimal> BreadthExtreme
        {
            get => breadthExtreme;
            set => SetPropertyValue(nameof(BreadthExtreme), ref breadthExtreme, value);
        }
        [Nullable(true)]
        public Nullable<int> BuiltYear
        {
            get => builtYear;
            set => SetPropertyValue(nameof(BuiltYear), ref builtYear, value);
        }

        [Size(20), Nullable(true)]
        public string Status
        {
            get => status;
            set => SetPropertyValue(nameof(Status), ref status, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }
        [Association("MainVessel-Operations")]
        public XPCollection<Position> MainVesselOperations
        {
            get
            {
                return GetCollection<Position>(nameof(MainVesselOperations));
            }
        }
        [Association("TransitVessel-Operations")]
        public XPCollection<Position> TransitVesselOperations
        {
            get
            {
                return GetCollection<Position>(nameof(TransitVesselOperations));
            }
        }
        [Association("Vessel-LoadingUnits")]
        public XPCollection<LoadingUnit> LoadingUnits
        {
            get
            {
                return GetCollection<LoadingUnit>(nameof(LoadingUnits));
            }
        }
    }
}