using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var departments = new Department[]
            {
                new Department{DepartmentID=1, DepartmentName="CSE",StudentID=1, SubjectID=1,TeacherID=1,SeasonID=1},
                new Department{DepartmentID=2, DepartmentName="Civil",StudentID=2, SubjectID=2,TeacherID=2,SeasonID=2},
                new Department{DepartmentID=3, DepartmentName="Textile",StudentID=3, SubjectID=3,TeacherID=3,SeasonID=3},
                new Department{DepartmentID=4, DepartmentName="Management",StudentID=4, SubjectID=4,TeacherID=1,SeasonID=2},
                new Department{DepartmentID=5, DepartmentName="Social-Science",StudentID=5, SubjectID=5,TeacherID=3,SeasonID=3},
                new Department{DepartmentID=6, DepartmentName="Chemestry",StudentID=6, SubjectID=6,TeacherID=3,SeasonID=1},
                new Department{DepartmentID=7, DepartmentName="Physics",StudentID=7, SubjectID=7,TeacherID=2,SeasonID=1},
                new Department{DepartmentID=8, DepartmentName="CSE",StudentID=1, SubjectID=1,TeacherID=1,SeasonID=2},
                new Department{DepartmentID=9, DepartmentName="CSE",StudentID=1, SubjectID=1,TeacherID=1,SeasonID=3},
                new Department{DepartmentID=10, DepartmentName="CSE",StudentID=1, SubjectID=1,TeacherID=1,SeasonID=3}
            };

            var students = new Student[]
            {
                new Student{StudentID=1, StudentName="Mamun"},
                new Student{StudentID=2, StudentName="Hridoy"},
                new Student{StudentID=3, StudentName="Tipu"},
                new Student{StudentID=4, StudentName="Sawon"},
                new Student{StudentID=5, StudentName="Rakib"},
                new Student{StudentID=6, StudentName="Sabbir"},
                new Student{StudentID=7, StudentName="Mahin"},
                new Student{StudentID=8, StudentName="Muhit"},
                new Student{StudentID=9, StudentName="Ramzan"},
                new Student{StudentID=10, StudentName="Sakib"}
            };

            var teachers = new Teacher[]
            {
                new Teacher{TeacherID=1,TeacherName="Aimun Nesa"},
                new Teacher{TeacherID=2,TeacherName="Zahidul"},
                new Teacher{TeacherID=3,TeacherName="Razib"},
            };

            var subjects = new Subject[]
            {
                new Subject{SubjectID=1,SubjectName="Bangla"},
                new Subject{SubjectID=2,SubjectName="English"},
                new Subject{SubjectID=3,SubjectName="C#"},
                new Subject{SubjectID=4,SubjectName="Math"},
                new Subject{SubjectID=5,SubjectName="PHP"},
                new Subject{SubjectID=6,SubjectName="Java"},
                new Subject{SubjectID=7,SubjectName="JavaScript"},
                new Subject{SubjectID=8,SubjectName="HTML"},
                new Subject{SubjectID=9,SubjectName="OPP"},
                new Subject{SubjectID=10,SubjectName="CSS"},
                new Subject{SubjectID=11,SubjectName="BootStarp"}
            };

            var seasons = new Season[]
            {
                new Season{SeasonID=1, SeasonName="Summer"},
                new Season{SeasonID=2, SeasonName="Winter"},
                new Season{SeasonID=3, SeasonName="Fall"}
            };

            var details = from d in departments
                          join st in students
                          on d.DepartmentID equals st.StudentID
                          join t in teachers
                          on d.DepartmentID equals t.TeacherID
                          join s in seasons
                          on st.StudentID equals s.SeasonID
                          join sb in subjects
                          on s.SeasonID equals sb.SubjectID
                          select new {Student=st.StudentID,st.StudentName, Department=d.DepartmentName, Subject=sb.SubjectName,Teacher=t.TeacherName,Season=s.SeasonName  };
            foreach (var detail in details)
            {
                Console.WriteLine("Student Name:\t"+ $"{detail.StudentName }");
                Console.WriteLine("Department Name:\t"+ $"{detail.Department }");
                Console.WriteLine("Teacher Name:\t"+ $"{detail.Teacher }");
                Console.WriteLine("Subject Name:\t"+ $"{detail.Subject }");
                Console.WriteLine("Season Name:\t"+ $"{detail.Season }");
                Console.WriteLine("======================================");
            }
            Console.ReadKey();
        }
    }
}
