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
    public class LoadingUnit : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public LoadingUnit(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string details;
        string seal2;
        string seal1;
        string plateSerialNumber;
        Vessel vessel;
        Truck truck;
        Container container;
        Position operation;

        [Association("Operation-LoadingUnits")]
        public Position Operation
        {
            get => operation;
            set => SetPropertyValue(nameof(Operation), ref operation, value);
        }

        [Association("Container-LoadingUnits")]
        public Container Container
        {
            get => container;
            set => SetPropertyValue(nameof(Container), ref container, value);
        }

        [Association("Truck-LoadingUnits")]
        public Truck Truck
        {
            get => truck;
            set => SetPropertyValue(nameof(Truck), ref truck, value);
        }

        [Association("Vessel-LoadingUnits")]
        public Vessel Vessel
        {
            get => vessel;
            set => SetPropertyValue(nameof(Vessel), ref vessel, value);
        }

        [Size(50), Nullable(true)]
        public string PlateSerialNumber
        {
            get => plateSerialNumber;
            set => SetPropertyValue(nameof(PlateSerialNumber), ref plateSerialNumber, value);
        }

        [Size(50), Nullable(true)]
        public string Seal1
        {
            get => seal1;
            set => SetPropertyValue(nameof(Seal1), ref seal1, value);
        }

        [Size(50), Nullable(true)]
        public string Seal2
        {
            get => seal2;
            set => SetPropertyValue(nameof(Seal2), ref seal2, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }

        [Association("LoadingUnit-Goods")]
        public XPCollection<Good> Goods
        {
            get
            {
                return GetCollection<Good>(nameof(Goods));
            }
        }
        [Association("LoadingUnit-IncomeBills")]
        public XPCollection<IncomeBill> IncomeBills
        {
            get
            {
                return GetCollection<IncomeBill>(nameof(IncomeBills));
            }
        }
    }
}