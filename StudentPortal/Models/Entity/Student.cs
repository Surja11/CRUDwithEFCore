using System.Diagnostics.Eventing.Reader;

namespace StudentPortal.Models.Entity
{
    public class Student
    {
        public Guid Id { get; set; }    
        
        public string Name { get; set; }
        
        public string Email { get; set; }

        public string Phone { get; set; }

        public bool Subscribed {  get; set; }   

    }
}
