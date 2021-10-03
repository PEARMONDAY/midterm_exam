using System;
using System.Collections;
namespace Midterm1
{
    enum Menu
    {
        PlayGame = 1,
        Exit
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ปริ้นท์ค่าที่เรากำหนดเอาไว้
            PrintHeader();
            InputMenu();
            //ศัพท์ที่ใช้ในเกมส์
            string[] listwords = new string[3];
            listwords[0] = "Tennis";
            listwords[1] = "Football";
            listwords[2] = "Badminton";
            //ไว้แรนดอมคำศัพท์
            Random random = new Random();
            int resultRandom = random.Next(0, 2);
            string Word = listwords[resultRandom];
            char[] guess = new char[Word.Length];
            Console.WriteLine("Input letter alphabet: ");
            //กำหนดตัวแปรที่เราต้องใช้
            int y = 0;
            int Life = 6;
            int IncorrectScore = 0;
            bool A = false;
            //
            for (int p = 0; p < Word.Length; p++)
                guess[p] = '*';

            while (A!=true)
            {
                int x = Word.Length;
                char playerGuess = char.Parse(Console.ReadLine());
                
                for (int j = 0; j < Word.Length; j++)
                {
                    if (playerGuess == Word[j])
                    {
                        //หากแรนดอมออกมาแล้วเป็นคำที่ผิดจะแสดงผลตรงนี้ออกมา
                        guess[j] = playerGuess;
                        if (guess[j] != '.')
                        {
                            y++;
                            if (y == Word.Length)
                            {
                                A = true;
                            }
                        } 
                    }
                    else if (playerGuess != Word[j])
                    {                            
                        x--;
                        if (x == 0)
                        {
                            //ไว้บอกชีวิตที่ยังเหลืออยู่ในเกมส์
                           Life--;
                           Console.WriteLine("Incorrect Score: " + Life);
                            if(Life == 6)
                            {
                                A = true;
                            }
                            //เมื่อเราผิดครบ6ชีวิตและเราตาย
                            else if(Life == 0) 
                            {
                                Console.WriteLine("Game Over");
                            }
                        } 
                    }
                }
                Console.WriteLine(guess);
                //เมื่อชนะจะแสดงผลออกมา
            } Console.WriteLine("Win");
              IncorrectScore++;
              Console.WriteLine("Incorrect Score : " + IncorrectScore);
            
        }
        //ที่เอาไว้ไปปริ้นท์ข้างบน
        static void PrintHeader()
        {
            Console.WriteLine("Welcome to Hangman Game");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Play game \n2. Exit");
        }
        static void InputMenu()
        {
            Console.Write("Please Select Menu : ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));
        }
    }
}
