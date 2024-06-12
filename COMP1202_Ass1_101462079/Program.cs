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
                    "Which Driver Called 'LION OF ISTANBUL'"
            };

            string[] answers =
            {
                "A. 5   \nB. 7 \nC. 3   \nD. 8  \nE. 11",
                "A.Redbull \nB. Alpine  \nC. Williams \nD. Ferrari \nE. McLaren",
                "A. Canada \nB. Germany  \nC Netherlands \nD. Japan  \nE. Turkey",
                "A. 2021 \nB. 2016 \nC. 2023 \nD. 2008 \nE.2012",
                "A.Sebastian VETTEL \nB.Charles Leclerc \nC.Felipe Massa \nD.Lando Norris \nE.Jenson Botton"
            };

            int allQuestions = 5;
            int eachscore = 25;
            int[] correctAnswers = { 1,3,4,0,2 };
            int totalScore =(allQuestions * eachscore) ;


            for (int i = 0; i < allQuestions; i++)
            {
                Console.WriteLine("Question" + (i + 1));
                Console.WriteLine(questions[i]);
                Console.WriteLine(answers[i]);
                Console.WriteLine("Please Enter your answer: ");

                string playerAnswer = Console.ReadLine();
                

                

                if (string.Equals(playerAnswer, "A", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 0)
                {
                    totalScore++;
                    eachscore++;
                }
                else if (string.Equals(playerAnswer, "B", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 1)
                {
                    totalScore++;
                    eachscore++;
                }
                else if (string.Equals(playerAnswer, "C", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 2)
                {
                    totalScore++;
                    eachscore++;
                }
                else if(string.Equals(playerAnswer, "D", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 3)
                {
                    totalScore++;
                    eachscore++;
                }
                else if(string.Equals(playerAnswer, "E", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 4)
                {
                    totalScore++;
                    eachscore++;
                }

                
                

                

            }
            Console.WriteLine("Quiz Complated!");
            Console.WriteLine("Your score is: " + totalScore);
            
        }

    }
}
