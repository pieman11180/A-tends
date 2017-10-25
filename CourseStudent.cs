using System;
using System.Collections;
using System.Text;


namespace A__endance
{
    class CourseStudent : Student
    {
        private int courseID;
        private int tardies;
        private int unexcusedAbsences;
        private ArrayList CDSList;

        public CourseStudent(Student ps, int cid)
        {
            this.ID = ps.getID();
            this.name = ps.getName();
            this.courseID = cid;
            this.tardies = 0;
            this.unexcusedAbsences = 0;
        }
        public int getTardies() { return tardies; }
        public int getUnexcusedAbsences() { return unexcusedAbsences; }
        public ArrayList getCDSList() { return CDSList; }

        public void addCourseDateStudent(CourseDateStudent cds) { CDSList.Add(cds); }
    }
}
