namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-10-hinert-dykstra1] - crated class, props, defined nullable Grade enum, and created Student class to deal with Student prop.
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public Grade? Grade { get; set; }
        public Student Student { get; set; }
    }
}