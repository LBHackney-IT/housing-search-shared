using System;
using System.Collections.Generic;
using Hackney.Shared.HousingSearch.Domain.Accounts.Enum;

namespace Hackney.Shared.HousingSearch.Domain.Accounts
{
    public class Account
    {
        public static Account Create(Guid id
            , Guid parentAccountId
            , string paymentReference
            , TargetType targetType
            , Guid targetId
            , AccountType accountType
            , RentGroupType rentGroupType
            , string agreementType
            , decimal accountBalance
            , decimal consolidatedBalance
            , string createdBy
            , string lastUpdatedBy
            , DateTime createdAt
            , DateTime lastUpdatedAt
            , DateTime startDate
            , DateTime? endDate
            , AccountStatus accountStatus
            , IEnumerable<ConsolidatedCharge> consolidatedCharges
            , Tenure tenure)
        {
            return new Account(id,
                parentAccountId,
                paymentReference,
                targetType,
                targetId,
                accountType,
                rentGroupType,
                agreementType,
                accountBalance,
                consolidatedBalance,
                createdBy,
                lastUpdatedBy,
                createdAt,
                lastUpdatedAt,
                startDate,
                endDate,
                accountStatus,
                consolidatedCharges,
                tenure);
        }

        private Account(Guid id
            , Guid parentAccountId
            , string paymentReference
            , TargetType targetType
            , Guid targetId
            , AccountType accountType
            , RentGroupType rentGroupType
            , string agreementType
            , decimal accountBalance
            , decimal consolidatedBalance
            , string createdBy
            , string lastUpdatedBy
            , DateTime createdAt
            , DateTime lastUpdatedAt
            , DateTime startDate
            , DateTime? endDate
            , AccountStatus accountStatus
            , IEnumerable<ConsolidatedCharge> consolidatedCharges
            , Tenure tenure)
        {
            Id = id;
            ParentAccountId = parentAccountId;
            PaymentReference = paymentReference;
            TargetType = targetType;
            TargetId = targetId;
            AccountType = accountType;
            RentGroupType = rentGroupType;
            AgreementType = agreementType;
            AccountBalance = accountBalance;
            ConsolidatedBalance = consolidatedBalance;
            CreatedBy = createdBy;
            LastUpdatedBy = lastUpdatedBy;
            CreatedAt = createdAt;
            LastUpdatedAt = lastUpdatedAt;
            StartDate = startDate;
            EndDate = endDate;
            AccountStatus = accountStatus;
            ConsolidatedCharges = consolidatedCharges;
            Tenure = tenure;
        }

        public Guid Id { get; }

        public Guid ParentAccountId { get; }

        public string PaymentReference { get; }

        public TargetType TargetType { get; }

        public Guid TargetId { get; }

        public AccountType AccountType { get; }

        public RentGroupType RentGroupType { get; }

        public string AgreementType { get; }

        public decimal AccountBalance { get; } = 0;

        public decimal ConsolidatedBalance { get; } = 0;

        public string CreatedBy { get; }

        public string LastUpdatedBy { get; }

        public DateTime CreatedAt { get; }

        public DateTime LastUpdatedAt { get; }

        public DateTime StartDate { get; }

        public DateTime? EndDate { get; }

        public AccountStatus AccountStatus { get; }

        public IEnumerable<ConsolidatedCharge> ConsolidatedCharges { get; }

        public Tenure Tenure { get; }
    }
}
