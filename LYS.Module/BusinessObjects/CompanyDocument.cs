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
    public class CompanyDocument : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public CompanyDocument(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        string details;
        DateTime expirationDate;
        DateTime givenDate;
        string file;
        string serial;
        string title;
        Reminder reminder;
        Company company;

        [Association("Company-CompanyDocuments")]
        public Company Company
        {
            get => company;
            set => SetPropertyValue(nameof(Company), ref company, value);
        }


        [Association("Reminder-CompanyDocuments")]
        public Reminder Reminder
        {
            get => reminder;
            set => SetPropertyValue(nameof(Reminder), ref reminder, value);
        }


        [Size(500), Nullable(true)]
        public string Title
        {
            get => title;
            set => SetPropertyValue(nameof(Title), ref title, value);
        }


        [Size(500), Nullable(true)]
        public string Serial
        {
            get => serial;
            set => SetPropertyValue(nameof(Serial), ref serial, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string File
        {
            get => file;
            set => SetPropertyValue(nameof(File), ref file, value);
        }


        public DateTime GivenDate
        {
            get => givenDate;
            set => SetPropertyValue(nameof(GivenDate), ref givenDate, value);
        }


        public DateTime ExpirationDate
        {
            get => expirationDate;
            set => SetPropertyValue(nameof(ExpirationDate), ref expirationDate, value);
        }

        
        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }

    }
}