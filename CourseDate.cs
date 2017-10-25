using System;
using System.Collections;
using System.Text;

namespace A__endance
{
    class CourseDate 
    {
        protected int courseID;
        protected DateTime startTime;
        protected DateTime endTime;
        protected ArrayList CDSList;

        public CourseDate()
        {
            this.courseID = 0;
            this.startTime = DateTime.Now;
            this.endTime = DateTime.Now;
        }

        public CourseDate(int cid, DateTime st, DateTime et)
        {
            this.courseID = cid;
            this.startTime = st;
            this.endTime = et;
        }
        public CourseDate(CourseDate cd){
          this.courseID = cd.getCourseID();
          this.startTime = cd.getStartTime();
          this.endTime = cd.getEndTime();
          this.CDSList = null;
        }

        public int getCourseID() { return courseID; }
        public DateTime getStartTime() { return startTime; }
        public DateTime getEndTime() { return endTime; }
        public ArrayList getCDSList() { return CDSList; }

        public void addCourseDateStudent(CourseDateStudent cds) { CDSList.Add(cds); }


    }

}
