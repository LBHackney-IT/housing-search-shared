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

        public Account()
        {

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

        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid ParentAccountId { get; set; }

        public string PaymentReference { get; set; }

        public TargetType TargetType { get; set; }

        public Guid TargetId { get; set; }

        public AccountType AccountType { get; set; }

        public RentGroupType RentGroupType { get; set; }

        public string AgreementType { get; set; }

        public decimal AccountBalance { get; set; } = 0;

        public decimal ConsolidatedBalance { get; set; } = 0;

        public string CreatedBy { get; set; }

        public string LastUpdatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastUpdatedAt { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public AccountStatus AccountStatus { get; set; }

        public IEnumerable<ConsolidatedCharge> ConsolidatedCharges { get; set; }

        public Tenure Tenure { get; set; }
    }
}
