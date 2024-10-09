using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNamespace
{
    public class StudentInfo
    {
        public float student_ID;
        public string last_name;
        public string first_name;
        public StudentInfo(float studentID) 
        {
            this.student_ID = studentID;
        }
        public StudentInfo(string lastName, string firstName)
        {
            this.last_name = lastName;
            this.first_name = firstName;
        }
        public float getStudentID
        {
            get {
                return this.student_ID;
            }
            set {
                this.student_ID = value;
            }
        }
        public string getLastName
        {
            get
            {
                return this.last_name;
            }
            set
            {
                this.last_name = value;
            }
        }
        public string getFirstName
        {
            get
            {
                return this.first_name;
            }
            set
            {
                this.first_name = value;
            }
        }

    }
}
