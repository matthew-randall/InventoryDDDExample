using System;

namespace Inventory.WPF.UI.Credits.EventArguments
{
    public class OnSelectedCreditEventArgs : EventArgs
    {
        private readonly Guid _creditId;

        public OnSelectedCreditEventArgs(Guid creditId)
        {
            _creditId = creditId;
        }

        public Guid CreditId
        {
            get { return _creditId; }
        }
    }
}
