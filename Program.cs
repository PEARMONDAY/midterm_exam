using System;
using System.Collections.Generic;
namespace Midterm2
{
    enum Home_Screen
    {
        Login = 1,
        Register 
    }
    enum User_Type
    {
        Student = 1,
        Employee
    }
    enum Student
    {
        Book = 1
    }
    enum Employee
    {
        Show_Book = 1
    }
    enum Store_Book
    {
        Now = 1 ,
        Revolut,
        Degrees,
        Vacances
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader_HomeScreen();
            InputMenu();
            PrintHeader_Login();
        }
        static void PrintHeader_HomeScreen()
        {
            Console.WriteLine("Welcome to Digital Library");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1.Login \n2.Register");
            Console.WriteLine("Select Menu :");
        }
        static void PrintHeader_Register()
        {
            Console.WriteLine("Register new Person");
            Console.WriteLine("-------------------");
        }
        static void PrintHeader_Login()
        {
            Console.WriteLine("Login Screen");
            Console.WriteLine("-------------");
        }
        public static User_Type user_type()
        {
            User_Type user_type = (User_Type)(int.Parse(Console.ReadLine()));
            return user_type;
        }
        static void InputUser_Type()
        {
            Console.Write("Input name : ");
            string name = Console.ReadLine();
            Console.Write("Input Password : ");
            string password = Console.ReadLine();
            Console.Write("Input User Type : ");
            string user_type = Console.ReadLine();
            Console.Write("Input ID : ");
            string id = Console.ReadLine();
            Register register = new Register(name, password, user_type, id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Type ID: " + user_type,id);
        }
        static void InputMenu()
        {
            Home_Screen home_screen = (Home_Screen)(int.Parse(Console.ReadLine()));
            PresentMenu(home_screen);
        }
        static void PresentMenu(Home_Screen home_screen)
        {
            if(home_screen == Home_Screen.Login)
            {

            }
            else if (home_screen == Home_Screen.Register)
            {
                PrintHeader_Register();
                InputUser_Type();
                PrintHeader_HomeScreen();
                InputMenu();
            }
        }
    }
    class Register
    {
        public string Name;
        public  string Password;
        public string User_Type;
        public  string ID;
        public Register(string Name, string Password,string user_type, string ID)
        {
            this.Name = Name;
            this.Password = Password;
            this.User_Type = user_type;
            this.ID = ID;
        }
    }
}
