﻿using System;

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

            string[] questions =
            {
                    "How many times has Lewis Hamilton won the Formula 1 world championship?",
                    "Which Formula 1 team based in Italy?"

            };

            string[] answers =
            {
                "A. 5   \nB. 7 \nC. 3   \nD. 8  \nE. 11",
                "A.Redbull \nB. Alpine  \nC. Williams \nD. Ferrari \nE. McLaren "
            };

            int[] correctAnswers = { 1,3 };
            int totalScore = 0;

            Console.WriteLine("Welcome to Formula 1 Quiz");

            for(int i=0; i<questions.Length;i++)
            {
                Console.WriteLine("Question" + (i + 1));
                Console.WriteLine(questions[i]);
                Console.WriteLine(answers[i]);
                Console.WriteLine("Please Enter your answer ('A','B','C','D','E'); ");
                string playerAnswer = Console.ReadLine();

                if (string.Equals(playerAnswer, "A"));
                {

                }
                else if()
                {

                }
            }

        }
    }
}