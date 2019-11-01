using System;

namespace AutoAmorAmorDoAlto
{
    public class ChainMethods

    {
        public static void Main()
        {
            var my = new StringWorkaround();
            my.add("Sergio ").add("Ferreira..¢Éª◙").remove().remove().remove().remove().remove();
            Console.WriteLine(my.print());
            Console.ReadKey();
        }
    }

    public class StringWorkaround
    {
        private string _content = "";


        public StringWorkaround add(string world)
        {
            _content += world;
            return this;
        }
        public StringWorkaround remove()
        {
            _content = _content.Remove(_content.Length - 1, 1);
            return this;
        }
        public string print()
        {
            return _content;
        }
    }
}