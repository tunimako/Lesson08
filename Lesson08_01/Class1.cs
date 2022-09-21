using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08_01
{
    public class BuilderService : IBuilderService
    {
        public int MedziaguSkaiciavimas(int medziaga1, int medziaga2)
        {
            return medziaga1 + medziaga2;
        }
    }
}