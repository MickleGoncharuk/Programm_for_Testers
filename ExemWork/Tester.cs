using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExemWork
{
    class Tester
    {
        public List<Question> list1;
        public List<Question> list2;
        public List<Question> list3;
        string path1, path2,path3;
        int mark;

        public void ReadData()
        {
            FileStream fs = new FileStream(path1, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string data = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            string[] rows = data.Split('\n');
            foreach (string r in rows)
            {
                if (r != String.Empty)
                {
                    string[] words = r.Split('|');
                    Question w = new Question(Convert.ToInt32(words[0]), words[1], Convert.ToInt32(words[2]));
                    list1.Add(w);
                }
            }
            FileStream fs2 = new FileStream(path2, FileMode.Open, FileAccess.Read);
            StreamReader sr2 = new StreamReader(fs2, Encoding.UTF8);
            string data2 = sr2.ReadToEnd();
            sr2.Close();
            fs2.Close();
            string[] rows2 = data2.Split('\n');
            foreach (string r in rows2)
            {
                if (r != String.Empty)
                {
                    string[] words = r.Split('|');
                    Question w = new Question(Convert.ToInt32(words[0]), words[1], Convert.ToInt32(words[2]));
                    list2.Add(w);
                }
            }
        }


        public Tester()
        {
            mark = 0;
            list1 = new List<Question>();
            list2 = new List<Question>();
            list3 = new List<Question>();
            path1 = @"..\..\sharp.txt";
            path2 = @"..\..\JS.txt";
            path3 = @"..\..\otvetu.txt";
            ReadData();
        }

        public void SaveData()
        {

            FileStream fs = new FileStream(path3, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw= new StreamWriter(fs, Encoding.UTF8);
            foreach (Question p in list3)
                sw.WriteLine(p);
            sw.Close();
            fs.Close();
        }

        public void Display()
        {
            Console.WriteLine("Какой тест вы хотите пройти? C#/JS ");
            string res = Console.ReadLine();
            int ans;
            if (res == "C#")
            {
                foreach (Question g in list1)
                {
                    Console.WriteLine(g.Quest);
                    Console.WriteLine("Да или нет?(0-Нет;1-Да)");
                    ans = Convert.ToInt32(Console.ReadLine());
                    list3.Add(new Question(g.Number, g.Quest, ans));
                    if (ans == g.Answer) mark++;
                }
            }
            else if (res == "JS")
            {
                foreach (Question g in list2)
                {
                    Console.WriteLine(g.Quest);
                    Console.WriteLine("Да или нет?(0-Нет;1-Да)");
                    ans = Convert.ToInt32(Console.ReadLine());
                    list3.Add(new Question(g.Number, g.Quest, ans));
                    if (ans == g.Answer) mark++;
                }
            }
            else
                Console.WriteLine("Такого теста нет!");
            SaveData();
        }

        public void Mark()
        {
            Console.WriteLine(mark);
        }
    }
}

