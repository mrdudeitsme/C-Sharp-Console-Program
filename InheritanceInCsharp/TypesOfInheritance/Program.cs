using System;

namespace TypesOfInheritance
{
    //-------------------------------------Single Inheritance---------------------------------

    // class baseclass
    // {
    //     public void show()
    //     {
    //         Console.WriteLine("Base class Method");
    //     }
    // }
    // class derived : baseclass
    // {
    //     public void show1()
    //     {
    //         Console.WriteLine("Derived class method");
    //     }
    // }
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         derived d1 = new derived();
    //         d1.show();
    //         d1.show1();
//         }
//     }
// }

 // ------------------------------------ Herarchical Inheritance------------------------------

//  class baseclass
//  {
//      public void show()
//     {
//         Console.WriteLine("Base class method");
//     }
//  }
//  class derivedclass1 : baseclass
//  {
//      public void show1()
//      {
//          Console.WriteLine("Derived class 1st method");
//      }
//  }
//  class derivedclass2 : baseclass
//  {
//      public void show2()
//      {
//          Console.WriteLine("Derived class 2nd method");
//      }
//  }
//  class derivedclass3 : baseclass
//  {
//      public void show3()
//      {
//          Console.WriteLine("Derived class 3rd method");
//      }
//  }
//  class Program
//     {
//         static void Main(string[] args)
//         {
//             //Method for Base class & derived class1
//             // derivedclass1 dc1 = new derivedclass1();
//             // dc1.show();
//             // dc1.show1();

//             //Method for Base class & derived class 2
//             // derivedclass2 dc2 = new derivedclass2();
//             // dc2.show();
//             // dc2.show2();

//             //Method for base class & derived class3
//             // derivedclass3 dc3 = new derivedclass3();
//             // dc3.show();
//             // dc3.show3();
            
//         }
//     }
// }

//-----------------------------------------Multilevel Inheritance -----------------------------

// class baseclass
//  {
//      public void show()
//     {
//         Console.WriteLine("Base class method");
//     }
//  }
//  class intermidiateclass : baseclass
//  {
//      public void show1()
//      {
//          Console.WriteLine("Derived class 1st method");
//      }
//  }
//  class derivedclass1 : intermidiateclass
//  {
//      public void show2()
//      {
//          Console.WriteLine("Derived class 2nd method");
//      }
//  }
//  class derivedclass2 : derivedclass1
//  {
//      public void show3()
//      {
//          Console.WriteLine("Derived class 3rd method");
//      }
//  }
//  class Program
//     {
//         static void Main(string[] args)
//         {
            //intermidiate class : baseclass
             // intermidiateclass imp = new intermidiateclass();
            // imp.show();
            // imp.show1();

            //derivedclass1 : intermidiate class
            // derivedclass1 dc1 = new derivedclass1();
            // dc1.show();
            // dc1.show1();
            // dc1.show2();

            //derivedclass2 : derivedclass1
            // derivedclass2 dc2 = new derivedclass2();
            // dc2.show();
            // dc2.show1();
            // dc2.show2();
            // dc2.show3();
//         }
//     }
// }


