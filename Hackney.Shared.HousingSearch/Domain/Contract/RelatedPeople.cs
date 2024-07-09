namespace Hackney.Shared.HousingSearch.Domain.Contract
{
    public class RelatedPeople
    {
        public RelatedPeople() { }

        public static RelatedPeople Create(string id, string type, string subType, string name)
        {
            return new RelatedPeople(id, type, subType, name);
        }

        private RelatedPeople(string id, string type, string subType, string name)
        {
            Id = id;
            Type = type;
            SubType = subType;
            Name = name;
        }

        public string Id { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Name { get; set; }
    }
}