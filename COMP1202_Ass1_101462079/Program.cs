using System;
using System.ComponentModel.Design;
using System.Diagnostics;
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
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(courseCode + "  " + firstLastName);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.Clear();
            
            Console.WriteLine("Welcome to Formula 1 Quiz");
            Console.WriteLine("");
            Console.WriteLine("There is a multiple-choise question with 5 options. Every question is worth 25 points");
            Console.WriteLine("");
            




            string[] questions =
            {
                    "How many times has Lewis Hamilton won the Formula 1 world championship?",
                    "Which Formula 1 is team based in Italy?",
                    "Which Country did Lewis Hamilton won the 7th Championship with?",
                    "What year did Max Verstappen Win his first Championship?",

            };


            string[] answers =
            {
                "A. 5   B. 7    C. 3    D. 8    E. 11",
                "A. Redbull   B. Alpine   C. Williams   D. Ferrari  E. McLaren",
                "A. Canada    nB. Germany     C Netherlands    D. Japan   E. Turkey",
                "A. 2021   B. 2016   C. 2023   D. 2008   E.2012",

            };

  
            char[] quizCorrectAnswers =
            {
                'B','D','E','A'
            };

            string[] comments =
            {
                " ", " ", " ", " ",
            };

            int totalQuizPonts = 0;
            
            

            for (int i = 0; i < questions.Length; i++)
            {
                bool isTrue = false;
                int wrongCounter = 0;
                int quizPoints = 25;
                char playerAnswer = ' ';


                while (isTrue == false && wrongCounter < 4)
                {
                    Console.WriteLine("Question " + (i + 1) + "/4 || Total Score: " + totalQuizPonts + "%");
                    Console.WriteLine(" ");
                    Console.WriteLine("Question " + (i + 1));
                    Console.WriteLine(questions[i]);
                    Console.WriteLine(answers[i]);
                    Console.WriteLine("Please enter your answer");
                    playerAnswer = char.ToUpper(Console.ReadLine()[0]);

                    if (playerAnswer == quizCorrectAnswers[i])
                    {
                        Console.WriteLine("CORRECT ANSWER");
                        Console.Clear();

                        totalQuizPonts += quizPoints;
                        isTrue = true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong");
                        isTrue = false;
                        wrongCounter++;
                        Console.Clear();

                        switch (wrongCounter)
                        {
                            case 0:
                                quizPoints = 25;
                                break;
                            case 1:
                                quizPoints = 15;
                                break;
                            case 2:
                                quizPoints = 5;
                                break;
                            case 3:
                                quizPoints = 0;
                                break;
                            default:
                                break;
                        }

                    }

                    if (wrongCounter < 4)
                    {
                        comments[i] = "Question " + (i + 1) + ": The user chose the correct answer after " + (wrongCounter+1) + " attempt(s). " + quizPoints + " points earned.";
                    } else
                    {
                        comments[i] = "Question " + (i + 1) + ": The user could not choose the correct answer after 4 tries. 0 points earned.";
                    }
                     

                }
                
            }
            Console.WriteLine(firstLastName + " || " + courseCode);
            Console.WriteLine("");
            Console.WriteLine("Your Score is: " + totalQuizPonts + "/100");
            Console.WriteLine("");
            for (int k=0; k < comments.Length; k++)
            {
                Console.WriteLine(comments[k]);
            }
            Console.WriteLine("");
            Console.WriteLine("Result= " + totalQuizPonts + "%");

        }
    }
}
