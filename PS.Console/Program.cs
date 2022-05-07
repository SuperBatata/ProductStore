using S = System; //~ import System; 
using PS.Domain;
using PS.Domain.Entities;

namespace PS.Console
{

    public class Program
    {

        public static void Main(string[] args)
        {
            System.Console.WriteLine("Hello Potato!");



            Provider p = new Provider();


            S.Console.WriteLine("Resultat p1");


            p.Id = 10;
            p.Username = "khaledbattiche";
            p.Email = "khaledbattiche@esprit.tn";
            p.Password = "0000";
            p.ConfirmPassword = "0000";

            S.Console.WriteLine("Resultat P2: ");

            Provider p2 = new Provider()
            {
                Id = 1,
                Username = "monji",
                DateCreated = S.DateTime.Now,
                Password = "00002200",
                ConfirmPassword = "00002200"
            };

            //Provider p3 = new Provider(12, "khaled", "00000", "00000", "khaledbattiche@esprit.tn", S.DateTime.Now);

            bool notApproved = false;
            Provider.SetIsApproved(p2.Password, p2.ConfirmPassword, ref notApproved);
            p2.isApproved = notApproved;
            S.Console.WriteLine("value approved :" + p2.isApproved);

            p2.Login("username", "password" ,"email");

            Product pr = new Product();
            Product bl = new Biological();
            Product ch = new Chemical();
            pr.GetMyType(); bl.GetMyType(); ch.GetMyType();

            

            ;

        }


    }
}