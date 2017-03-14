using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            Editor ed = new Editor();
            Tester t=new Tester();


            do
            {
                m.Menu1();
                switch (m.Vubor)
                {
                    case 1:
                        ed.Show();
                        break;
                    case 2:
                        ed.AddQuestion();
                     
                        break;
                    case 3:
                        ed.Change();
                        break;
                            case 4:
                        ed.Delete();
                        break;
                            case 5:
                        t.Display();
                        break;
                            case 6:
                        t.Mark();
                        break;
       
                }
            }
            while (m.Podtverzdenie());

            m.TheEnd();
        }

    }
}
