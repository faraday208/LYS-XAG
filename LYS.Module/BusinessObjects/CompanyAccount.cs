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
    public class CompanyAccount : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public CompanyAccount(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        string details;
        string swiftCode;
        string ıban;
        string accountNumber;
        string branchCode;
        string branch;
        string bank;
        string title;
        Currency currency;
        Company company;

        [Association("Company-CompanyAccounts")]
        public Company Company
        {
            get => company;
            set => SetPropertyValue(nameof(Company), ref company, value);
        }


        [Association("Currency-CompanyAccounts")]
        public Currency Currency
        {
            get => currency;
            set => SetPropertyValue(nameof(Currency), ref currency, value);
        }

        [Size(500), Nullable(true)]
        public string Title
        {
            get => title;
            set => SetPropertyValue(nameof(Title), ref title, value);
        }


        [Size(500), Nullable(true)]
        public string Bank
        {
            get => bank;
            set => SetPropertyValue(nameof(Bank), ref bank, value);
        }


        [Size(500), Nullable(true)]
        public string Branch
        {
            get => branch;
            set => SetPropertyValue(nameof(Branch), ref branch, value);
        }
        [Size(500), Nullable(true)]
        public string BranchCode
        {
            get => branchCode;
            set => SetPropertyValue(nameof(BranchCode), ref branchCode, value);
        }


        [Size(500), Nullable(true)]
        public string AccountNumber
        {
            get => accountNumber;
            set => SetPropertyValue(nameof(AccountNumber), ref accountNumber, value);
        }


        [Size(500), Nullable(true)]
        public string Iban
        {
            get => ıban;
            set => SetPropertyValue(nameof(Iban), ref ıban, value);
        }


        [Size(240), Nullable(true)]
        public string SwiftCode
        {
            get => swiftCode;
            set => SetPropertyValue(nameof(SwiftCode), ref swiftCode, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }
    }
}