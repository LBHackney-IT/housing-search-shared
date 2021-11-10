namespace Hackney.Shared.HousingSearch.Domain.Accounts
{
    public class TenureType
    {
        private TenureType(string code, string description)
        {
            Code = code;
            Description = description;
        }

        public static TenureType Create(string code, string description)
        {
            return new TenureType(code, description);
        }

        /// <summary>
        ///     The code of the TenureType
        /// </summary>
        /// <example>
        ///     PVG
        /// </example>
        public string Code { get; }
        /// <summary>
        ///     The description of the tenure
        /// </summary>
        /// <example>
        ///     Private garage
        /// </example>
        public string Description { get; }
    }
}
