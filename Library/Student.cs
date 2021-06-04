using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Student
    {
        private string name;
        private string image;
        private int enrolment_number;
        // add enum for student department
        private string department;
        // add enum for student semester
        private string semester;
        private string contact;
        private string email;

        public string Name
        {
            get { return name; }
            set {; }
        }

        public string Image
        {
            get { return image; }
            set {; }
        }

        public int Enrolment_Number
        {
            get { return enrolment_number; }
            set {; }
        }
        public string Department
        {
            get { return department; }
            set {; }
        }
        public string Semester
        {
            get { return semester; }
            set {; }
        }

        public string Contact
        {
            get { return contact; }
            set {; }
        }
        public string Email
        {
            get { return email; }
            set {; }
        }

        // Implicit constructor
        public Student()
        {
            //shoudln't use book, make a generic class with enums and const
            name = Book.UNKNOWN;
            image = Book.UNKNOWN;
            enrolment_number = 0;
            department = Book.UNKNOWN;
            semester = Book.UNKNOWN;
            contact = Book.UNKNOWN;
            email = Book.UNKNOWN;
        }

        // Constructor

        public Student(string _name, 
            string _image,
            int _enrolment_number,
            string _department,
            string _semester,
            string _contact,
            string _email)
        {
            name = _name;
            image = _image;
            enrolment_number = _enrolment_number;
            department = _department;
            semester = _semester;
            contact = _contact;
            email = _email;
        }

        public string Convert_to_string()
        {
            return $"\nStudent name: {Name},\nStudent photo: {Image},\nEnrolment number: {Enrolment_Number}," +
                $"\nDepartment: {Department},\nSemester: {Semester},\nContact: {Contact},\nEmail: {Email}";
        }

    }
}
