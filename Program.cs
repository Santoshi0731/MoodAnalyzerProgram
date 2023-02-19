namespace MoodAnalyzerProgram
{

    class Program
    {
        public static void Main(String[] args)
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string message = "I am so happy today!";
            string mood = moodAnalyser.AnalyseMood(message);
            Console.WriteLine(mood);

            message = "I feel really sad today";
            mood = moodAnalyser.AnalyseMood(message);
            Console.WriteLine(mood);
        }
            
    }
}
