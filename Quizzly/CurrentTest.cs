using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzly
{
    public class CurrentTest
    {

        //class that stores the questions and answers to be rendered to each student when they take a test

        private List<string> questions = new List<string>();

        private List<string> answers = new List<string>();

        public List<string> Questions { get => questions; set => questions = value; }
        public List<string> Answers { get => answers; set => answers = value; }
    }
}
