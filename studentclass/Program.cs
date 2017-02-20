using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentclass
{
    class Program
    {
        public int StdId { get; set; }/*Auto implementation*/
        public string StdName;
        public DateTime StuDob;    /*Defining variables with Datatypes*/
        public string StuClas;

        public int Calculateage(DateTime Dob,DateTime Now)  /* Method to calculate student age*/
        {
            int age = Now.Year - Dob.Year;
            if (Now.Month < Dob.Month || (Now.Month == Dob.Month && Now.Day < Dob.Day))
                age--;
            return age;
        }

        

        static void Main(string[] args)
        {
            Program stu = new Program();
            Console.WriteLine("Please enter student Id");
            stu.StdId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter student Name");
            stu.StdName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please enter student Date Of birth");
            stu.StuDob = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Please enter student Class");
            stu.StuClas = Convert.ToString(Console.ReadLine());
            int age = stu.Calculateage(stu.StuDob,Convert.ToDateTime("02 / 18 / 2017"));
            Console.WriteLine("Student Id :{0} \n Student Name :{1} \n Student Date Of Birth : {2} \n Student Class:{3} \n Student Age:{4}", stu.StdId,stu.StdName,stu.StuDob,stu.StuClas,age);
            Console.ReadLine();
        }
    }
}
