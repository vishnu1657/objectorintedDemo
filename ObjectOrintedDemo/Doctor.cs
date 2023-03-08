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
        public string strId { get; set; }

        public char charId { get; set; }
        public string Name { get; set; }    

        public int GrossIncome { get; set; }
        public int IncomeTax { get; set; }
        public int NetIncome { get; set; }
        public int netIncome;


        public static int xyz { get; set; } 

        public static void CalculateNetIncome1()
        {   

            Doctor doctor = new Doctor();
            
            doctor.strId = "10";
            doctor.Id = Convert.ToInt32(doctor.strId);

            doctor.charId = 'A';
            doctor.Id = doctor.charId;


        }

        public static void CalculateNetIncome2()
        {

        }

        public void NonStaticFunction()
        {
            xyz = 0;
            NetIncome = 4;
        }


    }
}
