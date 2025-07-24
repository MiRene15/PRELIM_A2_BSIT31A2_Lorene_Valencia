namespace PRELIM_A2_BSIT31A2_Lorene_Valencia.Models
{
    public enum Gender { Unknown, Male, Female}
    public class Student
    {
        public string firstName;
        public string lastName;

        public string Title { get; set; }
        public string Course { get; set; }
        public string Section { get; set;}
        public DateTime Birthday { get; set; }

        public Gender Gender { get; set; } = Gender.Unknown;  
        

        public Student()
        {
            Title = "";
            firstName = "";
            lastName = "";
            Course = "";
            Section = "";
            Birthday = DateTime.Today;
            Gender = Gender.Unknown;
        }

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
           
        }

        //Methods
        public void SetFirstName(string fname) => firstName = fname;
        public void SetLastName(string lname) => lastName = lname;
        public void SetGender(Gender gender) => Gender = gender;

        public string FullName => $"{Title}{firstName} {lastName}";

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                int age = today.Year - Birthday.Year;
                if (Birthday > today.AddYears(-age)) age--;
                return age;
            }
        }

    }

}
