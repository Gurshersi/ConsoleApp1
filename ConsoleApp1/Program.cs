using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    { staic void Main(string[]args)}
 class village
    {
        public static int numberofvillages = 0;
        public village nextvillage;
        public village previousvillage;
        public string villageName;
        public bool isAstrildeHere = false;

        public village()
        {
            village.numberofvillages++;
        }

        class countryside
        {
            public village maple;
            public village toronto;
            public village ajax;

            public void MapInitializer()
            {
                maple = new village();
                maple.villageName = "maple";
                maple.nextvillage = toronto;
                toronto = new village();
                toronto.villageName = "toronto";
                toronto.nextvillage = ajax;
                ajax = new village();
                ajax.villageName = "ajax";
                ajax.nextvillage = null;
                ajax.previousvillage = toronto;
                ajax.isAstrildeHere = true;

            }

            public void LookforAstrilde()
    
    }

    }
        {
        }
    }
}
