using System;

namespace League
{
    class Program
    {
        Button PlayButton = new Button();
        Button FindMatch = new Button();
        Button AcceptMatch = new Button();
        Button DeclineMatch = new Button();
        Button SelectChampion = new Button();
        Button BanChampion = new Button();
        Button LockIn = new Button();

        static void Main(string[] args)
        {
            Console.WriteLine("Main");
        }
    }

    class Button
    {
        readonly string text;
        public int height = 100;
        public int width = 100;
        public string background = "White";
        public string image;

        public Button() { }

        public Button(string t, int h, int w, string bg, string im)
        {
            this.text = t;
            this.height = h;
            this.width = w;
            this.background = bg;
            this.image = ChampButton.image;
        }
    }

    class ChampButton : Button
    {
        public string image;

        public ChampButton(string im)
        {
            this.image = im;
        }
    }
}
