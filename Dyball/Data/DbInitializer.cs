using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dyball.ViewModels;

namespace Dyball.Data
{
    public class DbInitializer
    {
        public static void Initialize(A2spaContext context)
        {
            context.Database.EnsureCreated();

            // Look for any test data.
            if (context.TestData.Any())
            {
                return;   // DB has been seeded
            }

            var testData = new TestData
            {
                Username = "JaneDoe",
                EmailAddress = "jane.doe@example.com",
                Password = "LetM@In!",
                Currency = 321.45M
            };

            context.TestData.Add(testData);
            context.SaveChanges();
        }
    }
}
