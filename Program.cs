using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppkeyga11
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
#pragma warning disable CS0661 // Type defines operator == or operator != but does not override Object.GetHashCode()
public class Employee
#pragma warning restore CS0661 // Type defines operator == or operator != but does not override Object.GetHashCode()
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overloading the "==" operator to compare Employee objects based on their Id property
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        // Check if both objects are null or if their Id properties are equal
        return ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null) ||
               !ReferenceEquals(employee1, null) && !ReferenceEquals(employee2, null) &&
               employee1.Id == employee2.Id;
    }

    // Overloading the "!=" operator as well, as it is required when overloading "=="
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return !(employee1 == employee2);
    }

    // Override the Equals method to maintain consistency with object equality
    public override bool Equals(object obj)
    {
        if (obj is Employee otherEmployee)
        {
            // Check if the Id properties are equal
            return this.Id == otherEmployee.Id;
        }
        return false;
    }
}


