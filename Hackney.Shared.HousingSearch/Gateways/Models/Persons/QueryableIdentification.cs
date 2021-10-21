namespace Hackney.Shared.HousingSearch.Gateways.Models.Persons
{
    public class QueryableIdentification
    {
        public QueryableIdentification()
        {

        }

        public static QueryableIdentification Create(string identificationType, string value, bool isOriginalDocumentSeen,
            string linkToDocument)
        {
            return new QueryableIdentification(identificationType, value, isOriginalDocumentSeen, linkToDocument);
        }

        private QueryableIdentification(string identificationType, string value, bool isOriginalDocumentSeen, string linkToDocument)
        {
            IdentificationType = identificationType;
            Value = value;
            IsOriginalDocumentSeen = isOriginalDocumentSeen;
            LinkToDocument = linkToDocument;
        }

        public string IdentificationType { get; set; }

        public string Value { get; set; }

        public bool IsOriginalDocumentSeen { get; set; }

        public string LinkToDocument { get; set; }

    }
}
