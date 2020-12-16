using System;
using System.Collections.Generic;
using System.Text;

namespace Ex8_ChainOfResponsibility
{
    abstract class PaymentHandler
    {
        public PaymentHandler Successor { get; set; }
        public abstract void Handle(Receiver receiver);
    }


}
