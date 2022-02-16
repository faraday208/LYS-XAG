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
    public class Mailing : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Mailing(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        Nullable<DateTime> sentDate;
        bool ısHtml;
        bool ısBulk;
        bool hasSent;
        DateTime sendDate;
        string url;
        string body;
        string subject;
        string bccs;
        string ccs;
        string to;
        string from;
        Position relatedOperation;
        string relatedTable;
        string category;

        [Size(50)]
        public string Category
        {
            get => category;
            set => SetPropertyValue(nameof(Category), ref category, value);
        }

        [Size(50), Nullable(true)]
        public string RelatedTable
        {
            get => relatedTable;
            set => SetPropertyValue(nameof(RelatedTable), ref relatedTable, value);
        }

        [Association("Operation-Mailings")]
        public Position RelatedOperation
        {
            get => relatedOperation;
            set => SetPropertyValue(nameof(RelatedOperation), ref relatedOperation, value);
        }


        [Size(2048), Nullable(true)]
        public string From
        {
            get => from;
            set => SetPropertyValue(nameof(From), ref from, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string To
        {
            get => to;
            set => SetPropertyValue(nameof(To), ref to, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Ccs
        {
            get => ccs;
            set => SetPropertyValue(nameof(Ccs), ref ccs, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Bccs
        {
            get => bccs;
            set => SetPropertyValue(nameof(Bccs), ref bccs, value);
        }


        [Size(2048), Nullable(true)]
        public string Subject
        {
            get => subject;
            set => SetPropertyValue(nameof(Subject), ref subject, value);
        }

        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Body
        {
            get => body;
            set => SetPropertyValue(nameof(Body), ref body, value);
        }


        [Size(SizeAttribute.Unlimited), Nullable(true)]
        public string Url
        {
            get => url;
            set => SetPropertyValue(nameof(Url), ref url, value);
        }


        public DateTime SendDate
        {
            get => sendDate;
            set => SetPropertyValue(nameof(SendDate), ref sendDate, value);
        }

        public bool HasSent
        {
            get => hasSent;
            set => SetPropertyValue(nameof(HasSent), ref hasSent, value);
        }

        public bool IsBulk
        {
            get => ısBulk;
            set => SetPropertyValue(nameof(IsBulk), ref ısBulk, value);
        }

        public bool IsHtml
        {
            get => ısHtml;
            set => SetPropertyValue(nameof(IsHtml), ref ısHtml, value);
        }
        [Nullable(true)]
        public Nullable<DateTime> SentDate
        {
            get => sentDate;
            set => SetPropertyValue(nameof(SentDate), ref sentDate, value);
        }
    }
}