using System;
using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Hackney.Shared.HousingSearch.Domain.Transactions
{
    [Serializable]
    [StringEnum]
    public enum TransactionType
    {
        [EnumMember(Value = "Rent")]
        Rent,
        [EnumMember(Value = "Charge")]
        Charge
    }

    [Serializable]
    [StringEnum]
    public enum TargetType
    {
        [EnumMember(Value = "Tenure")]
        Tenure
    }
}
