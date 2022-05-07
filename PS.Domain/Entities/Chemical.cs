using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Domain.Entities
{
    public class Chemical : Product
    {
        public string City { get; set; }
        public string LabName { get; set; }
        public string StreetAddress { get; set; }


        public override string GetDetails()
        {

            return $"{Name} {City} {LabName} {StreetAddress}";

        }

        public override void GetMyType()
        {
            Console.WriteLine("i am a chemiical product");
        }
    }
}
