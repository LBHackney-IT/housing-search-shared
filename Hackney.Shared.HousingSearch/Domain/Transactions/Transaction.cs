﻿using System;

namespace Hackney.Shared.HousingSearch.Domain.Transactions
{
    public class Transaction
    {
        public Guid Id { get; set; }

        /// <summary>
        /// The guid of a tenancy/property
        /// </summary>
        public Guid TargetId { get; set; }

        /// <summary>
        ///     The target of provided id by target_id
        /// </summary>
        public TargetType TargetType { get; set; }

        /// <summary>
        /// Week number for Rent and Period number for LeaseHolders
        /// </summary>
        public short PeriodNo { get; set; }
        
        public short FinancialYear { get; set; }
        
        public short FinancialMonth { get; set; }
        
        public string TransactionSource { get; set; }
        
        public TransactionType TransactionType { get; set; }
        
        public DateTime TransactionDate { get; set; }
        
        public decimal TransactionAmount { get; set; }

        /// <summary>
        /// Same as Rent Account Number
        /// </summary>
        public string PaymentReference { get; set; }

        /// <summary>
        /// Partially filled bank account number
        /// </summary>
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Is this account need to be in suspense
        /// </summary>
        public bool IsSuspense { get; set; }

        /// <summary>
        /// Information after this record ceases to be suspense
        /// </summary>
        public SuspenseResolutionInfo SuspenseResolutionInfo { get; set; }
        
        public decimal PaidAmount { get; set; }
        
        public decimal ChargedAmount { get; set; }
        
        public decimal BalanceAmount { get; set; }

        /// <summary>
        /// Housing Benefit Contribution
        /// </summary>
        public decimal HousingBenefitAmount { get; set; }
        
        public string Address { get; set; }
        
        /// <summary>
        /// Person, who paid for the transaction
        /// </summary>
        public Person Person { get; set; }
        
        public string Fund { get; set; }
    }
}
