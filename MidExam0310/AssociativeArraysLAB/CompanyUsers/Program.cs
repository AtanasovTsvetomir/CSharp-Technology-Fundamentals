using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyAndUsers = new Dictionary<string, List<string>>();
            var command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                var companyAndId = command.Split(" -> ");
                var company = companyAndId[0];
                var id = companyAndId[1];

                if (!companyAndUsers.ContainsKey(company))
                {
                    companyAndUsers.Add(company, new List<string>());
                    companyAndUsers[company].Add(id);
                }
                else if (companyAndUsers.ContainsKey(company))
                {
                    if (!companyAndUsers[company].Contains(id))
                    {
                        companyAndUsers[company].Add(id);
                    }
                }
            }

            foreach (var company in companyAndUsers.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{company.Key}");

                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
