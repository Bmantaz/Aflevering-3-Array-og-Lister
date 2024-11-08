namespace Aflevering_3_array_og_lister
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Array med spørgsmål
        string[] questions = {
            "Hvad er hovedstaden i Danmark?",
            "Hvad er 2 + 2?",
            "Hvilket år blev Danmark medlem af EU?"
        };

        // Array med svar, der matcher spørgsmålene
        string[] answers = {
            "København",
            "4",
            "1973"
        };
            int correctAnswersCount = 0;

            Console.WriteLine("Svar på spørgsmålene:");

        // Loop igennem alle spørgsmål og vis dem
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {questions[i]}");
        }
           
        Console.WriteLine("\nIndtast dit svar til hvert spørgsmål:");
            

        // Loop igennem alle spørgsmål for at få svar fra brugeren
        for (int i = 0; i < questions.Length; i++)
        {
            Console.Write($"{i + 1}. {questions[i]} ");
            string userAnswer = Console.ReadLine();

            // Tjek om svaret matcher det rigtige svar
            if (userAnswer.Equals(answers[i], StringComparison.OrdinalIgnoreCase))
            //if (userAnswer == answers[i])
                    {
                Console.WriteLine("Korrekt!");
                    correctAnswersCount++;
                }
            else
            {
                Console.WriteLine($"Forkert. Det rigtige svar er: {answers[i]}");

                    
                }
        }
            Console.WriteLine($"Du fik {correctAnswersCount} ud af {questions.Length} rigtige.");
        }
}
            
            
            
            
            
            
            







        

    
}
