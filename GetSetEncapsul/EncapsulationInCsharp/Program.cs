// using System;

// namespace EncapsulationInCsharp
// {
//     class person
//     {
//         private string Name;
//         private int Age;

//     public void SetPDetails (string Name, int Age)
//     {
//         if(string.IsNullOrEmpty(Name) == true)
//         {
//             Console.WriteLine("Enter Name correctly do not enter the blank name");
//             if (Age>0)
//             {
//                 Console.WriteLine("Enter Correct Age greater than 0 and do not entered negative value");
//             }
//             else
//             {
//                 this.Age = Age;
//             }
//         }
//         else
//         {
//             this.Name = Name; 
//         }
        
//     }
//     public void GetPDetails()
//     {
//         if(string.IsNullOrEmpty(this.Name)== true)
//         {
//             Console.WriteLine("Person Name is :{0}",this.Name);
//             if (Age > 0)
//             {
//                 Console.WriteLine("Person Age is :{0}",this.Age);
//             }
//             else
//             {
                
//             }
//         }
//         else
//         {
//         }
//     }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             person p = new person();
//             p.SetPDetails("Sahil",25);
//             p.GetPDetails();

//         }
//     }
// }

using System;

namespace EncapsulationInCsharp
{
    class person
    {
        private string Name;
        private int Age;

    public void SetName (string Name)
    {
        if(string.IsNullOrEmpty(Name))
        {
            Console.WriteLine("Enter Correct name");
        }
        else
        {
            this.Name = Name;   
        }
    }
    public void GetName()
    {
        if(string.IsNullOrEmpty(Name))
        {
            
        }
        else
        {
            Console.WriteLine("Person Name is :{0}",this.Name);
        }
    }
    public void SetAge(int Age)
    {
        if(Age>0)
        {
            this.Age = Age;
        }
        else
        {
            Console.WriteLine("Enter Correct Age");
        }
    }
    public void GetAge()
    {
        if(Age>0)
        {
            Console.WriteLine("Person Age is :{0}",this.Age);
        }
        else
        {
        }
    }

    }
    class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.SetName("Sahil");
            p.GetName();
            p.SetAge(24);
            p.GetAge();

        }
    }
}

