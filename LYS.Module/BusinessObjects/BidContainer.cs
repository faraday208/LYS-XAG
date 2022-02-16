using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace LYS.Module.BusinessObjects
{
    [DefaultClassOptions]

    public class BidContainer : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public BidContainer(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        Container container;
        Bid bid;

        [Association("Bid-BidContainers")]
        public Bid Bid
        {
            get => bid;
            set => SetPropertyValue(nameof(Bid), ref bid, value);
        }


        [Association("Container-BidContainers")]
        public Container CreationTime
        {
            get => container;
            set => SetPropertyValue(nameof(CreationTime), ref container, value);
        }

    }
}