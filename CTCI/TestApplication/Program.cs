using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardQuestions.ValidParenthesisQuestions printParam = new StandardQuestions.ValidParenthesisQuestions();
            printParam.ValidParenthesisCombinations(3);
        }
    }
}
