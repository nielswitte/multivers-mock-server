using Microsoft.AspNetCore.Mvc;
using Multivers.Api.Requests;
using Multivers.Api.Responses;
using Multivers.Api.Responses.ChildElements;
using Multivers.Api.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Multivers.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private short _nextJournalTransaction = 1;

        [HttpPost, Route("{database}/GetNextJournalTransactionCommand")]
        public ActionResult<NextJournalTransactionResponse> PostGetNextJournalTransactionResponse([FromQuery] NextJournalTransactionRequest request)
        {
            return Ok(new NextJournalTransactionResponse
            {
                Messages = new List<ResponseMessage>(),
                NextJournalTransaction = _nextJournalTransaction++
            });
        }


        [HttpPost, Route("{database}/CustomerInvoice")]
        public ActionResult<CustomerInvoiceResponse> PostCustomerInvoice(string database, [FromBody] CustomerInvoiceRequest request)
        {
            var totalAmountExVat = request.CustomerInvoiceLines.Sum(x => x.DebitAmountCur) -
                                   request.CustomerInvoiceLines.Sum(x => x.CreditAmountCur);
            var totalVatAmount = request.VatTransactionLines.Sum(x => x.VatAmountCur);


            return Ok(new CustomerInvoiceResponse
            {
                AccountManager = "Mocked Manager",
                AccountManagerId = request.AccountManagerId,
                AllBrokenRulesCollection = new List<BrokenRule>(),
                AmountCreditSqueeze = 0,
                AmountCreditSqueezeCur = 0,
                AmountRebate = 0,
                AmountRebateCur = 0,
                AmountTotal = totalAmountExVat + totalVatAmount,
                AmountTotalCur = totalAmountExVat + totalVatAmount,
                BordereauxNumber = null,
                BrokenRulesCollection = new List<BrokenRule>(),
                CanChange = false,
                CustomerInvoiceLines = request.CustomerInvoiceLines.Select(x => new CustomerInvoiceLine
                {
                    VatCodeId = x.VatCodeId,
                    VatType = x.VatType,
                    AccountId = x.AccountId,
                    CostCentreId = x.CostCentreId,                    
                    CreditAmountCur = x.CreditAmountCur,
                    DebitAmountCur = x.DebitAmountCur,
                    Description = x.Description,
                    TransactionDate = x.TransactionDate
                }),
                ContactPerson = request.ContactPerson,
                ContactPersonId = request.ContactPersonId,
                ContainsCustomProperties = false,
                Context = new AdministrationContext
                {
                    AdministrationId = database,
                    FiscalYear = request.FiscalYear
                },
                CurrencyId = request.CurrencyId,
                CustomerId = request.CustomerId,
                DocumentNumber = 0,
                DunForPayment = false,                
                ExchangeRate = 0,
                FiscalYear = request.FiscalYear,                
                InvoiceDate = request.InvoiceDate,
                InvoiceExpirationDate = request.InvoiceDate.AddDays(int.Parse(request.PaymentConditionId)),
                InvoiceId = request.InvoiceId,
                InvoiceType = request.InvoiceType,
                JournalId = request.JournalId,
                JournalTransaction = request.JournalTransaction,
                JournalSection = $"{request.FiscalYear}-{request.PeriodNumber}",
                KVCPaymentCondition = false,
                MandateId = null,
                Messages = new List<ResponseMessage>(),
                NumberOfReminders = 0,
                OpeningBalance = false,
                OrderId = null,                
                PaymentConditionId = request.PaymentConditionId,
                PeriodNumber = request.PeriodNumber,
                PaymentReference = request.PaymentReference,
                ProcessedBy = "Mocked API",
                ProcessedById = "-1",
                Reference = request.Reference,
                RebateExpirationDate = DateTime.Now,
                SystemInvoice = false,                
                TotalAmountVatExcl = totalAmountExVat,
                TotalAmountVatExclCur = totalAmountExVat,
                VatAdjusted = false,
                VatAmount = totalVatAmount,
                VatAmountCur = totalVatAmount,                
                VatOnInvoice = true,
                VatScenarioId = request.VatScenarioId,
                VatTransactionLines = request.VatTransactionLines.Select(x => new VatTransactionLine
                {
                    AmountNotDeductibleCur = x.AmountNotDeductibleCur,
                    AmountTurnoverCur = x.AmountTurnoverCur,                                       
                    CurrencyId = x.CurrencyId,
                    FiscalYear = x.FiscalYear,
                    VatAmountCur = x.VatAmountCur,
                    VatCodeId = x.VatCodeId,
                    VatType = x.VatType,
                    VatScenarioId = x.VatScenarioId
                })
            });
        }
    }
}
