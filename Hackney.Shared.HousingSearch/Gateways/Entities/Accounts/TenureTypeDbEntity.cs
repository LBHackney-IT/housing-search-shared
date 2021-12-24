using Hackney.Shared.HousingSearch.Domain.Accounts;

namespace Hackney.Shared.HousingSearch.Gateways.Entities.Accounts
{
    public class TenureTypeDbEntity
    {
        public TenureType ToTenureType()
        {
            return TenureType.Create(Code, Description);
        }
        /// <summary>
        ///     The code of the TenureType
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        ///     The description of the tenure
        /// </summary>
        public string Description { get; set; }
    }
}
