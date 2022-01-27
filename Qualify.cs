using System;

namespace CodingInterview
{
    class Qualify
    {
        static void main(string[] args)
        {
            int [] candidate = new int[8];

            foreach (int i in candidate)
            {
                Console.WriteLine("Answer this question");
                string reply = Console.ReadLine();

                if (reply = "yes")
                {
                    Console.WriteLine("How long did it take to answer the question?")
                    reply[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(i);
                }
                

                
            }
            string conclusion = InterviewDecision(reply);

            Console.WriteLine(reply);
            
        }

        public string InterviewDecision(int [] replies, int sum)
        {
            if (sum > 120)
            {
                Console.WriteLine("You have exceeded the time limit");
                return "disqualified";
            }

            else
            {
                if (replies[i] != 0 && replies[0] <= 5 && replies[1] <= 5 && replies[2] <= 10 && replies[3] <= 10 && replies[4] <= 15 && replies[5] <= 15 && replies[6] <= 20 && replies[7] <= 20)
                {
                    return "qualified";
                }

                else
                {
                    Console.WriteLine("one of your questions went over the time limit");
                    return "disqualified";
                }
            }
        }
    }
}