using System;



namespace RPGEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Player X = new Player();
            Enemy Y = new Enemy();
            X.moveEntity(1, 2);
            Y.moveEntity(10, 20);
            int d = X.location.distance(Y.location);
            Console.WriteLine(d.ToString());
        }
    }
}
