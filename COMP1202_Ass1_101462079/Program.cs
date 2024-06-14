using System;
using System.ComponentModel.Design;
using static System.Formats.Asn1.AsnWriter;

namespace Comp1202_Ass1_101462079
{
    class QuizProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Course code:");
            string courseCode = Console.ReadLine();
            Console.WriteLine("Enter Your First Name and Last Name");
            Console.WriteLine("");
            Console.WriteLine("");
            string firstLastName = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(courseCode + "  " + firstLastName);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Welcome to Formula 1 Quiz");
            Console.WriteLine("There is a multiple-choise question with 5 options. Every question is worth 25 points");




            string[] questions =
            {
                    "How many times has Lewis Hamilton won the Formula 1 world championship?",
                    "Which Formula 1 team based in Italy?",
                    "Which Country did Lewis Hamilton won the 7th Championship?",
                    "What year to Max Verstappen Win his first Championship?",

            };


            string[] answers =
            {
                "A. 5   \nB. 7 \nC. 3   \nD. 8  \nE. 11",
                "A.Redbull \nB. Alpine  \nC. Williams \nD. Ferrari \nE. McLaren",
                "A. Canada \nB. Germany  \nC Netherlands \nD. Japan  \nE. Turkey",
                "A. 2021 \nB. 2016 \nC. 2023 \nD. 2008 \nE.2012",

            };



            char[] quizCorrectAnswers =
            {
                'B','D','E','A'
            };
            int totalQuizPonts = 0;
            int quizPoints = 25;
            
            //int playerScore = 25;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine("Question " + i + 1);
                Console.WriteLine(questions[i]);
                Console.WriteLine(answers[i]);
                Console.WriteLine("Please enter your answer");
                char playerAnswer = char.ToUpper(Console.ReadLine()[0]);


                if (playerAnswer == quizCorrectAnswers[i])
                {
                    Console.WriteLine("CORRECT ANSWER");
                    
                    totalQuizPonts += quizPoints;
                }
                else
                {
                    Console.WriteLine("Wrong");
                    
                }
            }




         Console.WriteLine("Your Score is: " + totalQuizPonts);

        }
    }
}
