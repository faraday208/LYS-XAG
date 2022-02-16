using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;

namespace LYS.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Error : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Error(Session session)
            : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string errorMessage;
        private int errorLine;
        private string errorProcedure;
        private int errorState;
        private int errorSeverity;
        private int errorNumber;
        private string operation;
        private string tableName;

        [Size(50), Nullable(true)]
        public string TableName
        {
            get => tableName;
            set => SetPropertyValue(nameof(TableName), ref tableName, value);
        }

        [Size(50), Nullable(true)]
        public string Operation
        {
            get => operation;
            set => SetPropertyValue(nameof(Operation), ref operation, value);
        }

        [Nullable(true)]
        public int ErrorNumber
        {
            get => errorNumber;
            set => SetPropertyValue(nameof(ErrorNumber), ref errorNumber, value);
        }

        [Nullable(true)]
        public int ErrorSeverity
        {
            get => errorSeverity;
            set => SetPropertyValue(nameof(ErrorSeverity), ref errorSeverity, value);
        }

        [Nullable(true)]
        public int ErrorState
        {
            get => errorState;
            set => SetPropertyValue(nameof(ErrorState), ref errorState, value);
        }

        [Size(128), Nullable(true)]
        public string ErrorProcedure
        {
            get => errorProcedure;
            set => SetPropertyValue(nameof(ErrorProcedure), ref errorProcedure, value);
        }

        [Nullable(true)]
        public int ErrorLine
        {
            get => errorLine;
            set => SetPropertyValue(nameof(ErrorLine), ref errorLine, value);
        }

        [Size(4000), Nullable(true)]
        public string ErrorMessage
        {
            get => errorMessage;
            set => SetPropertyValue(nameof(ErrorMessage), ref errorMessage, value);
        }
    }
}