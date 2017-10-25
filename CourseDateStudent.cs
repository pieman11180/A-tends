using System;
using System.Collections.Generic;
using System.Text;

namespace A__endance
{
    class CourseDateStudent : CourseDate
    {
        private int studentID;
        private DateTime clockInTime;
        private DateTime clockOutTime;
        private Boolean present;
        private Boolean tardy;
        private Boolean unexcusedAbsence;

        public CourseDateStudent(CourseDate cd, int sid)
        {
            this.courseID = cd.getCourseID();
            this.startTime = cd.getStartTime();
            this.endTime = cd.getEndTime();
            this.studentID = sid;
            this.present = false;
            this.tardy = false;
            this.unexcusedAbsence = false;
        }
        public void clockIn(DateTime time) { this.clockInTime = time; }
        public void clockOut(DateTime time) { this.clockOutTime = time; }

        public int getStudentID() { return studentID; }
        public DateTime getClockInTime() { return clockInTime; }
        public DateTime getClockOutTime() { return clockOutTime; }
        public Boolean getPresent() { return present; }
        public Boolean getTardy() { return tardy; }
        public Boolean getUnexcusedAbsence() { return unexcusedAbsence; }
    }
}
