using System;
using System.Collections;
using System.Text;

namespace A__endance
{
    class Professor : User
    {
        private ArrayList courses;

        public Professor(Professor p)
        {
            this.ID = p.getID();
            this.name = p.getName();
        }
        public void addCourse(Course c) { courses.Add(c); }
        public ArrayList getCourses() { return courses; }

    }
}
