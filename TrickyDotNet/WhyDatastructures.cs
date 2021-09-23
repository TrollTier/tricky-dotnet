using Models;
using System;
using Xunit;

namespace TrickyDotNet
{
    // Read these and you should be able to answer your coworkers questions
    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types
    public class WhyDatastructures
    {
        [Fact]
        public void Why_Is_Value_Not_Set()
        {
            var vectors = new Vector[]
            {
                new Vector(1, 1, 1),
                new Vector(1, 2, 3)
            };

            var vector = vectors[0];

            vector.X = 3;

            Assert.Equal(3, vectors[0].X); // This one does not get set :( Why?
        }

        [Fact]
        public void Why_Is_Value_Set()
        {
            // So if vectors behave like that, surely this also applies to employees right?

            var employees = new Person[]
            {
                new Person("Max", "Mustermann"),
                new Person("Susi", "Siegberg")
            };

            var employee = employees[0];

            employee.FirstName = "Überschrieben";

            Assert.Equal("Max", employees[0].FirstName); // Nope :/ Why? :'(
        }

        [Fact]
        public void Why_Is_Value_Changed()
        {
            var vector = new Vector(1, 1, 1);
            PrintVector(vector); // This one does not mess up my vector :)
            Assert.Equal(1, vector.X);

            var employee = new Person("Max", "Mustermann");
            PrintEmployee(employee); // This one does mess up my employee :/ Why?
            Assert.Equal("Max", employee.FirstName);
        }

        private void PrintVector(Vector vector)
        {
            vector.X = 4;

            Console.WriteLine($"x: {vector.X}, y: {vector.Y}, z: {vector.Z}");
        }

        private void PrintEmployee(Person employee)
        {
            employee.FirstName = "Überschrieben";

            Console.WriteLine($"Mitarbeiter: {employee.FirstName} {employee.LastName}");
        }
    }
}
