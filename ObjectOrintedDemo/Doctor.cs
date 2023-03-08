using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectorintedDemo
{
    internal class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }    

        public int GrossIncome { get; set; }
        public int IncomeTax { get; set; }
        public int NetIncome { get; set; }
        

        // Non Value returing function
        public void Getdata()
        {
            Console.WriteLine("Please enter the value for Id");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the value for Name");
            Name = Console.ReadLine();

            Console.WriteLine("Please enter the value for GrossIncome");
            GrossIncome = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the value for IncomeTax");
            IncomeTax= Convert.ToInt32(Console.ReadLine());
        }

        // non value returing function .(without return type)
        public void putData()
        {
            Console.WriteLine("Id=" + Id);
            Console.WriteLine("Name ="+ Name);
            Console.WriteLine("GrossIncome ="+ GrossIncome);
            Console.WriteLine("IncomeTax ="+ IncomeTax);
            Console.WriteLine("NetIncome="+NetIncome);
        }




        #region Type casing demo
        // Type casting demo
        public string strId { get; set; }

        public char charId { get; set; }

        public static void TypeCastingDemo()
        {   

            Doctor doctor = new Doctor();
            
            doctor.strId = "10";
            doctor.Id = Convert.ToInt32(doctor.strId);

            doctor.charId = 'A';
            doctor.Id = doctor.charId;


        }
        #endregion



    }
}
