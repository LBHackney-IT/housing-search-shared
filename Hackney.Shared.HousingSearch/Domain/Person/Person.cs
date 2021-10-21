using System.Collections.Generic;

namespace Hackney.Shared.HousingSearch.Domain.Person
{
    public class Person
    {
        public Person() { }

        public static Person Create(string id, string title, string firstname, string middleName, string surname,
            string preferredFirstname, string preferredSurname, decimal totalBalance, string dateOfBirth,
            List<string> personTypes, bool isPersonCautionaryAlert, bool isTenureCautionaryAlert,
            List<PersonTenure> tenures)
        {
            return new Person(id, title, firstname, middleName, surname,
                preferredFirstname, preferredSurname, totalBalance, dateOfBirth,
                personTypes, isPersonCautionaryAlert, isTenureCautionaryAlert,
                tenures);
        }

        private Person(string id, string title, string firstname, string middleName, string surname,
            string preferredFirstname, string preferredSurname, decimal totalBalance, string dateOfBirth,
            List<string> personTypes, bool isPersonCautionaryAlert, bool isTenureCautionaryAlert,
            List<PersonTenure> tenures)
        {
            Id = id;
            Title = title;
            Firstname = firstname;
            MiddleName = middleName;
            Surname = surname;
            PreferredFirstname = preferredFirstname;
            PreferredSurname = preferredSurname;
            TotalBalance = totalBalance;
            DateOfBirth = dateOfBirth;
            PersonTypes = personTypes;
            IsPersonCautionaryAlert = isPersonCautionaryAlert;
            IsTenureCautionaryAlert = isTenureCautionaryAlert;
            Tenures = tenures;
        }

        public string Id { get; set; }

        public string Title { get; set; }

        public string Firstname { get; set; }

        public string MiddleName { get; set; }

        public string Surname { get; set; }

        public string PreferredFirstname { get; set; }

        public string PreferredSurname { get; set; }

        public decimal TotalBalance { get; set; }

        public string DateOfBirth { get; set; }

        public List<string> PersonTypes { get; set; }

        public bool IsPersonCautionaryAlert { get; set; }

        public bool IsTenureCautionaryAlert { get; set; }

        public List<PersonTenure> Tenures { get; set; }
    }
}