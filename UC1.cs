using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProgram
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            if (message.ToLower().Contains("happy"))
            {
                return "Happy Mood";
            }
            else if (message.ToLower().Contains("sad"))
            {
                return "Sad Mood";
            }
            else
            {
                return "Unable to determine mood";
            }
        }
    }
}
