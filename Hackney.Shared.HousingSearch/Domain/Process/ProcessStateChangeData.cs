using System.Collections.Generic;

namespace Hackney.Shared.HousingSearch.Domain.Process
{
    public class ProcessStateChangeData
    {
        public string State { get; set; }
        public Dictionary<string, object> StateData { get; set; }
    }
}