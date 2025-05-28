using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lesson> lessons = new List<Lesson>();

            Console.Write("Quantas aulas tem o curso? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"\nDados da {i}a aula:");
                Console.Write("Conteúdo ou tarefa (c/t)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Título: ");
                string title = Console.ReadLine();

                if (ch == 'c')
                {
                    Console.Write("URL do vídeo: ");
                    string url = Console.ReadLine();
                    Console.Write("Duração em segundos: ");
                    int seconds = int.Parse(Console.ReadLine());
                    lessons.Add(new Video(title, url, seconds));
                }
                else
                {
                    Console.Write("Descrição: ");
                    string description = Console.ReadLine();
                    Console.Write("Quantidade de questões: ");
                    int questionCount = int.Parse(Console.ReadLine());
                    lessons.Add(new Entities.Task(title, description, questionCount));
                }
            }

            int totalDuration = 0;

            foreach (Lesson lesson in lessons)
            {
                totalDuration += lesson.Duration();
            }

            Console.WriteLine($"\nDURAÇÃO TOTAL DO CURSO = {totalDuration} segundos");
            
        }
    }
}
