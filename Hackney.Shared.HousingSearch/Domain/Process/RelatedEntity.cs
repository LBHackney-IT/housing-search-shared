using System;
using System.Collections.Generic;
using System.Text;

namespace Hackney.Shared.HousingSearch.Domain.Process
{
    public class RelatedEntity
    {
        public string Id { get; set; }
        public string TargetType { get; set; }

        public string SubType { get; set; }
        public string Description { get; set; }

    }
}
