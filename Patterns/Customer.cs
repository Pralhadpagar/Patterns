namespace Patterns
{

    //can not derive from static class
    //public class Customer : StaticTest
        public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public  readonly int number=12;
       public  const int myconstant = 34;

        public static void Main()

        {

        }

        static Customer()
        {
            const int myconstant2 = 34;
            int a = 5;
          // myconstant = a;
            // not work
            //number = 10;
            string name = "";
           // number = 10;
        }

        public Customer(string a) : this()
        {

           
        }

        //public string name, location;
        //// Parameterized Constructor
        //{
        //   //name = a;
        //   //location = b;
        //}
        public Customer()
        {
            const int myconstant2 = 34;
            number = 15;
            add(number);
            const int myconstant1 = 34;
            add(myconstant1);
             
            string name1 = "";
            
        }

        public void add(int a)
        {
            const int myconstant2 = 34;
            a = 5;

           // number = a;
            string asd = "";

            //const int myconstant2 = 34;

        }



    }
}