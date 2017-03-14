using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemWork
{
    class Menu
    {
        string otvet;
        int vubor;

        public int Vubor
        {
            get { return vubor; }
        }

        public void Menu1()
        {
            Console.Clear();
            
            Console.WriteLine("     Система оценивания знаний");
            Console.WriteLine("\n          MENU             ");
            Console.WriteLine("\n   1 - Просмотр теста");
            Console.WriteLine("\n   2 - Добавление вопроса");
            Console.WriteLine("\n   3 - Изменение вопроса");
            Console.WriteLine("\n   4 - Удаление вопроса");
            Console.WriteLine("\n   5 - Пройти тест");
            Console.WriteLine("\n   6 - Показать оценку");
            

            Console.Write("\n> Выберите нужное действие: ");
            vubor = Convert.ToInt32(Console.ReadLine());
        }

        public bool Podtverzdenie()
        {
            Console.Write("\n> Еще (y/n)? - ");
            otvet = Console.ReadLine();
            return (otvet == "y");
        }

        public void TheEnd()
        {
            Console.WriteLine("\n\nПрограмма завершена");
        }
    }
    
}
