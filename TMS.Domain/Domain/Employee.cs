namespace TMS.Domain.Domain
{
    public class Employee
    {
        public string EmployeeCode { get; set; }
        public string Name { get; set; }
        public string Emailid { get; set; }
        public string WorkGroup { get; set; }
        public string Band { get; set; }
        public string SubBand { get; set; }
        public string Designation { get; set; }
        public string Entity { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Nationality { get; set; }
        public string L4Code { get; set; }
        public string JobCode { get; set; }
        public string CompanyCode { get; set; }
        public string PersonalAreaCode { get; set; }
        public string PersonalSubAreaCode { get; set; }
        public string WorkLocationCode { get; set; }
        public string HireCountryCode { get; set; }
        public string RMCode { get; set; }
        public System.DateTime DOB { get; set; }
        public System.DateTime JoningDate { get; set; }
        public bool IsGeoHire { get; set; }
        public bool IsSTL { get; set; }
        public bool IsThirdParty { get; set; }
        public bool IsTSS { get; set; }
        public bool IsTotalization { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
    }
}
