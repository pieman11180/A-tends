using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A__endance
{
    class Workflow
    {
        //Opening Screen
        String ID;
        String barcode;
        User user;
        String readBarCode() { return null; }
        String parseBarCode() { return null; }
        User searchDataBase() { return null; }
        void login() { }

        //Professor Screen
        Professor prof;
        ArrayList classList;
        void viewCourses() { }
        void startAttendance() { }

        //ClockIn Screen
        CourseDate CD; //today's coursedate
        ArrayList CDSList;//coursedatestudent list
        void clockIn(String barcode) { }
        void clockOut(String barcode) { }
        void save() { } //save cdslist results to database
        void exit() { } //will ask if save

        //ViewCourses Screen
        ArrayList CList;//courses
        Course selectCourse() { return null; }
        void back() { }

        //Course SCreen
        ArrayList CDList;//list of CourseDates
        ArrayList CSList;//list of CourseStudents
        void loadCDList() { }
        void loadCSList() { }
        void selectCourseDate() { }
        void selectCourseStudent() { }

        //CourseDateScreen
        ArrayList CDSList; //list of CourseDateStudents
        void loadCDSList() { }
        void editCDS() { }

        //CourseStudent Screen
        //list of CourseDateStudents matching this students
        ArrayList CDSList;
        void loadCDSList() { }
        void editCDS() { }



    }
}
