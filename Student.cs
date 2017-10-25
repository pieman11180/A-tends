using System;
using System.Collections;
using System.Text;

namespace A__endance
{
    class Student : User
    {
        private ArrayList CSList;

        public Student()
        {
            this.ID = 0;
            this.name = "";
        }

        public Student(Student st)
        {
            this.ID = st.getID();
            this.name = st.getName();
        }
        public void addCourseStudent(CourseStudent cs) { CSList.Add(cs); }
        public ArrayList getCourseDateStudents() { return CSList; }
    }
}
