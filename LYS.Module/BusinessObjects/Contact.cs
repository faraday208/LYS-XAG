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
    public class Contact : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Contact(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).

        }

        string details;
        string mail2;
        string mail;
        string phone2;
        string phone;
        string langugage;
        string lastname;
        string name;
        string title;
        Company company;

        [Association("Company-Contacts")]
        public Company Company
        {
            get => company;
            set => SetPropertyValue(nameof(Company), ref company, value);
        }


        [Size(2500), Nullable(true)]
        public string Title
        {
            get => title;
            set => SetPropertyValue(nameof(Title), ref title, value);
        }


        [Size(500), Nullable(true)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }


        [Size(500), Nullable(true)]
        public string Lastname
        {
            get => lastname;
            set => SetPropertyValue(nameof(Lastname), ref lastname, value);
        }


        [Size(500), Nullable(true)]
        public string Langugage
        {
            get => langugage;
            set => SetPropertyValue(nameof(Langugage), ref langugage, value);
        }


        [Size(240), Nullable(true)]
        public string Phone
        {
            get => phone;
            set => SetPropertyValue(nameof(Phone), ref phone, value);
        }
        [Size(240), Nullable(true)]
        public string Phone2
        {
            get => phone2;
            set => SetPropertyValue(nameof(Phone2), ref phone2, value);
        }


        [Size(255), Nullable(true)]
        public string Mail
        {
            get => mail;
            set => SetPropertyValue(nameof(Mail), ref mail, value);
        }

        [Size(255), Nullable(true)]
        public string Mail2
        {
            get => mail2;
            set => SetPropertyValue(nameof(Mail2), ref mail2, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }

        //[Association("Contact-Companies")]
        //public XPCollection<Company> Companies
        //{
        //    get
        //    {
        //        return GetCollection<Company>(nameof(Companies));
        //    }
        //}
    }
}