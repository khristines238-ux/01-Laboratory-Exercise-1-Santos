using System;

namespace _01_Laboratory_Exercise_1_Santos
{
    public class StudentInfoClass
    {
        
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);

        
        public static string FirstName = " ";
        public static string LastName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";
        public static string Program = " ";

        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

      
        public static string GetFirstName(string firstName) => firstName;
        public static string GetLastName(string lastName) => lastName;
        public static string GetMiddleName(string middleName) => middleName;
        public static string GetAddress(string address) => address;
        public static string GetProgram(string program) => program;

        public static long GetAge(long age) => age;
        public static long GetContactNo(long contactNo) => contactNo;
        public static long GetStudentNo(long studentNo) => studentNo;
    }
}
