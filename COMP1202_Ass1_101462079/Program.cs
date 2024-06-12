using System;
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
            string firstLastName = Console.ReadLine();
            Console.WriteLine("There is a multiple-choise question with 5 options. Every question is worth 25 points");
            Console.WriteLine("Welcome to Formula 1 Quiz");

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

            int questionsAll = 4;
            int eachscore = 25;
            int[] correctAnswers = { 1,3,4,0 };
            int correctAnswerCount = 0;
            int persantageScore = questionsAll * eachscore;


            for (int i = 0; i < questionsAll; i++)
            {
                Console.WriteLine("Question" + (i + 1));
                Console.WriteLine(questions[i]);
                Console.WriteLine(answers[i]);
                Console.WriteLine("Please Enter your answer: ");

                string playerAnswer = Console.ReadLine();
                

                

                if (string.Equals(playerAnswer, "A", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 0)
                {
                    correctAnswerCount++;
                    
                }
                else if (string.Equals(playerAnswer, "B", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 1)
                {
                    correctAnswerCount++;
                    
                }
                else if (string.Equals(playerAnswer, "C", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 2)
                {
                      correctAnswerCount++;
                    
                }
                else if(string.Equals(playerAnswer, "D", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 3)
                {
                    correctAnswerCount++;
                   
                }
                else if(string.Equals(playerAnswer, "E", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 4)
                {
                    correctAnswerCount++;
                   
                }

                
           }

            int totalScore = correctAnswerCount * eachscore;
            double persentageScore = ((double)totalScore /  eachscore) * 100;
            Console.WriteLine("Quiz Completed!");
            Console.WriteLine("Your score is: " + correctAnswerCount * 25 + " out of " + (questionsAll * 25));


        }

    }
}
