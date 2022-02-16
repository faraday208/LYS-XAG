using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;

namespace LYS.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Good : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Good(Session session)
            : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string details;
        string gtipNo;
        Currency currency;
        decimal priceInBaseCurrency;
        decimal price;
        string billNumber;
        string colorCode;
        string burningLevel;
        Company emergencyCompany;
        int loadingOrderNo;
        string t1T2;
        string ex1;
        string attNo;
        int ındexOrder;
        decimal brutWeight;
        decimal netWeight;
        decimal lenght;
        private decimal height;
        private decimal width;
        private string unit;
        private string loadingReference;
        private decimal quantity;
        private LoadingType loadingType;
        private LoadingUnit loadingUnit;
        private Position propertyName;

        [Association("Operation-Goods")]
        public Position PropertyName
        {
            get => propertyName;
            set => SetPropertyValue(nameof(PropertyName), ref propertyName, value);
        }

        [Association("LoadingUnit-Goods")]
        public LoadingUnit LoadingUnit
        {
            get => loadingUnit;
            set => SetPropertyValue(nameof(LoadingUnit), ref loadingUnit, value);
        }

        [Association("LoadingType-Goods")]
        public LoadingType LoadingType
        {
            get => loadingType;
            set => SetPropertyValue(nameof(LoadingType), ref loadingType, value);
        }

        public decimal Quantity
        {
            get => quantity;
            set => SetPropertyValue(nameof(Quantity), ref quantity, value);
        }

        [Size(50), Nullable(true)]
        public string LoadingReference
        {
            get => loadingReference;
            set => SetPropertyValue(nameof(LoadingReference), ref loadingReference, value);
        }

        [Size(20), Nullable(true)]
        public string Unit
        {
            get => unit;
            set => SetPropertyValue(nameof(Unit), ref unit, value);
        }

        public decimal Width
        {
            get => width;
            set => SetPropertyValue(nameof(Width), ref width, value);
        }

        public decimal Height
        {
            get => height;
            set => SetPropertyValue(nameof(Height), ref height, value);
        }

        public decimal Lenght
        {
            get => lenght;
            set => SetPropertyValue(nameof(Lenght), ref lenght, value);
        }

        public decimal NetWeight
        {
            get => netWeight;
            set => SetPropertyValue(nameof(NetWeight), ref netWeight, value);
        }


        public decimal BrutWeight
        {
            get => brutWeight;
            set => SetPropertyValue(nameof(BrutWeight), ref brutWeight, value);
        }

        public int IndexOrder
        {
            get => ındexOrder;
            set => SetPropertyValue(nameof(IndexOrder), ref ındexOrder, value);
        }

        [Size(50), Nullable(true)]
        public string AttNo
        {
            get => attNo;
            set => SetPropertyValue(nameof(AttNo), ref attNo, value);
        }


        [Size(50), Nullable(true)]
        public string Ex1
        {
            get => ex1;
            set => SetPropertyValue(nameof(Ex1), ref ex1, value);
        }


        [Size(50), Nullable(true)]
        public string T1T2
        {
            get => t1T2;
            set => SetPropertyValue(nameof(T1T2), ref t1T2, value);
        }


        public int LoadingOrderNo
        {
            get => loadingOrderNo;
            set => SetPropertyValue(nameof(LoadingOrderNo), ref loadingOrderNo, value);
        }


        [Association("Company-Goods")]
        public Company EmergencyCompany
        {
            get => emergencyCompany;
            set => SetPropertyValue(nameof(EmergencyCompany), ref emergencyCompany, value);
        }

        [Size(1024), Nullable(true)]
        public string BurningLevel
        {
            get => burningLevel;
            set => SetPropertyValue(nameof(BurningLevel), ref burningLevel, value);
        }


        [Size(1024), Nullable(true)]
        public string ColorCode
        {
            get => colorCode;
            set => SetPropertyValue(nameof(ColorCode), ref colorCode, value);
        }


        [Size(50), Nullable(true)]
        public string BillNumber
        {
            get => billNumber;
            set => SetPropertyValue(nameof(BillNumber), ref billNumber, value);
        }


        public decimal Price
        {
            get => price;
            set => SetPropertyValue(nameof(Price), ref price, value);
        }

        public decimal PriceInBaseCurrency
        {
            get => priceInBaseCurrency;
            set => SetPropertyValue(nameof(PriceInBaseCurrency), ref priceInBaseCurrency, value);
        }


        [Association("Currency-Goods")]
        public Currency Currency
        {
            get => currency;
            set => SetPropertyValue(nameof(Currency), ref currency, value);
        }

        [Size(1024), Nullable(true)]
        public string GtipNo
        {
            get => gtipNo;
            set => SetPropertyValue(nameof(GtipNo), ref gtipNo, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }
    }
}