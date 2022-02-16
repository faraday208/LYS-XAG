using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace LYS.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Container : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Container(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        string details;
        decimal doorHeight;
        decimal doorWidth;
        decimal ıntLenght;
        decimal ıntHeight;
        decimal ıntWidth;
        decimal exLenght;
        decimal exHeight;
        decimal exWidth;
        decimal netLoad;
        decimal maxGrossWeight;
        decimal tareWeight;
        string title;
        ContainerType containerType;

        [Association("ContainerType-Containers")]
        public ContainerType ContainerType
        {
            get => containerType;
            set => SetPropertyValue(nameof(ContainerType), ref containerType, value);
        }


        [Size(50)]
        public string Title
        {
            get => title;
            set => SetPropertyValue(nameof(Title), ref title, value);
        }

        public decimal TareWeight
        {
            get => tareWeight;
            set => SetPropertyValue(nameof(TareWeight), ref tareWeight, value);
        }


        public decimal MaxGrossWeight
        {
            get => maxGrossWeight;
            set => SetPropertyValue(nameof(MaxGrossWeight), ref maxGrossWeight, value);
        }


        public decimal NetLoad
        {
            get => netLoad;
            set => SetPropertyValue(nameof(NetLoad), ref netLoad, value);
        }


        public decimal ExWidth
        {
            get => exWidth;
            set => SetPropertyValue(nameof(ExWidth), ref exWidth, value);
        }

        public decimal ExHeight
        {
            get => exHeight;
            set => SetPropertyValue(nameof(ExHeight), ref exHeight, value);
        }

        public decimal ExLenght
        {
            get => exLenght;
            set => SetPropertyValue(nameof(ExLenght), ref exLenght, value);
        }


        public decimal IntWidth
        {
            get => ıntWidth;
            set => SetPropertyValue(nameof(IntWidth), ref ıntWidth, value);
        }


        public decimal IntHeight
        {
            get => ıntHeight;
            set => SetPropertyValue(nameof(IntHeight), ref ıntHeight, value);
        }


        public decimal IntLenght
        {
            get => ıntLenght;
            set => SetPropertyValue(nameof(IntLenght), ref ıntLenght, value);
        }


        public decimal DoorWidth
        {
            get => doorWidth;
            set => SetPropertyValue(nameof(DoorWidth), ref doorWidth, value);
        }


        public decimal DoorHeight
        {
            get => doorHeight;
            set => SetPropertyValue(nameof(DoorHeight), ref doorHeight, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }








        [Association("Container-BidContainers")]
        public XPCollection<BidContainer> BidContainers
        {
            get
            {
                return GetCollection<BidContainer>(nameof(BidContainers));
            }
        }
        [Association("Container-LoadingUnits")]
        public XPCollection<LoadingUnit> LoadingUnits
        {
            get
            {
                return GetCollection<LoadingUnit>(nameof(LoadingUnits));
            }
        }

    }
}