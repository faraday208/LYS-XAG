using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace LYS.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Bid : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Bid(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string details;
        Employee saleRepresentative;
        Employee customerRepresentative;
        Currency currency;
        decimal vat;
        decimal freightPrice;
        string files;
        string status;
        PaymentType paymentType;
        decimal brutWeight;
        string unit;
        decimal quantity;
        decimal amount;
        ShippingTerm shippingTerm;
        Nullable<DateTime> arrivalDate;
        Port arrivalPort;
        CustomOffice arrivalCustomOffice;
        Nullable<DateTime> departureDate;
        Port departurePort;
        CustomOffice departureCustomOffice;
        Company loadingCompany;
        Company consigneeCompany;
        Company notifyCompany;
        Company shipperCompany;
        Company contractCompany;
        string referenceNumber;
        string operationType;
        string transportationType;

        [Size(500), Nullable(true)]
        public string TransportationType
        {
            get => transportationType;
            set => SetPropertyValue(nameof(TransportationType), ref transportationType, value);
        }


        [Size(500), Nullable(true)]
        public string OperationType
        {
            get => operationType;
            set => SetPropertyValue(nameof(OperationType), ref operationType, value);
        }

        [Size(500), Nullable(true)]
        public string ReferenceNumber
        {
            get => referenceNumber;
            set => SetPropertyValue(nameof(ReferenceNumber), ref referenceNumber, value);
        }


        [Association("ContractCompany-Bids")]
        public Company ContractCompany
        {
            get => contractCompany;
            set => SetPropertyValue(nameof(ContractCompany), ref contractCompany, value);
        }


        [Association("ShipperCompany-Bids")]
        public Company ShipperCompany
        {
            get => shipperCompany;
            set => SetPropertyValue(nameof(ShipperCompany), ref shipperCompany, value);
        }


        [Association("NotifyCompany-Bids")]
        public Company NotifyCompany
        {
            get => notifyCompany;
            set => SetPropertyValue(nameof(NotifyCompany), ref notifyCompany, value);
        }

        [Association("ConsigneeCompany-Bids")]
        public Company ConsigneeCompany
        {
            get => consigneeCompany;
            set => SetPropertyValue(nameof(ConsigneeCompany), ref consigneeCompany, value);
        }


        [Association("LoadingCompany-Bids")]
        public Company LoadingCompany
        {
            get => loadingCompany;
            set => SetPropertyValue(nameof(LoadingCompany), ref loadingCompany, value);
        }


        [Association("DepartureCustomOffice-Bids")]
        public CustomOffice DepartureCustomOffice
        {
            get => departureCustomOffice;
            set => SetPropertyValue(nameof(DepartureCustomOffice), ref departureCustomOffice, value);
        }


        [Association("DeparturePort-Bids")]
        public Port DeparturePort
        {
            get => departurePort;
            set => SetPropertyValue(nameof(DeparturePort), ref departurePort, value);
        }


        [Nullable(true)]
        public Nullable<DateTime> DepartureDate
        {
            get => departureDate;
            set => SetPropertyValue(nameof(DepartureDate), ref departureDate, value);
        }


        [Association("ArrivalCustomOffice-Bids")]
        public CustomOffice ArrivalCustomOffice
        {
            get => arrivalCustomOffice;
            set => SetPropertyValue(nameof(ArrivalCustomOffice), ref arrivalCustomOffice, value);
        }


        [Association("ArrivalPort-Bids")]
        public Port ArrivalPort
        {
            get => arrivalPort;
            set => SetPropertyValue(nameof(ArrivalPort), ref arrivalPort, value);
        }


        [Nullable(true)]
        public Nullable<DateTime> ArrivalDate
        {
            get => arrivalDate;
            set => SetPropertyValue(nameof(ArrivalDate), ref arrivalDate, value);
        }


        [Association("ShippingTerm-Bids")]
        public ShippingTerm ShippingTerm
        {
            get => shippingTerm;
            set => SetPropertyValue(nameof(ShippingTerm), ref shippingTerm, value);
        }


        public decimal Amount
        {
            get => amount;
            set => SetPropertyValue(nameof(Amount), ref amount, value);
        }


        public decimal Quantity
        {
            get => quantity;
            set => SetPropertyValue(nameof(Quantity), ref quantity, value);
        }


        [Size(20), Nullable(true)]
        public string Unit
        {
            get => unit;
            set => SetPropertyValue(nameof(Unit), ref unit, value);
        }


        public decimal BrutWeight
        {
            get => brutWeight;
            set => SetPropertyValue(nameof(BrutWeight), ref brutWeight, value);
        }


        [Association("PaymentType-Bids")]
        public PaymentType PaymentType
        {
            get => paymentType;
            set => SetPropertyValue(nameof(PaymentType), ref paymentType, value);
        }


        [Size(500), Nullable(true)]
        public string Status
        {
            get => status;
            set => SetPropertyValue(nameof(Status), ref status, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Files
        {
            get => files;
            set => SetPropertyValue(nameof(Files), ref files, value);
        }

        [Nullable(true)]
        public decimal FreightPrice
        {
            get => freightPrice;
            set => SetPropertyValue(nameof(FreightPrice), ref freightPrice, value);
        }

        [Nullable(true)]
        public decimal Vat
        {
            get => vat;
            set => SetPropertyValue(nameof(Vat), ref vat, value);
        }


        [Association("Currency-Bids")]
        public Currency Currency
        {
            get => Currency;
            set => SetPropertyValue(nameof(Currency), ref currency, value);
        }


        [Association("CustomerRepresentative-Bids")]
        public Employee CustomerRepresentative
        {
            get => customerRepresentative;
            set => SetPropertyValue(nameof(CustomerRepresentative), ref customerRepresentative, value);
        }


        [Association("SaleRepresentative-Bids")]
        public Employee SaleRepresentative
        {
            get => saleRepresentative;
            set => SetPropertyValue(nameof(SaleRepresentative), ref saleRepresentative, value);
        }


        [Size(SizeAttribute.Unlimited)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }

        [Association("Bid-BidCompanies")]
        public XPCollection<BidCompany> BidCompanies
        {
            get
            {
                return GetCollection<BidCompany>(nameof(BidCompanies));
            }
        }

        [Association("Bid-Operations")]
        public XPCollection<Position> Operations
        {
            get
            {
                return GetCollection<Position>(nameof(Operations));
            }
        }

        [Association("Bid-BidContainers")]
        public XPCollection<BidContainer> BidContainers
        {
            get
            {
                return GetCollection<BidContainer>(nameof(BidContainers));
            }
        }
    }
}