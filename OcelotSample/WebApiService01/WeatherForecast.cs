using System;

namespace WebApiService01
{
    public class PersonData
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RequestDateTime { get; set; }
    }
    public class SalaryData
    {
        public string PersonId { get; set; }
        public int Month { get; set; }
        public int Salaty { get; set; }
        public DateTime RequestDateTime { get; set; }
    }
}
