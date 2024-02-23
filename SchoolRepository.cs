using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataLibrary
{
    public class SchoolRepository
    {
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();
        private List<Subject> subjects = new List<Subject>();

        // Methods for managing teachers
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public Teacher GetTeacherById(int id)
        {
            return teachers.Find(t => t.Id == id);
        }

        public object GetTeachers()
        {
            throw new NotImplementedException();
        }
    }
}
