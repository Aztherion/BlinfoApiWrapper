using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class GetPayrollResponseItem
    {
        [JsonProperty(PropertyName = "accumulatedBenefit")]
        public decimal AccumulatedBenefit { get; set; }
        [JsonProperty(PropertyName = "accumulatedSalary")]
        public decimal AccumulatedSalary { get; set; }
        [JsonProperty(PropertyName = "accumulatedTax")]
        public decimal AccimulatedTax { get; set; }
        [JsonProperty(PropertyName = "accumulators")]
        public List<GetPayrollAccumulatorResponseItem> Accumulators { get; set; }
        [JsonProperty(PropertyName = "bankAccount")]
        public string BankAccount { get; set; }
        [JsonProperty(PropertyName = "benefits")]
        public decimal Benefits { get; set; }
        [JsonProperty(PropertyName = "box")]
        public string Box { get; set; }
        [JsonProperty(PropertyName = "calendar")]
        public string Calendar { get; set; }
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        [JsonProperty(PropertyName = "closed")]
        public bool Closed { get; set; }
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        [JsonProperty(PropertyName = "deduction")]
        public decimal Deduction { get; set; }
        [JsonProperty(PropertyName = "employee")]
        public GetPayrollEmployeeResponseItem PayrollEmployee { get; set; }
        [JsonProperty(PropertyName = "employerPayrollTax")]
        public decimal EmployerPayrollTax { get; set; }
        [JsonProperty(PropertyName = "employerPayrollTaxPercentage")]
        public decimal EmployerPayrollTaxPercentage { get; set; }
        [JsonProperty(PropertyName = "holidays")]
        public GetPayrollHolidayResponseItem HolidaysResponse { get; set; }
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "journalEntryDate")]
        public string JournalEntryDate { get; set; }
        [JsonProperty(PropertyName = "journalEntryId")]
        public decimal JournalEntryId { get; set; }
        [JsonProperty(PropertyName = "journalId")]
        public string JournalId { get; set; }
        [JsonProperty(PropertyName = "lastUpdate")]
        public string LastUpdate { get; set; }
        [JsonProperty(PropertyName = "lastUpdateBy")]
        public string LastUpdateBy { get; set; }
        [JsonProperty(PropertyName = "lines")]
        public List<GetPayrollTransactionRowResponseItem> Lines { get; set; }
        [JsonProperty(PropertyName = "paidAmount")]
        public decimal PaidAmount { get; set; }
        [JsonProperty(PropertyName = "paymentDate")]
        public string PaymentDate { get; set; }
        [JsonProperty(PropertyName = "preliminary")]
        public string Preliminary { get; set; }
        [JsonProperty(PropertyName = "preliminaryTax")]
        public decimal PreliminaryTax { get; set; }
        [JsonProperty(PropertyName = "printed")]
        public bool Printed { get; set; }
        [JsonProperty(PropertyName = "refersTo")]
        public string RefersTo { get; set; }
        [JsonProperty(PropertyName = "remuneration")]
        public decimal Remuneration { get; set; }
        [JsonProperty(PropertyName = "rounding")]
        public decimal Rounding { get; set; }
        [JsonProperty(PropertyName = "salaryGross")]
        public decimal SalaryGross { get; set; }
        [JsonProperty(PropertyName = "salaryPeriodId")]
        public decimal SalaryPeriodId { get; set; }
        [JsonProperty(PropertyName = "specialPayrollTax")]
        public decimal SpecialPayrollTax { get; set; }
        [JsonProperty(PropertyName = "specialPayrollTaxPercentage")]
        public decimal SpecialPayrollTaxPercentage { get; set; }
        [JsonProperty(PropertyName = "specificEmployerTaxDeduction")]
        public string SpecificEmployerTaxDeduction { get; set; }
        [JsonProperty(PropertyName = "street")]
        public string Street { get; set; }
        [JsonProperty(PropertyName = "taxableAmount")]
        public decimal TaxableAmount { get; set; }
        [JsonProperty(PropertyName = "taxScaleId")]
        public decimal TaxScaleId { get; set; }
        [JsonProperty(PropertyName = "unionFee")]
        public decimal UnionFee { get; set; }
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }
        [JsonProperty(PropertyName = "zipcode")]
        public string Zipcode { get; set; }

        public GetPayrollResponseItem()
        {
            BankAccount = string.Empty;
            Box = string.Empty;
            Calendar = string.Empty;
            City = string.Empty;
            Comment = string.Empty;
            JournalEntryDate = string.Empty;
            JournalId = string.Empty;
            LastUpdateBy = string.Empty;
            PaymentDate = string.Empty;
            RefersTo = string.Empty;
            Street = string.Empty;
            User = string.Empty;
            Zipcode = string.Empty;
            LastUpdate = string.Empty;
            Preliminary = string.Empty;
            SpecificEmployerTaxDeduction = string.Empty;
        }
    }

    public class GetPayrollAccumulatorResponseItem
    {
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }
        [JsonProperty(PropertyName = "amountTotal")]
        public decimal AmountTotal { get; set; }
        [JsonProperty(PropertyName = "common")]
        public string Common { get; set; }
        [JsonProperty(PropertyName = "quantity")]
        public decimal Quantity { get; set; }
        [JsonProperty(PropertyName = "quantityTotal")]
        public decimal QuantityTotal { get; set; }
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        public GetPayrollAccumulatorResponseItem()
        {
            Common = string.Empty;
            Text = string.Empty;
        }
    }

    public class GetPayrollEmployeeResponseItem
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        public GetPayrollEmployeeResponseItem()
        {
            Id = string.Empty;
            Name = string.Empty;
        }
    }

    public class GetPayrollHolidayResponseItem
    {
        [JsonProperty(PropertyName = "advance")]
        public decimal Advance { get; set; }
        [JsonProperty(PropertyName = "advanceTotal")]
        public decimal AdvanceTotal { get; set; }
        [JsonProperty(PropertyName = "paid")]
        public decimal Paid { get; set; }
        [JsonProperty(PropertyName = "paidTotal")]
        public decimal PaidTotal { get; set; }
        [JsonProperty(PropertyName = "saved")]
        public decimal Saved { get; set; }
        [JsonProperty(PropertyName = "savedTotal")]
        public decimal SavedTotal { get; set; }
        [JsonProperty(PropertyName = "unpaid")]
        public decimal Unpaid { get; set; }
        [JsonProperty(PropertyName = "unpaidTotal")]
        public decimal UnpaidTotal { get; set; }
        [JsonProperty(PropertyName = "utilized")]
        public decimal Utilized { get; set; }
    }

    public class GetPayrollTransactionRowResponseItem
    {
        [JsonProperty(PropertyName = "account")]
        public string Account { get; set; }
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        [JsonProperty(PropertyName = "costBearerId")]
        public string CostBearerId { get; set; }
        [JsonProperty(PropertyName = "costCenterId")]
        public string CostCenterId { get; set; }
        [JsonProperty(PropertyName = "fromDate")]
        public string FromDate { get; set; }
        [JsonProperty(PropertyName = "pricePerUnit")]
        public decimal PricePerUnit { get; set; }
        [JsonProperty(PropertyName = "projectId")]
        public string ProjectId { get; set; }
        [JsonProperty(PropertyName = "quantity")]
        public decimal Quantity { get; set; }
        [JsonProperty(PropertyName = "rowNumber")]
        public int RowNumber { get; set; }
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        [JsonProperty(PropertyName = "toDate")]
        public string ToDate { get; set; }
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        public GetPayrollTransactionRowResponseItem()
        {
            Account = string.Empty;
            Comment = string.Empty;
            CostBearerId = string.Empty;
            CostCenterId = string.Empty;
            ProjectId = string.Empty;
            Text = string.Empty;
            Unit = string.Empty;
            FromDate = string.Empty;
            ToDate = string.Empty;
        }
    }
}
