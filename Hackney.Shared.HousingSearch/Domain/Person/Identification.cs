namespace Hackney.Shared.HousingSearch.Domain.Person
{
    public class Identification
    {
        public Identification() { }

        public static Identification Create(string identificationType, string value, bool isOriginalDocumentSeen,
            string linkToDocument)
        {
            return new Identification(identificationType, value, isOriginalDocumentSeen, linkToDocument);
        }

        private Identification(string identificationType, string value, bool isOriginalDocumentSeen, string linkToDocument)
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
