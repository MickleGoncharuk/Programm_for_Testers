using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExemWork
{
    class Editor
    {
        public List<Question> Questions1;
        public List<Question> Questions2;

        string path1, path2;

        public void ReadQuest()
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
                  Questions1.Add(w);
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
                  Questions2.Add(w);
              }
          }
      }

        public Editor()
        {
            Questions1 = new List<Question>();
          Questions2= new List<Question>();
            path1 = @"..\..\sharp.txt";
            path2 = @"..\..\JS.txt";
            ReadQuest();
        }

        public void SaveQuest()
        {
            FileStream fs1 = new FileStream(path1, FileMode.Open, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(fs1, Encoding.UTF8);
            foreach (Question p in Questions1)
                sw1.WriteLine(p);
            sw1.Close();
            fs1.Close();
            FileStream fs2 = new FileStream(path2, FileMode.Open, FileAccess.Write);
            StreamWriter sw2 = new StreamWriter(fs2, Encoding.UTF8);
            foreach (Question p in Questions2)
                sw2.WriteLine(p);
            sw2.Close();
            fs2.Close();
        }

        public void Show() 
        {
            Console.WriteLine("Какой тест вы хотите увидеть? C#/JS");
            string res = Console.ReadLine();
            if (res == "C#")
            foreach (Question g in Questions1)
                Console.WriteLine(g);
            else if (res == "JS")
                foreach (Question g in Questions2)
                    Console.WriteLine(g);
            else
                Console.WriteLine("Такого теста нет!");
        }

        public void AddQuestion()
        {
            Console.WriteLine("Какой тест вы хотите изменить? C#/JS");
            string res = Console.ReadLine();
            Console.WriteLine("Какой вопрос?");
            string q = Console.ReadLine();
            Console.WriteLine("Какой ответ?");
            int a =Convert.ToInt32( Console.ReadLine());
            if (res == "C#"){
                int n=Questions1.Count+1;
                Questions1.Add(new Question(n, q, a));
                   }
            else if (res == "JS"){
                int n = Questions2.Count+1;
                Questions2.Add(new Question(n, q, a));
            }
            else
                Console.WriteLine("Нет такого теста!");
            SaveQuest();
        }

        public void Change()
        {
            Console.WriteLine("Какой тест вы хотите изменить? C#/JS");
            string res = Console.ReadLine();
            Console.WriteLine("Какой номер?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какой ответ?");
            int a = Convert.ToInt32(Console.ReadLine());
            if (res == "C#")
            {
                foreach (Question g in Questions1)
                    if (g.Number == n) g.Answer = a;
            }
            else if (res == "JS")
            {
                foreach (Question g in Questions2)
                    if (g.Number == n) g.Answer = a;
            }
            else
                Console.WriteLine("Такого теста нет!");
            SaveQuest();
        }

        public void Delete()
        {
            Console.WriteLine("Какой тест вы хотите изменить? C#/JS");
            string res = Console.ReadLine();
            Console.WriteLine("Какой вопрос?");
            int n = Convert.ToInt32(Console.ReadLine())-1;
            if (res == "C#")
            {
                        Questions1.RemoveAt(n);
            }
            else if (res == "JS")
            {  
                Questions2.RemoveAt(n); 
            }
            else
                Console.WriteLine("Такого теста нет!");
            SaveQuest();
        }
    }
    
}
