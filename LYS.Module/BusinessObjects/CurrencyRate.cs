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
    public class CurrencyRate : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public CurrencyRate(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        decimal banknoteSelling;
        decimal banknoteBuying;
        decimal forexSelling;
        decimal forexBuying;
        Currency currency;

        [Association("Currency-CurrencyRates")]
        public Currency Currency
        {
            get => currency;
            set => SetPropertyValue(nameof(Currency), ref currency, value);
        }


        public decimal ForexBuying
        {
            get => forexBuying;
            set => SetPropertyValue(nameof(ForexBuying), ref forexBuying, value);
        }


        public decimal ForexSelling
        {
            get => forexSelling;
            set => SetPropertyValue(nameof(ForexSelling), ref forexSelling, value);
        }

        public decimal BanknoteBuying
        {
            get => banknoteBuying;
            set => SetPropertyValue(nameof(BanknoteBuying), ref banknoteBuying, value);
        }


        public decimal BanknoteSelling
        {
            get => banknoteSelling;
            set => SetPropertyValue(nameof(BanknoteSelling), ref banknoteSelling, value);
        }

    }
}