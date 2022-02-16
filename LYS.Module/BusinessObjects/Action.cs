using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace LYS.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Action : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Action(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        string fDetails;
        string fTitle;
        public string Title
        {
            get { return fTitle; }
            set { SetPropertyValue<string>(nameof(Title), ref fTitle, value); }
        }
        [Nullable(true), Size(SizeAttribute.Unlimited)]
        public string Details
        {
            get { return fDetails; }
            set { SetPropertyValue<string>(nameof(Details), ref fDetails, value); }
        }

        [Association("Action-OperationActions")]
        public XPCollection<OperationAction> OperationActions
        {
            get
            {
                return GetCollection<OperationAction>(nameof(OperationActions));
            }
        }

    }
}