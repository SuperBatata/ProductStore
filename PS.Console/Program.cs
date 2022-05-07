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



            Product produit1 = new Product()
            {
                ProductId = 1,
                Name = "Product 1",
                Description = "Product 1 description",
                Price = 100,
                
                
            };
            Product produit2 = new Product()
            {
                ProductId = 2,
                Name = "produit2",
                Description = "description2",
                Price = 2,
                Quantity = 2,
                DateProd = S.DateTime.Now,
                
            };
            
            S.Console.WriteLine("produit1 : " + produit1.Name);

            IList<Product> lproducts = new List<Product>();
            lproducts.Add(produit1);
            lproducts.Add(produit2);


            Provider p3 = new Provider()
            {
                Id = 1,
                Username = "monji",
                DateCreated = S.DateTime.Now,
                Password = "00002200",
                ConfirmPassword = "00002200",
                Products = lproducts
            };

            S.Console.WriteLine("produits p3 : " + lproducts[0].Name);


            p3.GetProducts("Name", "product2");


        }

            
    }
}