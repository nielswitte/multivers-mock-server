using Multivers.Api.Contracts;
using Multivers.Api.Enums;
using System;

namespace Multivers.Api.Responses
{
    public class InvoiceInfoResponse : MultiversResponse
    {
        public string City { get; set; }
        public string ContactPerson { get; set; }
        public bool ContainsCustomProperties { get; set; }

        public decimal CreditSqueezeRemaining { get; set; }
        public decimal CreditSqueezeRemainingCur { get; set; }
        public string CurrencyDescription { get; set; }
        public string CurrencyId { get; set; }
        public decimal CurrentExchangeRate { get; set; }
        public int DaysOld { get; set; }
        public decimal ExchangeRate { get; set; }
        public int FiscalYear { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal InvoiceAmountCur { get; set; }
        public decimal InvoiceBalance { get; set; }
        public decimal InvoiceBalanceCur { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime InvoiceExpirationDate { get; set; }
        public string InvoiceId { get; set; }
        public string InvoiceReference { get; set; }
        public bool IsAdvance { get; set; }
        public string Name { get; set; }
        public string PaymentConditionId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentReference { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RebateExpirationDate { get; set; }
        public decimal RebateRemaining { get; set; }
        public decimal RebateRemainingCur { get; set; }
        public int ReminderCount { get; set; }
        public decimal SettledAmount { get; set; }
        public string ShortName { get; set; }
        public InvoiceState State { get; set; }
        public string Street { get; set; }
        public decimal TurnoverAmount { get; set; }
        public decimal VatAmount { get; set; }
        public decimal VatAmountCur { get; set; }
        public string ZipCode { get; set; }
    }
}