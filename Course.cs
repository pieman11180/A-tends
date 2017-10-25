using System;
using System.Collections;
using System.Text;

namespace A__endance
{
    class Course
    {
        private int courseID;
        private int professorID;
        private String courseTitle;
        private DateTime startDate;
        private DateTime endDate;
        private ArrayList CDList;
        private ArrayList CSList;

        public Course(int cid, int pid, String title, DateTime sd, DateTime ed)
        {
            this.courseID = cid;
            this.professorID = pid;
            this.courseTitle = title;
            this.startDate = sd;
            this.endDate = ed;
        }

        public int getCourseID() { return courseID; }
        public int getProfessorID() { return professorID; }
        public String getCourseTitle() { return courseTitle; }
        public DateTime getStartDate() { return startDate; }
        public DateTime getEndDate() { return endDate; }
        public ArrayList getDateList() { return CDList; }
        public ArrayList getStudentList() { return CSList; }

        private void addCourseDate(CourseDate cd) {  CDList.Add(cd); }
        private void addCourseStudent(CourseStudent cs) {  CSList.Add(cs); }
    }
}
