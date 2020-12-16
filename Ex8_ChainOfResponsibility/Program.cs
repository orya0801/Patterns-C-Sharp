/*
 * В данной практической работе был реализован паттерн цепочка обязанностей.
 * Реализованный пример демонстриует возомжность обработки различных запросов
 * несколькими способами при условии, заранее неизвестно, какие конкретно запросы будут 
 * приходить и какие обработчики для них понадобятся.
 * Также данный паттерн применим, когда необходимо выполнить обработчик в строгом порядке
 * один за одним.
 * Этот паттерн позволяет гибко управлять набором объектов, обрабатывающих запрос. Можно
 * легко вмешаться в цепочку, чтобы добавить или убрать новое звено. 
 * 
 */


using System;

namespace Ex8_ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(false, true, true);

            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHnadler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();

            bankPaymentHandler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = moneyPaymentHnadler;

            bankPaymentHandler.Handle(receiver);
        }
    }
}
