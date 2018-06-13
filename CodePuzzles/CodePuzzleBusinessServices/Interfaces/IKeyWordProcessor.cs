using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePuzzleBusinessServices.Interfaces
{
    public interface IKeyWordProcessor
    {
        /// <summary>
        /// Strip user input
        /// </summary>
        /// <param name="userInput">User input text</param>
        /// <returns></returns>
        string StripUserInput(string userInput);

        /// <summary>
        /// Identify the shape from the description
        /// </summary>
        /// <param name="strippedString"></param>
        /// <returns></returns>
        Shape IdentifyShape(string strippedString);
    }
}
