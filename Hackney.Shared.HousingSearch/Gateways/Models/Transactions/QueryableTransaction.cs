﻿using Hackney.Shared.HousingSearch.Domain.Transactions;
using Nest;
using System;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Transactions
{
    public class QueryableTransaction
    {
        public Transaction Create()
        {
            return new Transaction(Id, TargetId, TargetType, PeriodNo, FinancialYear, FinancialMonth,
                TransactionSource, TransactionType, TransactionDate, TransactionAmount, PaymentReference, 
                BankAccountNumber, IsSuspense, SuspenseResolutionInfo.Create(), PaidAmount, ChargedAmount, 
                BalanceAmount, HousingBenefitAmount, Address, Person.Create(), Fund);
        }

        [Text(Name = "id")]
        public Guid Id { get; set; }

        [Text(Name = "targetId")]
        public Guid TargetId { get; set; }

        [Text(Name = "targetType")]
        public TargetType TargetType { get; set; }

        [Number(Name = "periodNo")]
        public short PeriodNo { get; set; }

        [Number(Name = "financialYear")]
        private short FinancialYear { get; set; }

        [Number(Name = "financialMonth")]
        public short FinancialMonth { get; set; }

        [Text(Name = "transactionSource")]
        public string TransactionSource { get; set; }

        [Text(Name = "transactionType")]
        public TransactionType TransactionType { get; set; }

        [Date(Name = "transactionDate")]
        public DateTime TransactionDate { get; set; }

        [Number(Name = "transactionAmount")]
        public decimal TransactionAmount { get; set; }

        [Text(Name = "paymentReference")]
        public string PaymentReference { get; set; }

        [Text(Name = "bankAccountNumber")]
        public string BankAccountNumber { get; set; }

        [Boolean(Name = "isSuspense")]
        public bool IsSuspense { get; set; }

        [Text(Name = "suspenseResolutionInfo")]
        public QueryableSuspenseResolutionInfo SuspenseResolutionInfo { get; set; }

        [Number(Name = "paidAmount")]
        public decimal PaidAmount { get; set; }

        [Number(Name = "chargedAmount")]
        public decimal ChargedAmount { get; set; }

        [Number(Name = "balanceAmount")]
        public decimal BalanceAmount { get; set; }

        [Number(Name = "housingBenefitAmount")]
        public decimal HousingBenefitAmount { get; set; }

        [Text(Name = "address")]
        public string Address { get; set; }

        [Text(Name = "person")]
        public QueryablePerson Person { get; set; }

        [Text(Name = "fund")]
        public string Fund { get; set; }
    }
}
