using System;
using System.Collections.Generic;
using static System.Console;
using System.IO;
using System.Xml;

namespace StudyAppP1
{
    public class Question
    {
        public Question()
        {
            //Question1(string Term, string Answer)
            /* Method = What the class does
             * 
             * 
             */
        }
       public string QuestionTerm;
        public string QuestionAnswer;

        public Question(string term, string answer)
        {
            QuestionTerm = term;
            QuestionAnswer = answer;

        }

    }
}

