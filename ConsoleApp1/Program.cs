using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    { staic void Main(string[] args)}
    { 
    countryside Ontario = new countryside();
}}
    
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
        }

        class countryside
        {
            public village maple;
            public village toronto;
            public village ajax;
            public village head;
            public village tail;
            public village temp;
    public void run()
    {
        this.MapInitializer();
        this.LookforAstrilde();
    }

            public void MapInitializer()
            {
                maple = new village();
                maple.villageName = "maple";
                maple.nextvillage = toronto;
                maple.previousvillage = null;
        maple.isAstrildeHere = true;
                toronto = new village();
        toronto.previousvillage = maple;
        toronto.villageName = "toronto";
                toronto.nextvillage = ajax;
                ajax = new village();
                ajax.villageName = "ajax";
                ajax.nextvillage = null;
                ajax.previousvillage = toronto;
                //ajax.isAstrildeHere = true;

            }

            public void LookforAstrilde()

            { head = maple;
        if (head.isAstrildeHere)
        { Console.WriteLine("Yeah ! Astrlide is in" + head.villageName);
        }
        //while (true)
        //{ 
    
    }//

    }
        
        }
    
}
