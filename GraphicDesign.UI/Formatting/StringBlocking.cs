using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Common.Formatting
{
    public static class StringBlocking
    {
        public static int MaxLineLenght = Console.WindowWidth - 1;
        private static StringBuilder sb = new StringBuilder();
        public static string ToTextBlock(this string text, string indent, bool fromNewLine = false)
        {
            if(text == null)
            {
                return null;
            }
            //StringBuilder sb = new StringBuilder();
            stupidMethodIDKHowToNameIt(fromNewLine);
            int pos = 0;
            int len = MaxLineLenght - indent.Length - 1;
            while(pos < text.Length)
            {
                sb.Append(indent);
                if(text.Length - pos >= len)
                {
                    sb.AppendFormat("{0}\n", text.Substring(pos,len));
                }
                else
                {
                    sb.Append(text.Substring(pos));
                }
                pos += len;
            }
            return sb.ToString();
        }
        public static string ToTextBlock(this string text, int indentLenght, bool fromNewLine = false)
        {
            string indent = new string(' ', indentLenght);
            return ToTextBlock(text, indent, fromNewLine);
        }
        public static string ToTextBlocks(this string text, string indent, bool fromNewLine = false, int cursor = 0)
        {
            if (text == null)
            {
                return null;
            }
            //StringBuilder sb = new StringBuilder();
            string cursor_shift = new string(' ', cursor);
            indent = cursor_shift + indent;
            int start_len = indent.Length + cursor_shift.Length;
            stupidMethodIDKHowToNameIt(fromNewLine);
            int pos = start_len;
            foreach(char a in text)
            {
                sb.Append(a);
                if (a == '\n')
                {
                    sb.Append(indent);
                    pos = start_len;
                }
                if (pos >= MaxLineLenght)
                {
                    pos = start_len;
                    if (a != '\n')
                    {
                        bool flag = true;
                        if (!" .,!?".Contains(a))
                        {
                            for (int i = sb.Length - 1; i >= sb.Length - MaxLineLenght - start_len; i--)
                            {
                                if (sb[i] == ' ')
                                {
                                    flag = false;
                                    sb.Insert(i, '\n');
                                    sb.Insert(i++, indent);
                                    pos = start_len + sb.Length - i;

                                    break;
                                }
                            }
                        }
                        if (flag)
                        {
                            sb.Append('\n');        
                            sb.Append(indent);
                        }
                    }
                }
                pos++;
            }
            removeEmptyLines();

            return sb.ToString();
        }
        private static void stupidMethodIDKHowToNameIt(bool fromNewLine)
        {
            sb.Clear();
            if (fromNewLine)
            {
                sb.AppendLine();
            }
        }
        private static void removeEmptyLines()
        {
            string[] strings = sb.ToString()
                .Split(new[] {"\n", "\r", "\r\n"}, StringSplitOptions.None)
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .ToArray();
            sb.Clear();

            foreach (string s in strings)
            {
                sb.AppendLine(s);
            }
        }
    }
}
