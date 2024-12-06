using StudentProgress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentProgress.VM
{
    public class StudentVM
    {
      
            public Student student { get; set; }
            public int Total { get; set; }

            public string Result { get; set; }

            public string Grade { get; set; }

            public int Average { get; set; }

            public string ColorName { get; set; }

            public StudentVM(Student s)
            {
                student = s;
                Total = student.s1 + student.s2 + student.s3 + student.s4 + student.s5 + student.s6;
                Result = "Fail";
                if (student.s1 >= 35 && student.s2 >= 35 && student.s3 >= 35 && student.s4 >= 35 && student.s5 >= 35 && student.s6 >= 35)
                {
                    Result = "Pass";
                }
                Grade = "F";
                if (Result == "Pass")
                {
                    int p = Total / 6;
                    if (p >= 90)
                    {
                        Grade = "A+";
                    }
                    else if (p >= 80)
                    {
                        Grade = "A";
                    }
                    else if (p >= 70)
                    {
                        Grade = "B";
                    }
                    else if (p >= 60)
                    {
                        Grade = "C";
                    }
                    else if (p >= 50)
                    {
                        Grade = "D";
                    }
                    else if (p >= 35)
                    {
                        Grade = "E";
                    }

                }
                int Average = Total / 6;
                ColorName = Result == "Pass" ? "green" : "red";
            }
        }
}