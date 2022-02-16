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
    public class Employee : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Employee(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        string details;
        int mailPort;
        string mailPassword;
        string mailUsername;
        string mailServer;
        string mail;
        string phone;
        string password;
        string username;
        string duty;
        Department department;
        string name;

        [Size(100)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }

        [Association("Department-Employees")]
        public Department Department
        {
            get => department;
            set => SetPropertyValue(nameof(Department), ref department, value);
        }

        [Size(50)]
        public string Duty
        {
            get => duty;
            set => SetPropertyValue(nameof(Duty), ref duty, value);
        }


        [Size(50), Nullable(true)]
        public string Username
        {
            get => username;
            set => SetPropertyValue(nameof(Username), ref username, value);
        }


        [Size(50), Nullable(true)]
        public string Password
        {
            get => password;
            set => SetPropertyValue(nameof(Password), ref password, value);
        }

        [Size(20), Nullable(true)]
        public string Phone
        {
            get => phone;
            set => SetPropertyValue(nameof(Phone), ref phone, value);
        }

        [Size(255)]
        public string Mail
        {
            get => mail;
            set => SetPropertyValue(nameof(Mail), ref mail, value);
        }


        [Size(255), Nullable(true)]
        public string MailServer
        {
            get => mailServer;
            set => SetPropertyValue(nameof(MailServer), ref mailServer, value);
        }

        [Size(255), Nullable(true)]
        public string MailUsername
        {
            get => mailUsername;
            set => SetPropertyValue(nameof(MailUsername), ref mailUsername, value);
        }


        [Size(255), Nullable(true)]
        public string MailPassword
        {
            get => mailPassword;
            set => SetPropertyValue(nameof(MailPassword), ref mailPassword, value);
        }


        public int MailPort
        {
            get => mailPort;
            set => SetPropertyValue(nameof(MailPort), ref mailPort, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Details
        {
            get => details;
            set => SetPropertyValue(nameof(Details), ref details, value);
        }

        [Association("CustomerRepresentative-Bids")]
        public XPCollection<Bid> CustomerRepresentativeBids
        {
            get
            {
                return GetCollection<Bid>(nameof(CustomerRepresentativeBids));
            }
        }
        [Association("SaleRepresentative-Bids")]
        public XPCollection<Bid> SaleRepresentativeBids
        {
            get
            {
                return GetCollection<Bid>(nameof(SaleRepresentativeBids));
            }
        }

        [Association("CustomerRepresentative-Operations")]
        public XPCollection<Position> CustomerRepresentativeOperations
        {
            get
            {
                return GetCollection<Position>(nameof(CustomerRepresentativeOperations));
            }
        }
        [Association("SalesRepresentative-Operations")]
        public XPCollection<Position> SalesRepresentativeOperations
        {
            get
            {
                return GetCollection<Position>(nameof(SalesRepresentativeOperations));
            }
        }
        [Association("Employee-EmployeeDocuments")]
        public XPCollection<EmployeeDocument> EmployeeDocuments
        {
            get
            {
                return GetCollection<EmployeeDocument>(nameof(EmployeeDocuments));
            }
        }   
        [Association("Employee-EmployeeAccounts")]
        public XPCollection<EmployeeAccount> EmployeeAccounts
        {
            get
            {
                return GetCollection<EmployeeAccount>(nameof(EmployeeAccounts));
            }
        }
    }
    }