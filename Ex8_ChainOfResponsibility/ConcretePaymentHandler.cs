﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex8_ChainOfResponsibility
{
    class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
                Console.WriteLine("Выполняем банковский перевод");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }

    class MoneyPaymentHandler : PaymentHandler
    {

        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true)
                Console.WriteLine("Выполняем перевод через системы денежных переводов");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }

    class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true)
                Console.WriteLine("Выполняем перевод через системы денежных переводов");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
