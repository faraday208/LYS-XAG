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
    [Persistent("Companies")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Company : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Company(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }



        Sector sector;
        CompanyClass companyClassJson;
        string details;
        string relatedCountries;
        PaymentType paymentType;
        string taxProvince;
        string taxNo;
        string mail;
        string fax;
        string phone;
        Country country;
        string postalCode;
        string region;
        string city;
        string adress;
        string contactName;
        string code;
        string name;

        [Size(2500)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }


        [Size(500)]
        public string Code
        {
            get => code;
            set => SetPropertyValue(nameof(Code), ref code, value);
        }


        [Size(500), Nullable(true)]
        public string ContactName
        {
            get => contactName;
            set => SetPropertyValue(nameof(ContactName), ref contactName, value);
        }


        [Size(2500), Nullable(true)]
        public string Adress
        {
            get => adress;
            set => SetPropertyValue(nameof(Adress), ref adress, value);
        }

        [Size(250), Nullable(true)]
        public string City
        {
            get => city;
            set => SetPropertyValue(nameof(City), ref city, value);
        }


        [Size(150), Nullable(true)]
        public string Region
        {
            get => region;
            set => SetPropertyValue(nameof(Region), ref region, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize), System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.PostalCode), Nullable(true)]
        public string PostalCode
        {
            get => postalCode;
            set => SetPropertyValue(nameof(PostalCode), ref postalCode, value);
        }


        [Association("Country-Companies")]
        public Country Country
        {
            get => country;
            set => SetPropertyValue(nameof(Country), ref country, value);
        }


        [Size(240), Nullable(true)]
        public string Phone
        {
            get => phone;
            set => SetPropertyValue(nameof(Phone), ref phone, value);
        }


        [Size(240), Nullable(true)]
        public string Fax
        {
            get => fax;
            set => SetPropertyValue(nameof(Fax), ref fax, value);
        }



        [Size(240), Nullable(true)]
        public string Mail
        {
            get => mail;
            set => SetPropertyValue(nameof(Mail), ref mail, value);
        }

        [Size(500), Nullable(true)]
        public string TaxNo
        {
            get => taxNo;
            set => SetPropertyValue(nameof(TaxNo), ref taxNo, value);
        }


        [Size(500), Nullable(true)]
        public string TaxProvince
        {
            get => taxProvince;
            set => SetPropertyValue(nameof(TaxProvince), ref taxProvince, value);
        }


        [Association("PaymentType-Companies")]
        public PaymentType PaymentType
        {
            get => paymentType;
            set => SetPropertyValue(nameof(PaymentType), ref paymentType, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string RelatedCountries
        {
            get => relatedCountries;
            set => SetPropertyValue(nameof(RelatedCountries), ref relatedCountries, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }


        [Association("CompanyClass-Companies")]
        public CompanyClass CompanyClassJson
        {
            get => companyClassJson;
            set => SetPropertyValue(nameof(CompanyClassJson), ref companyClassJson, value);
        }

        [Association("Sector-Companies")]
        public Sector Sector
        {
            get => sector;
            set => SetPropertyValue(nameof(Sector), ref sector, value);
        }


        [Association("Company-Bills")]
        public XPCollection<Bill> Bills
        {
            get
            {
                return GetCollection<Bill>(nameof(Bills));
            }
        }

        [Association("Company-CompanyAccounts")]
        public XPCollection<CompanyAccount> CompanyAccounts
        {
            get
            {
                return GetCollection<CompanyAccount>(nameof(CompanyAccounts));
            }
        }
        [Association("Company-CompanyDocuments")]
        public XPCollection<CompanyDocument> CompanyDocuments
        {
            get
            {
                return GetCollection<CompanyDocument>(nameof(CompanyDocuments));
            }
        }

        [Association("Company-Contacts")]
        public XPCollection<Contact> Contacts
        {
            get
            {
                return GetCollection<Contact>(nameof(Contacts));
            }
        }
        [Association("Company-BidCompanies")]
        public XPCollection<BidCompany> BidCompanies
        {
            get
            {
                return GetCollection<BidCompany>(nameof(BidCompanies));
            }
        }

        [Association("ContractCompany-Bids")]
        public XPCollection<Bid> ContractCompanyBids
        {
            get
            {
                return GetCollection<Bid>(nameof(ContractCompanyBids));
            }
        }
        [Association("ShipperCompany-Bids")]
        public XPCollection<Bid> ShipperCompanyBids
        {
            get
            {
                return GetCollection<Bid>(nameof(ShipperCompanyBids));
            }
        }
        [Association("NotifyCompany-Bids")]
        public XPCollection<Bid> NotifyCompanyBids
        {
            get
            {
                return GetCollection<Bid>(nameof(NotifyCompanyBids));
            }
        }
        [Association("ConsigneeCompany-Bids")]
        public XPCollection<Bid> ConsigneeCompanyBids
        {
            get
            {
                return GetCollection<Bid>(nameof(ConsigneeCompanyBids));
            }
        }
        [Association("LoadingCompany-Bids")]
        public XPCollection<Bid> LoadingCompanyBids
        {
            get
            {
                return GetCollection<Bid>(nameof(LoadingCompanyBids));
            }
        }

        [Association("ShipperCompany-Operations")]
        public XPCollection<Position> ShipperCompanyOperations
        {
            get
            {
                return GetCollection<Position>(nameof(ShipperCompanyOperations));
            }
        }
        [Association("ConsigneeCompany-Operations")]
        public XPCollection<Position> ConsigneeCompanyOperations
        {
            get
            {
                return GetCollection<Position>(nameof(ConsigneeCompanyOperations));
            }
        }
        [Association("ContractCompany-Operations")]
        public XPCollection<Position> ContractCompanyOperations
        {
            get
            {
                return GetCollection<Position>(nameof(ContractCompanyOperations));
            }
        }
        [Association("NationalShippingCompany-Operations")]
        public XPCollection<Position> NationalShippingCompanyOperations
        {
            get
            {
                return GetCollection<Position>(nameof(NationalShippingCompanyOperations));
            }
        }
        [Association("ShippingLineCompany-Operations")]
        public XPCollection<Position> ShippingLineCompanyOperations
        {
            get
            {
                return GetCollection<Position>(nameof(ShippingLineCompanyOperations));
            }
        }
        [Association("ShippingAgencyCompany-Operations")]
        public XPCollection<Position> ShippingAgencyCompanyOperations
        {
            get
            {
                return GetCollection<Position>(nameof(ShippingAgencyCompanyOperations));
            }
        }
        [Association("AbroadAgencyCompany-Operations")]
        public XPCollection<Position> AbroadAgencyCompanyOperations
        {
            get
            {
                return GetCollection<Position>(nameof(AbroadAgencyCompanyOperations));
            }
        }

        [Association("BillingCompany-Operations")]
        public XPCollection<Position> BillingCompanyOperations
        {
            get
            {
                return GetCollection<Position>(nameof(BillingCompanyOperations));
            }
        }
        [Association("RezervationCompany-Operations")]
        public XPCollection<Position> RezervationCompanyOperations
        {
            get
            {
                return GetCollection<Position>(nameof(RezervationCompanyOperations));
            }
        }
        [Association("SupplierCompany-Operations")]
        public XPCollection<Position> SupplierCompanyOperations
        {
            get
            {
                return GetCollection<Position>(nameof(SupplierCompanyOperations));
            }
        }
        [Association("LoadingCompany-Operations")]
        public XPCollection<Position> LoadingCompanyOperations
        {
            get
            {
                return GetCollection<Position>(nameof(LoadingCompanyOperations));
            }
        }
        [Association("DeliveryCompany-Operations")]
        public XPCollection<Position> DeliveryCompanyOperations
        {
            get
            {
                return GetCollection<Position>(nameof(DeliveryCompanyOperations));
            }
        }
        [Association("PreCarriageCompany-Operations")]
        public XPCollection<Position> PreCarriageCompanyOperations
        {
            get
            {
                return GetCollection<Position>(nameof(PreCarriageCompanyOperations));
            }
        }
        [Association("NotifyCompany-Operations")]
        public XPCollection<Position> NotifyCompanyOperations
        {
            get
            {
                return GetCollection<Position>(nameof(NotifyCompanyOperations));
            }
        }

        [Association("DepartureCustomCompany-Operations")]
        public XPCollection<Position> DepartureCustomCompanyOperations
        {
            get
            {
                return GetCollection<Position>(nameof(DepartureCustomCompanyOperations));
            }
        }
        [Association("ArrivalCustomCompany-Operations")]
        public XPCollection<Position> ArrivalCustomCompanyOperations
        {
            get
            {
                return GetCollection<Position>(nameof(ArrivalCustomCompanyOperations));
            }
        }
        [Association("Company-Vessels")]
        public XPCollection<Vessel> Vessels
        {
            get
            {
                return GetCollection<Vessel>(nameof(Vessels));
            }
        }
        [Association("Company-Trucks")]
        public XPCollection<Truck> Trucks
        {
            get
            {
                return GetCollection<Truck>(nameof(Trucks));
            }
        }
        [Association("Company-Drivers")]
        public XPCollection<Driver> Drivers
        {
            get
            {
                return GetCollection<Driver>(nameof(Drivers));
            }
        }

        [Association("Company-Interviews")]
        public XPCollection<Interview> Interviews
        {
            get
            {
                return GetCollection<Interview>(nameof(Interviews));
            }
        }
        [Association("ReferenceCompany-Interviews")]
        public XPCollection<Interview> ReferenceCompanyInterviews
        {
            get
            {
                return GetCollection<Interview>(nameof(ReferenceCompanyInterviews));
            }
        }
        [Association("Company-Expenses")]
        public XPCollection<Expense> Expenses
        {
            get
            {
                return GetCollection<Expense>(nameof(Expenses));
            }
        }
        [Association("Company-Goods")]
        public XPCollection<Good> Goods
        {
            get
            {
                return GetCollection<Good>(nameof(Goods));
            }
        }
        [Association("Company-IncomeBills")]
        public XPCollection<IncomeBill> IncomeBills
        {
            get
            {
                return GetCollection<IncomeBill>(nameof(IncomeBills));
            }
        }
    }
}