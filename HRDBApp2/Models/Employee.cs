using System.ComponentModel.DataAnnotations;

namespace HRDBApp2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public int PositionId { get; set; }
        public Position? Position { get; set; }

    }
}