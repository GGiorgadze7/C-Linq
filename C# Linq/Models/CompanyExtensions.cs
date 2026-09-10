using System;
using System.Collections.Generic;
using System.Text;

namespace C__Linq.Models
{
    public static class CompanyExtensions
    {
        public static IEnumerable<Company> GetFoodCompanies (this IEnumerable<Company> companies)
        {
            return companies.Where(c => c.Profile == BusinessProfile.Food);
        }

        public static IEnumerable<Company> GetMarketingOrIT(
        this IEnumerable<Company> companies)
        {
            return companies.Where(c => c.Profile == BusinessProfile.Marketing ||
                                        c.Profile == BusinessProfile.IT);
        }

        public static IEnumerable<Company> GetMidSizeCompanies(
       this IEnumerable<Company> companies)
        {
            return companies.Where(c => c.EmployeeCount >= 100 &&
                                        c.EmployeeCount <= 300);
        }

        public static IEnumerable<Company> GetWhiteDirector(
        this IEnumerable<Company> companies)
        {
            return companies.Where(c => c.DirectorName.EndsWith ("White"));
        }

        public static IEnumerable<Company> GetAfter123Days(
        this IEnumerable<Company> companies)
        {
            return companies.Where(c =>
                (DateTime.Now - c.FoundedDate).Days >= 123);
        }


    }
}
