using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Domain.Entities
{
    public class Provider : Concept
    {
        public Provider()
        {
        }

        //public string ConfirmPassword { get; set; }

        string confirmPassword;
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                if (value == password)
                {
                    confirmPassword = value;
                    Console.WriteLine("password matching");
                }
                else
                {
                    Console.WriteLine("passwords do not match");
                }
            }
        }

        string password;
        public string Password {
                
            get
            {
                return password;
            }
            set
            {
                if (value.Length >= 5 && value.Length <= 20)
                { password = value; }
                else { Console.WriteLine("Erreur, password invalide!"); }
            }

                }

        public string Email { get; set; }

        public DateTime DateCreated { get; set; }

        public string Username { get; set; }

        //public string Password { get; set; }
        
        public int Id { get; set; }

        public bool isApproved { get; set; }
            

        public virtual IList<Product> Products { get; set; }


        public static void SetIsApproved(Provider P)
        {
            P.isApproved = P.confirmPassword == P.password;
        }

        public static void SetIsApproved(string password, string confirmPassword, ref bool isApproved)
        {
            isApproved = password == confirmPassword;
        }


        public bool Login(string userName, string password, string email)
        {
            if (email != null)
            {
                if (userName == Username && password == Password && Email == email)
                { return true; }
                else { return false; }
            }
            else
            {
                if (userName == Username && password == Password)
                { return true; }
                else { return false; }
            }
        }


        public List<Product> GetProducts(string filterType, string filterValue)
        {
            List<Product> list = new List<Product>();
            foreach (var item in Products)
            {

                switch (filterType)
                {
                    case "Price":
                        {
                            double y = 0;
                            double.TryParse(filterValue, out y);
                            if (item.Price == y)
                            {
                                list.Add(item);
                            }
                            break;
                        }
                    case "Quantity":
                        int x = 0;
                        int.TryParse(filterValue, out x);
                        if (item.Price == x)
                        {
                            list.Add(item);
                        }
                        break;
                    default:
                        break;
                }


            }
            return list;
        }

        public override string GetDetails()
        {
            string details = $"[{Id},{Username},{Email},{isApproved}]";
            details = details + "\n List of products: \n";

            foreach (Product item in Products)
            {
                details += "\t " + item;
            }
            return details;
        }
      

    }





}
