/*
 * TODO
 * The main of this exercise is to create 3 constructors for the class Phone:
 *  default constructor that sets all values to "unknown";
 *  constructor that takes 2 arguments (company and model) 
    and sets them respectively. The ReleaseDay should be set to "unknown";
 *  constructor with 3 arguments (company, model, and release day);
 */
namespace PhoneInfo
{
    internal class Phone
    {
        public string Company;
        public string Model;
        public string ReleaseDay;

        // Place for your 3 constructors
        public Phone()
        {
            Company = "unkown";
            Model = "unkown";
            ReleaseDay = "unkown";
        }

        public Phone(string company, string model)
        {
            Company = company;
            Model = model;
            ReleaseDay = "unkown";
        }
        public Phone(string company, string model, string releaseDay)
        {
            Company = company;
            Model = model;
            ReleaseDay = releaseDay;
        }


        public void Introduce()
        {
            Console.WriteLine("It is {0} created by {1}. It was released {2}.", Model, Company, ReleaseDay);
            //Console.WriteLine($"It is {Model} created by {Company}. It was released {ReleaseDay}.");
        }
    }
}