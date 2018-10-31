using System;

namespace SimpleParser
{
    /// <summary>
    /// 一个简单的递归下降解析器
    /// </summary>
    class SimpleParser
    {
        static void Main(string[] args)
        {
            String code = Console.ReadLine();
            new SimpleParser().Parser(code);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        char[] chars;
        int i = 0;
        char NextChar()
        {
            if (i < chars.Length)
            {
                return chars[i++];

            }
            else
            {
                return '\0';
            }
        }
        char curchar;
        void Parser(String code)
        {
            chars= code.ToCharArray();
            curchar = NextChar();
            expr();
        }

        void expr()
        {
            term();
            while (true)
            {
                if (curchar == '+')
                {
                    match('+');
                    term();
                    Console.Write('+');
                }
                else if (curchar == '-')
                {
                    match('-');
                    term();
                    Console.Write('-');
                }
                else
                {
                    return;
                }
            }
        }
        void term()
        {
            if (Char.IsDigit(curchar))
            {
                Console.Write(curchar);
                match(curchar);
            }
            else
            {
                Console.WriteLine("term error");
                return;
            }
        }
        void match(char c)
        {
            if (curchar == c)
            {
                curchar = NextChar();
            }
            else
            {
                Console.WriteLine("match error");
            }
        }
    }
}
