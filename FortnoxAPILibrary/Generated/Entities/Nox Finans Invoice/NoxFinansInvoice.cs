using FortnoxAPILibrary.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FortnoxAPILibrary.Entities
{
    [Entity(SingularName = "NoxFinansInvoice", PluralName = "NoxFinansInvoices")]
    public class NoxFinansInvoice
    {

        ///<summary> Balance fees in currency in SEK </summary>
        [ReadOnly]
        [JsonProperty]
        public decimal? BalanceIncludeFees { get; private set; }

        ///<summary> Balance fees in currency (today is only SEK available) </summary>
        [ReadOnly]
        [JsonProperty]
        public decimal? BalanceIncludeFeesCurrency { get; private set; }

        ///<summary> Capital amount balance in SEK </summary>
        [ReadOnly]
        [JsonProperty]
        public decimal? CurrentCapitalBalance { get; private set; }

        ///<summary> Capital amount balance in currency (today is only SEK available) </summary>
        [ReadOnly]
        [JsonProperty]
        public decimal? CurrentCapitalBalanceCurrency { get; private set; }

        ///<summary> URL to PDF document for invoice </summary>
        [ReadOnly]
        [JsonProperty]
        public string InvoiceDocumentURL { get; private set; }

        ///<summary> Invoice number in Fortnox </summary>
        [ReadOnly]
        [JsonProperty]
        public int? InvoiceNumber { get; private set; }

        ///<summary> INVOICEREMINDER  REMINDER  COLLECTION  EXECUTIONCONTROLL  MONITORING </summary>
        [ReadOnly]
        [JsonProperty]
        public decimal? NextEvent { get; private set; }

        ///<summary>  </summary>
        [ReadOnly]
        [JsonProperty]
        public DateTime? NextEventDate { get; private set; }

        ///<summary> OCR number generated by Nox Finans. </summary>
        [ReadOnly]
        [JsonProperty]
        public string OCRNumber { get; private set; }

        ///<summary> LEDGERBASE  REIMDER  FACTORING_LOAN  FACTORING_SELL </summary>
        [JsonProperty]
        public string Service { get; set; }

        ///<summary> EMAIL = EmailNONE = Nox Finans do not distribute invoice (can not be selected on Reminder service)  LETTER = Send by letter </summary>
        [JsonProperty]
        public string SendMethod { get; set; }

        ///<summary> UNKOWN = Not yet confirmed by Nox Finans  NOT_AUTHORIZED = Factoring invoice waiting approval  OPEN = Open  PAUSED = Invoice pause  CLOSED = Invoice is closed </summary>
        [ReadOnly]
        [JsonProperty]
        public string Status { get; private set; }
    }
}