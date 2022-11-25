using Task2.Exceptions;
using Task2.Services;

namespace Task2
{
    public class Student
    {
        private static int id=0;
        private string groupName;
        public Student(string name, string surname, string groupNo)
        {
            Name = name;
            Surname = surname;
            GroupNo = groupNo;
            id++;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public String GroupNo
        {
            get
            {
                return groupName;
            }
            set
            {
                if (new StudentGroupCheckService().CheckGroupNo(value))
                {
                groupName = value;
                }
                else
                {
                    try
                    {
                        throw new IncorrectGroupnameException("Wrong group name");
                    }
                    catch (IncorrectGroupnameException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

            }
        }
    

        public string StudentInfo()
        {
            return $"Name:{Name} Surname:{Surname} GroupNO:{groupName} Student Id{id}";
        }
    }
}
