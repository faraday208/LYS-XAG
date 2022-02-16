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
    public class Reminder : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Reminder(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        int groupID;
        string details;
        string textColor;
        string borderColor;
        string backgroundColor;
        bool ısOVerlap;
        string rendering;
        bool ısResourceEditable;
        bool ısDurationEditable;
        bool ısStartEditable;
        bool ısEditable;
        string classNames;
        string mails;
        string url;
        DateTime end;
        DateTime start;
        bool isAllDay;
        string title;

        [Size(SizeAttribute.Unlimited)]
        public string Title
        {
            get => title;
            set => SetPropertyValue(nameof(Title), ref title, value);
        }

        public bool IsAllDay
        {
            get => isAllDay;
            set => SetPropertyValue(nameof(IsAllDay), ref isAllDay, value);
        }


        public int GroupID
        {
            get => groupID;
            set => SetPropertyValue(nameof(GroupID), ref groupID, value);
        }


        public DateTime Start
        {
            get => start;
            set => SetPropertyValue(nameof(Start), ref start, value);
        }


        public DateTime End
        {
            get => end;
            set => SetPropertyValue(nameof(End), ref end, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Url
        {
            get => url;
            set => SetPropertyValue(nameof(Url), ref url, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Mails
        {
            get => mails;
            set => SetPropertyValue(nameof(Mails), ref mails, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string ClassNames
        {
            get => classNames;
            set => SetPropertyValue(nameof(ClassNames), ref classNames, value);
        }


        public bool IsEditable
        {
            get => ısEditable;
            set => SetPropertyValue(nameof(IsEditable), ref ısEditable, value);
        }

        public bool IsStartEditable
        {
            get => ısStartEditable;
            set => SetPropertyValue(nameof(IsStartEditable), ref ısStartEditable, value);
        }

        public bool IsDurationEditable
        {
            get => ısDurationEditable;
            set => SetPropertyValue(nameof(IsDurationEditable), ref ısDurationEditable, value);
        }

        public bool IsResourceEditable
        {
            get => ısResourceEditable;
            set => SetPropertyValue(nameof(IsResourceEditable), ref ısResourceEditable, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Rendering
        {
            get => rendering;
            set => SetPropertyValue(nameof(Rendering), ref rendering, value);
        }


        public bool IsOVerlap
        {
            get => ısOVerlap;
            set => SetPropertyValue(nameof(IsOVerlap), ref ısOVerlap, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string BackgroundColor
        {
            get => backgroundColor;
            set => SetPropertyValue(nameof(BackgroundColor), ref backgroundColor, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string BorderColor
        {
            get => borderColor;
            set => SetPropertyValue(nameof(BorderColor), ref borderColor, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string TextColor
        {
            get => textColor;
            set => SetPropertyValue(nameof(TextColor), ref textColor, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }

        [Association("Reminder-CompanyDocuments")]
        public XPCollection<CompanyDocument> CompanyDocuments
        {
            get
            {
                return GetCollection<CompanyDocument>(nameof(CompanyDocuments));
            }
        }
        [Association("Reminder-EmployeeDocuments")]
        public XPCollection<EmployeeDocument> EmployeeDocuments
        {
            get
            {
                return GetCollection<EmployeeDocument>(nameof(EmployeeDocuments));
            }
        }
        [Association("Reminder-InterviewReminders")]
        public XPCollection<InterviewReminder> InterviewReminders
        {
            get
            {
                return GetCollection<InterviewReminder>(nameof(InterviewReminders));
            }
        }
    }
}