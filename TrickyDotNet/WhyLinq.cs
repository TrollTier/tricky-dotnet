using Models;
using System.Linq;
using Xunit;

namespace TrickyDotNet
{
    public class WhyLinq
    {
        // If you don't know the answer, try searching for "deferred execution" and/or "lazy evaluation"
        // and you should be able to find a solution.
        [Fact]
        public void Why_Is_Value_Not_Set()
        {
            var baseEmployees = new Employee[]
            {
                new Employee("Max", "Mustermann", 2039),
                new Employee("Susi", "Siegberg", 28392)
            };

            var persons = baseEmployees
                .Select(employee => new Person(employee.FirstName, employee.LastName));

            foreach (var employee in persons)
            {
                employee.FirstName = employee.FirstName.ToUpper();
                employee.LastName = employee.LastName.ToUpper();
            }

            Assert.Equal("MAX", persons.First().FirstName); // Why not MAX?
        }
    }
}
