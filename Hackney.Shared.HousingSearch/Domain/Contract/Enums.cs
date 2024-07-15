using System;
using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Hackney.Shared.HousingSearch.Domain.Contract
{
    [Serializable]
    [StringEnum]
    public enum TargetType
    {
        [EnumMember(Value = "Asset")]
        Asset
    }
}
