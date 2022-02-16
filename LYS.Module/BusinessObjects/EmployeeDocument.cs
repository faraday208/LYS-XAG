using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;

namespace LYS.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class EmployeeDocument : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public EmployeeDocument(Session session)
            : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string details;
        private Nullable<DateTime> expirationDate;
        private Nullable<DateTime> givenDate;
        private string file;
        private string serial;
        private string title;
        private Reminder reminder;
        private Employee employee;

        [Association("Employee-EmployeeDocuments")]
        public Employee Employee
        {
            get => employee;
            set => SetPropertyValue(nameof(Employee), ref employee, value);
        }

        [Association("Reminder-EmployeeDocuments")]
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

        [Nullable(true)]
        public Nullable<DateTime> GivenDate
        {
            get => givenDate;
            set => SetPropertyValue(nameof(GivenDate), ref givenDate, value);
        }

        [Nullable(true)]
        public Nullable<DateTime> ExpirationDate
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