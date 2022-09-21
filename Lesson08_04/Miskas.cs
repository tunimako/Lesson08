using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08_04
{
    public class Miskas
    {
        public List<string> Medziai { get; set; }

        public Miskas (List<string> medziai)
        {
            Medziai = medziai;
        }

        public void PasodintiMedi(string medis)
        {
            Medziai.Add(medis);
        }
    }   
}