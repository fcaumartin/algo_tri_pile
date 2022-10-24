
class Program
{
    static Stack<int> p1 = new Stack<int>();
    static Stack<int> p2 = new Stack<int>();
    static Stack<int> p3 = new Stack<int>();

    public static void Main()
    {
        // Les trois piles sont déclarées au dessus
        Console.WriteLine("Tri par pile");

        // Génération d'un tableau d'entiers aléatoires dans p1
        Random generator = new Random();
        // for (int i = 0; i < 25; i++)
        // {
        //     p1.Push((int)generator.NextInt64(10));
        // }
        p1.Push(3);p1.Push(5);p1.Push(4);p1.Push(1);p1.Push(7);


        // move(p1, p2);

        while (p1.Count > 0)
        {
            if (p2.Count == 0 || p1.Peek() >= p2.Peek())
            {
                move(p1, p2);
            }
            else
            {
                move(p1, p3);

                while (p2.Count > 0 && p2.Peek() >= p3.Peek())
                {
                    move(p2, p1);
                }

                move(p3, p1);

                while (p2.Count > 0)
                {
                    move(p2, p1);
                }

            }
        }
    }


    ////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////


    static void print(params Stack<int>[] piles)
    {
        Console.Clear();
        Console.WriteLine("————————————————————————————");
        foreach (var pile in piles)
        {
            foreach (var item in pile.Reverse())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("————————————————————————————");
        }
        // Thread.Sleep(20);
        // ou
        pause();
    }

    static void move(Stack<int> source, Stack<int> destination)
    {
        if (source.Count > 0)
            destination.Push(source.Pop());
        print(p1, p2, p3);
        
    }


    static void pause()
    {
        System.Console.WriteLine("next ? (Press Enter)");
        Console.ReadLine();
    }
}