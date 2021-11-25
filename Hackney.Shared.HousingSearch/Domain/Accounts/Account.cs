using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Hackney.Shared.HousingSearch.Domain.Accounts.Enum;
using Hackney.Shared.HousingSearch.Validations;

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
            , List<ConsolidatedCharge> consolidatedCharges
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
            , List<ConsolidatedCharge> consolidatedCharges
            , Tenure tenure)
        {
            Id = id;
            ParentAccountId = parentAccountId;
            PaymentReference = paymentReference ?? throw new ArgumentNullException(nameof(paymentReference));
            TargetType = targetType;
            TargetId = targetId;
            AccountType = accountType;
            RentGroupType = rentGroupType;
            AgreementType = agreementType ?? throw new ArgumentNullException(nameof(agreementType));
            AccountBalance = accountBalance;
            ConsolidatedBalance = consolidatedBalance;
            CreatedBy = createdBy ?? throw new ArgumentNullException(nameof(createdBy));
            LastUpdatedBy = lastUpdatedBy ?? throw new ArgumentNullException(nameof(lastUpdatedBy));
            CreatedAt = createdAt;
            LastUpdatedAt = lastUpdatedAt;
            StartDate = startDate;
            EndDate = endDate;
            AccountStatus = accountStatus;
            ConsolidatedCharges = consolidatedCharges;
            Tenure = tenure ?? throw new ArgumentNullException(nameof(tenure));
        }
        [NonEmptyGuid]
        public Guid Id { get; }
        [NonEmptyGuid]
        public Guid ParentAccountId { get; }

        [NotNull]
        [Required]
        public string PaymentReference { get; }

        public TargetType TargetType { get; }

        [NonEmptyGuid]
        public Guid TargetId { get; }

        public AccountType AccountType { get; }

        public RentGroupType RentGroupType { get; }

        [NotNull]
        [Required]
        public string AgreementType { get; }

        [NotNull]
        public decimal AccountBalance { get; } = 0;

        [NotNull]
        public decimal ConsolidatedBalance { get; } = 0;

        [NotNull]
        [Required]
        public string CreatedBy { get; }

        [NotNull]
        [Required]
        public string LastUpdatedBy { get; }

        [NotNull]
        [Required]
        public DateTime CreatedAt { get; }

        [NotNull]
        [Required]
        public DateTime LastUpdatedAt { get; }

        [NotNull]
        [Required]
        public DateTime StartDate { get; }

        public DateTime? EndDate { get; }

        public AccountStatus AccountStatus { get; }

        public List<ConsolidatedCharge> ConsolidatedCharges { get; }

        [NotNull]
        [Required]
        public Tenure Tenure { get; }
    }
}
