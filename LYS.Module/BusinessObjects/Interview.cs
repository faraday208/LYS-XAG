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
    public class Interview : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Interview(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string files;
        string checklist;
        string result;
        string notes;
        string meetingType;
        DateTime meetingDate;
        bool ısIncoming;
        InterviewSource ınterviewSource;
        Company referenceCompany;
        Company company;
        string category;

        [Size(50), Nullable(true)]
        public string Category
        {
            get => category;
            set => SetPropertyValue(nameof(Category), ref category, value);
        }


        [Association("Company-Interviews")]
        public Company Company
        {
            get => company;
            set => SetPropertyValue(nameof(Company), ref company, value);
        }

        [Association("ReferenceCompany-Interviews")]
        public Company ReferenceCompany
        {
            get => referenceCompany;
            set => SetPropertyValue(nameof(ReferenceCompany), ref referenceCompany, value);
        }



        [Association("InterviewSource-Interviews")]
        public InterviewSource InterviewSource
        {
            get => ınterviewSource;
            set => SetPropertyValue(nameof(InterviewSource), ref ınterviewSource, value);
        }


        public bool IsIncoming
        {
            get => ısIncoming;
            set => SetPropertyValue(nameof(IsIncoming), ref ısIncoming, value);
        }

        public DateTime MeetingDate
        {
            get => meetingDate;
            set => SetPropertyValue(nameof(MeetingDate), ref meetingDate, value);
        }

        [Size(50), Nullable(true)]
        public string MeetingType
        {
            get => meetingType;
            set => SetPropertyValue(nameof(MeetingType), ref meetingType, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Notes
        {
            get => notes;
            set => SetPropertyValue(nameof(Notes), ref notes, value);
        }

        [Size(50), Nullable(true)]
        public string Result
        {
            get => result;
            set => SetPropertyValue(nameof(Result), ref result, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Checklist
        {
            get => checklist;
            set => SetPropertyValue(nameof(Checklist), ref checklist, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Files
        {
            get => files;
            set => SetPropertyValue(nameof(Files), ref files, value);
        }

        [Association("Interview-InterviewReminders")]
        public XPCollection<InterviewReminder> InterviewReminders
        {
            get
            {
                return GetCollection<InterviewReminder>(nameof(InterviewReminders));
            }
        }
    }
}