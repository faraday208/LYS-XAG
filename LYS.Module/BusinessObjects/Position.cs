using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;

namespace LYS.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Position : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Position(Session session)
            : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        Location placeofReceiptLocation;
        Company preCarriageCompany;
        string details;
        string notes;
        string supplierContractNotes;
        string files;
        Company arrivalCustomCompany;
        Company departureCustomCompany;
        Driver transitDriver;
        Driver mainDriver;
        Truck transitTruck;
        Truck mainTruck;
        string ex1;
        string atrNo;
        string plateNumber;
        string missingInfo;
        bool ısMissing;
        bool ısOpen;
        string operationType;
        TransportationTypes transportationType;
        Company notifyCompany;
        string status;
        Port dischargePort;
        string transitVesselVoyageNo;
        Vessel transitVessel;
        string mainVesselVoyageNo;
        Vessel mainVessel;
        Location folderPublishLocation;
        string freightChargersRatePer;
        string vehiclePlateNumber;
        string roroPlateNumber;
        Employee salesRepresentative;
        private Employee customerRepresentative;
        private Nullable<int> transitTime;
        private Nullable<int> estimatedTransferTime;
        private Nullable<DateTime> arrivalDate;
        private Nullable<DateTime> estimatedArrivalDate;
        private Nullable<DateTime> deliveryDate;
        private Nullable<DateTime> acceptanceDate;
        private Nullable<DateTime> departureDate;
        private Nullable<DateTime> estimatedDepartureDate;
        private string contractNo;
        private Company deliveryCompany;
        private Location acceptanceLocation;
        private PaymentType paymentType;
        private PaymentType supplierPaymentType;
        private DeliveryType deliveryType;
        private Location arrivalLocation;
        private DateTime transferDate;
        private Port transferPort;
        private Nullable<DateTime> loadingDate;
        private Company loadingCompany;
        private Location transferLocation;
        private Port loadingPort;
        private Location departureLocation;
        private Nullable<int> numberofCopyFBL;
        private Nullable<int> numberofOriginalFBL;
        private Nullable<DateTime> operationDate;
        private Company supplierCompany;
        private Company rezervationCompany;
        private Company billingCompany;
        private Company abroadAgency;
        private Company shippingAgency;
        private Company shippingLineCompany;
        private Company nationalShippingCompany;

        private Company contractCompany;
        private Company consigneeCompany;
        private Company shipperCompany;
        private DeclarationType declarationType;
        private ShippingServiceCode shippingServiceCode;
        private GoodType goodType;
        private LoadingType loadingType;
        private string ınttraSiComm;
        private string ınttraDocVer;
        private string ınttraSı;
        private Nullable<bool> ısTransit;
        private FreightPaymentType freightPaymentType;
        private string bookingNo;

        private ShippingTerm shippingTerm;
        private CustomOffice arrivalCustomOffice;
        private CustomOffice departureCustomOffice;
        private string operationNumber;
        private string password;
        private string folderNumber;
        private FolderType folderType;
        private Bid bid;

        [Association("Bid-Operations")]
        public Bid Bid
        {
            get => bid;
            set => SetPropertyValue(nameof(Bid), ref bid, value);
        }

        [Association("FolderType-Operations")]
        public FolderType FolderType
        {
            get => folderType;
            set => SetPropertyValue(nameof(FolderType), ref folderType, value);
        }

        [Size(500), Nullable(true)]
        public string FolderNumber
        {
            get => folderNumber;
            set => SetPropertyValue(nameof(FolderNumber), ref folderNumber, value);
        }

        [Size(500), Nullable(true)]
        public string Password
        {
            get => password;
            set => SetPropertyValue(nameof(Password), ref password, value);
        }

        [Size(500), Nullable(true)]
        public string OperationNumber
        {
            get => operationNumber;
            set => SetPropertyValue(nameof(OperationNumber), ref operationNumber, value);
        }

        [Association("DepartureCustomOffice-Operations")]
        public CustomOffice DepartureCustomOffice
        {
            get => departureCustomOffice;
            set => SetPropertyValue(nameof(DepartureCustomOffice), ref departureCustomOffice, value);
        }

        [Association("ArrivalCustomOffice-Operations")]
        public CustomOffice ArrivalCustomOffice
        {
            get => arrivalCustomOffice;
            set => SetPropertyValue(nameof(ArrivalCustomOffice), ref arrivalCustomOffice, value);
        }

        [Association("ShippingTerm-Operations")]
        public ShippingTerm ShippingTerm
        {
            get => shippingTerm;
            set => SetPropertyValue(nameof(ShippingTerm), ref shippingTerm, value);
        }

        [Size(500), Nullable(true)]
        public string BookingNo
        {
            get => bookingNo;
            set => SetPropertyValue(nameof(BookingNo), ref bookingNo, value);
        }

        [Association("FreightPaymentType-Operations")]
        public FreightPaymentType FreightPaymentType
        {
            get => freightPaymentType;
            set => SetPropertyValue(nameof(FreightPaymentType), ref freightPaymentType, value);
        }

        [Nullable(true)]
        public Nullable<bool> IsTransit
        {
            get => ısTransit;
            set => SetPropertyValue(nameof(IsTransit), ref ısTransit, value);
        }

        [Size(500), Nullable(true)]
        public string InttraSı
        {
            get => ınttraSı;
            set => SetPropertyValue(nameof(InttraSı), ref ınttraSı, value);
        }

        [Size(500), Nullable(true)]
        public string InttraDocVer
        {
            get => ınttraDocVer;
            set => SetPropertyValue(nameof(InttraDocVer), ref ınttraDocVer, value);
        }

        [Size(500), Nullable(true)]
        public string InttraSiComm
        {
            get => ınttraSiComm;
            set => SetPropertyValue(nameof(InttraSiComm), ref ınttraSiComm, value);
        }

        [Association("LoadingType-Operations")]
        public LoadingType LoadingType
        {
            get => loadingType;
            set => SetPropertyValue(nameof(LoadingType), ref loadingType, value);
        }

        [Association("GoodType-Operations")]
        public GoodType GoodType
        {
            get => goodType;
            set => SetPropertyValue(nameof(GoodType), ref goodType, value);
        }

        [Association("ShippingServiceCode-Operations")]
        public ShippingServiceCode ShippingServiceCode
        {
            get => shippingServiceCode;
            set => SetPropertyValue(nameof(ShippingServiceCode), ref shippingServiceCode, value);
        }

        [Association("DeclarationType-Operations")]
        public DeclarationType DeclarationType
        {
            get => declarationType;
            set => SetPropertyValue(nameof(DeclarationType), ref declarationType, value);
        }

        [Association("ShipperCompany-Operations")]
        public Company ShipperCompany
        {
            get => shipperCompany;
            set => SetPropertyValue(nameof(ShipperCompany), ref shipperCompany, value);
        }

        [Association("ConsigneeCompany-Operations")]
        public Company ConsigneeCompany
        {
            get => consigneeCompany;
            set => SetPropertyValue(nameof(ConsigneeCompany), ref consigneeCompany, value);
        }

        [Association("ContractCompany-Operations")]
        public Company ContractCompany
        {
            get => contractCompany;
            set => SetPropertyValue(nameof(ContractCompany), ref contractCompany, value);
        }

        [Association("NationalShippingCompany-Operations")]
        public Company NationalShippingCompany
        {
            get => nationalShippingCompany;
            set => SetPropertyValue(nameof(NationalShippingCompany), ref nationalShippingCompany, value);
        }

        [Association("ShippingLineCompany-Operations")]
        public Company ShippingLineCompany
        {
            get => shippingLineCompany;
            set => SetPropertyValue(nameof(ShippingLineCompany), ref shippingLineCompany, value);
        }

        [Association("ShippingAgencyCompany-Operations")]
        public Company ShippingAgencyCompany
        {
            get => shippingAgency;
            set => SetPropertyValue(nameof(ShippingAgencyCompany), ref shippingAgency, value);
        }

        [Association("AbroadAgencyCompany-Operations")]
        public Company AbroadAgencyCompany
        {
            get => abroadAgency;
            set => SetPropertyValue(nameof(AbroadAgencyCompany), ref abroadAgency, value);
        }

        [Association("BillingCompany-Operations")]
        public Company BillingCompany
        {
            get => billingCompany;
            set => SetPropertyValue(nameof(BillingCompany), ref billingCompany, value);
        }

        [Association("RezervationCompany-Operations")]
        public Company RezervationCompany
        {
            get => rezervationCompany;
            set => SetPropertyValue(nameof(RezervationCompany), ref rezervationCompany, value);
        }

        [Association("SupplierCompany-Operations")]
        public Company SupplierCompany
        {
            get => supplierCompany;
            set => SetPropertyValue(nameof(SupplierCompany), ref supplierCompany, value);
        }

        [Nullable(true)]
        public Nullable<DateTime> OperationDate
        {
            get => operationDate;
            set => SetPropertyValue(nameof(OperationDate), ref operationDate, value);
        }

        [Nullable(true)]
        public Nullable<int> NumberofOriginalFBL
        {
            get => numberofOriginalFBL;
            set => SetPropertyValue(nameof(NumberofOriginalFBL), ref numberofOriginalFBL, value);
        }

        [Nullable(true)]
        public Nullable<int> NumberofCopyFBL
        {
            get => numberofCopyFBL;
            set => SetPropertyValue(nameof(NumberofCopyFBL), ref numberofCopyFBL, value);
        }

        [Association("DepartureLocation-Operations")]
        public Location DepartureLocation
        {
            get => departureLocation;
            set => SetPropertyValue(nameof(DepartureLocation), ref departureLocation, value);
        }


        [Association("LoadingPort-Operations")]
        public Port LoadingPort
        {
            get => loadingPort;
            set => SetPropertyValue(nameof(LoadingPort), ref loadingPort, value);
        }


        [Association("TransferLocation-Operations")]
        public Location TransferLocation
        {
            get => transferLocation;
            set => SetPropertyValue(nameof(TransferLocation), ref transferLocation, value);
        }


        [Association("LoadingCompany-Operations")]
        public Company LoadingCompany
        {
            get => loadingCompany;
            set => SetPropertyValue(nameof(LoadingCompany), ref loadingCompany, value);
        }

        [Nullable(true)]
        public Nullable<DateTime> LoadingDate
        {
            get => loadingDate;
            set => SetPropertyValue(nameof(LoadingDate), ref loadingDate, value);
        }


        [Association("TransferPort-Operations")]
        public Port TransferPort
        {
            get => transferPort;
            set => SetPropertyValue(nameof(TransferPort), ref transferPort, value);
        }

        [Nullable(true)]
        public DateTime TransferDate
        {
            get => transferDate;
            set => SetPropertyValue(nameof(TransferDate), ref transferDate, value);
        }


        [Association("ArrivalLocation-Operations")]
        public Location ArrivalLocation
        {
            get => arrivalLocation;
            set => SetPropertyValue(nameof(ArrivalLocation), ref arrivalLocation, value);
        }


        [Association("DeliveryType-Operations")]
        public DeliveryType DeliveryType
        {
            get => deliveryType;
            set => SetPropertyValue(nameof(DeliveryType), ref deliveryType, value);
        }


        [Association("SupplierPaymentType-Operations")]
        public PaymentType SupplierPaymentType
        {
            get => supplierPaymentType;
            set => SetPropertyValue(nameof(SupplierPaymentType), ref supplierPaymentType, value);
        }

        [Association("PaymentType-Operations")]
        public PaymentType PaymentType
        {
            get => paymentType;
            set => SetPropertyValue(nameof(PaymentType), ref paymentType, value);
        }


        [Association("AcceptanceLocation-Operations")]
        public Location AcceptanceLocation
        {
            get => acceptanceLocation;
            set => SetPropertyValue(nameof(AcceptanceLocation), ref acceptanceLocation, value);
        }


        [Association("DeliveryCompany-Operations")]
        public Company DeliveryCompany
        {
            get => deliveryCompany;
            set => SetPropertyValue(nameof(DeliveryCompany), ref deliveryCompany, value);
        }

        [Size(500), Nullable(true)]
        public string ContractNo
        {
            get => contractNo;
            set => SetPropertyValue(nameof(ContractNo), ref contractNo, value);
        }
        [Nullable(true)]
        public Nullable<DateTime> EstimatedDepartureDate
        {
            get => estimatedDepartureDate;
            set => SetPropertyValue(nameof(EstimatedDepartureDate), ref estimatedDepartureDate, value);
        }

        [Nullable(true)]
        public Nullable<DateTime> DepartureDate
        {
            get => departureDate;
            set => SetPropertyValue(nameof(DepartureDate), ref departureDate, value);
        }

        [Nullable(true)]
        public Nullable<DateTime> AcceptanceDate
        {
            get => acceptanceDate;
            set => SetPropertyValue(nameof(AcceptanceDate), ref acceptanceDate, value);
        }
        [Nullable(true)]
        public Nullable<DateTime> DeliveryDate
        {
            get => deliveryDate;
            set => SetPropertyValue(nameof(DeliveryDate), ref deliveryDate, value);
        }
        [Nullable(true)]
        public Nullable<DateTime> EstimatedArrivalDate
        {
            get => estimatedArrivalDate;
            set => SetPropertyValue(nameof(EstimatedArrivalDate), ref estimatedArrivalDate, value);
        }
        [Nullable(true)]
        public Nullable<DateTime> ArrivalDate
        {
            get => arrivalDate;
            set => SetPropertyValue(nameof(ArrivalDate), ref arrivalDate, value);
        }

        [Nullable(true)]
        public Nullable<int> EstimatedTransferTime
        {
            get => estimatedTransferTime;
            set => SetPropertyValue(nameof(EstimatedTransferTime), ref estimatedTransferTime, value);
        }

        [Nullable(true)]
        public Nullable<int> TransitTime
        {
            get => transitTime;
            set => SetPropertyValue(nameof(TransitTime), ref transitTime, value);
        }


        [Association("CustomerRepresentative-Operations")]
        public Employee CustomerRepresentative
        {
            get => customerRepresentative;
            set => SetPropertyValue(nameof(CustomerRepresentative), ref customerRepresentative, value);
        }

        [Association("SalesRepresentative-Operations")]
        public Employee SalesRepresentative
        {
            get => salesRepresentative;
            set => SetPropertyValue(nameof(SalesRepresentative), ref salesRepresentative, value);
        }


        [Size(500), Nullable(true)]
        public string RoroPlateNumber
        {
            get => roroPlateNumber;
            set => SetPropertyValue(nameof(RoroPlateNumber), ref roroPlateNumber, value);
        }


        [Size(500), Nullable(true)]
        public string VehiclePlateNumber
        {
            get => vehiclePlateNumber;
            set => SetPropertyValue(nameof(VehiclePlateNumber), ref vehiclePlateNumber, value);
        }


        [Association("PreCarriageCompany-Operations")]
        public Company PreCarriageCompany
        {
            get => preCarriageCompany;
            set => SetPropertyValue(nameof(PreCarriageCompany), ref preCarriageCompany, value);
        }


        [Association("PlaceofReceiptLocation-Operations")]
        public Location PlaceofReceiptLocation
        {
            get => placeofReceiptLocation;
            set => SetPropertyValue(nameof(PlaceofReceiptLocation), ref placeofReceiptLocation, value);
        }


        [Size(500), Nullable(true)]
        public string FreightChargersRatePer
        {
            get => freightChargersRatePer;
            set => SetPropertyValue(nameof(FreightChargersRatePer), ref freightChargersRatePer, value);
        }

        [Association("FolderPublishLocation-Operations")]
        public Location FolderPublishLocation
        {
            get => folderPublishLocation;
            set => SetPropertyValue(nameof(FolderPublishLocation), ref folderPublishLocation, value);
        }


        [Association("MainVessel-Operations")]
        public Vessel MainVessel
        {
            get => mainVessel;
            set => SetPropertyValue(nameof(MainVessel), ref mainVessel, value);
        }

        [Size(500), Nullable(true)]
        public string MainVesselVoyageNo
        {
            get => mainVesselVoyageNo;
            set => SetPropertyValue(nameof(MainVesselVoyageNo), ref mainVesselVoyageNo, value);
        }


        [Association("TransitVessel-Operations")]
        public Vessel TransitVessel
        {
            get => transitVessel;
            set => SetPropertyValue(nameof(TransitVessel), ref transitVessel, value);
        }


        [Size(500), Nullable(true)]
        public string TransitVesselVoyageNo
        {
            get => transitVesselVoyageNo;
            set => SetPropertyValue(nameof(TransitVesselVoyageNo), ref transitVesselVoyageNo, value);
        }


        [Association("DischargePort-Operations")]
        public Port DischargePort
        {
            get => dischargePort;
            set => SetPropertyValue(nameof(DischargePort), ref dischargePort, value);
        }

        [Size(500)]
        public string Status
        {
            get => status;
            set => SetPropertyValue(nameof(Status), ref status, value);
        }

        [Association("NotifyCompany-Operations")]
        public Company NotifyCompany
        {
            get => notifyCompany;
            set => SetPropertyValue(nameof(NotifyCompany), ref notifyCompany, value);
        }

        public TransportationTypes TransportationType
        {
            get => transportationType;
            set => SetPropertyValue(nameof(TransportationType), ref transportationType, value);
        }


        [Size(500)]
        public string OperationType
        {
            get => operationType;
            set => SetPropertyValue(nameof(OperationType), ref operationType, value);
        }

        public bool IsOpen
        {
            get => ısOpen;
            set => SetPropertyValue(nameof(IsOpen), ref ısOpen, value);
        }


        public bool IsMissing
        {
            get => ısMissing;
            set => SetPropertyValue(nameof(IsMissing), ref ısMissing, value);
        }

        [Size(500)]
        public string MissingInfo
        {
            get => missingInfo;
            set => SetPropertyValue(nameof(MissingInfo), ref missingInfo, value);
        }


        [Size(500), Nullable(true)]
        public string PlateNumber
        {
            get => plateNumber;
            set => SetPropertyValue(nameof(PlateNumber), ref plateNumber, value);
        }

        [Size(500), Nullable(true)]
        public string AtrNo
        {
            get => atrNo;
            set => SetPropertyValue(nameof(AtrNo), ref atrNo, value);
        }


        [Size(500), Nullable(true)]
        public string Ex1
        {
            get => ex1;
            set => SetPropertyValue(nameof(Ex1), ref ex1, value);
        }


        [Association("MainTruck-Operations")]
        public Truck MainTruck
        {
            get => mainTruck;
            set => SetPropertyValue(nameof(MainTruck), ref mainTruck, value);
        }


        [Association("TransitTruck-Operations")]
        public Truck TransitTruck
        {
            get => transitTruck;
            set => SetPropertyValue(nameof(TransitTruck), ref transitTruck, value);
        }


        [Association("MainDriver-Operations")]
        public Driver MainDriver
        {
            get => mainDriver;
            set => SetPropertyValue(nameof(MainDriver), ref mainDriver, value);
        }

        [Association("TransitDriver-Operations")]
        public Driver TransitDriver
        {
            get => transitDriver;
            set => SetPropertyValue(nameof(TransitDriver), ref transitDriver, value);
        }


        [Association("DepartureCustomCompany-Operations")]
        public Company DepartureCustomCompany
        {
            get => departureCustomCompany;
            set => SetPropertyValue(nameof(DepartureCustomCompany), ref departureCustomCompany, value);
        }

        [Association("ArrivalCustomCompany-Operations")]
        public Company ArrivalCustomCompany
        {
            get => arrivalCustomCompany;
            set => SetPropertyValue(nameof(ArrivalCustomCompany), ref arrivalCustomCompany, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Files
        {
            get => files;
            set => SetPropertyValue(nameof(Files), ref files, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string SupplierContractNotes
        {
            get => supplierContractNotes;
            set => SetPropertyValue(nameof(SupplierContractNotes), ref supplierContractNotes, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Notes
        {
            get => notes;
            set => SetPropertyValue(nameof(Notes), ref notes, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }



        [Association("Operation-Bills")]
        public XPCollection<Bill> Bills
        {
            get
            {
                return GetCollection<Bill>(nameof(Bills));
            }
        }
        [Association("Operation-Expenses")]
        public XPCollection<Expense> Expenses
        {
            get
            {
                return GetCollection<Expense>(nameof(Expenses));
            }
        }
        [Association("Operation-Goods")]
        public XPCollection<Good> Goods
        {
            get
            {
                return GetCollection<Good>(nameof(Goods));
            }
        }
        [Association("Operation-LoadingUnits")]
        public XPCollection<LoadingUnit> LoadingUnits
        {
            get
            {
                return GetCollection<LoadingUnit>(nameof(LoadingUnits));
            }
        }
        [Association("Operation-IncomeBills")]
        public XPCollection<IncomeBill> IncomeBills
        {
            get
            {
                return GetCollection<IncomeBill>(nameof(IncomeBills));
            }
        }

        [Association("Operation-Mailings")]
        public XPCollection<Mailing> Mailings
        {
            get
            {
                return GetCollection<Mailing>(nameof(Mailings));
            }
        }
        [Association("Operation-OperationActions")]
        public XPCollection<OperationAction> OperationActions
        {
            get
            {
                return GetCollection<OperationAction>(nameof(OperationActions));
            }
        }
    }

    public enum TransportationTypes
    {
        Landway =0,
         SeaWay =1,
         Airway =2,
         Railway =3,
         Others =4,

    }
}