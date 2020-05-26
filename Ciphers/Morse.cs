using System;
using System.Collections.Generic;

namespace Morse
{
    internal class Morse
    {
        public static string Encrypt(string msg)
        {
            Dictionary<string,string> data = new Dictionary<string,string>();
            data.Add("A", "._");
            data.Add("B", "_...");
            data.Add("C", "_._.");
            data.Add("D", "_..");
            data.Add("E", ".");
            data.Add("F", ".._.");
            data.Add("G", "__.");
            data.Add("H", "....");
            data.Add("I", "..");
            data.Add("J", ".___");
            data.Add("K", "_._");
            data.Add("L", "._..");
            data.Add("M", "__");
            data.Add("N", "_.");
            data.Add("O", "___");
            data.Add("P", ".__.");
            data.Add("Q", "__._");
            data.Add("R", "._.");
            data.Add("S", "...");
            data.Add("T", "_");
            data.Add("U", ".._");
            data.Add("V", "..._");
            data.Add("W", ".__");
            data.Add("X", "_.._");
            data.Add("Y", "_.__");
            data.Add("Z", "__..");
            data.Add("0", "_____");
            data.Add("1", ".____");
            data.Add("2", "..___");
            data.Add("3", "...__");
            data.Add("4", "...._");
            data.Add("5", ".....");
            data.Add("6", "_....");
            data.Add("7", "__...");
            data.Add("8", "___..");
            data.Add("9", "____.");
            data.Add(" ", " ");
            
            msg = msg.ToUpper();
            string new_msg = "";
            for (int i = 0; i < msg.Length; i++)
            {
                new_msg += data[msg[i].ToString()] + " ";
            }
            return new_msg;
        }
        
    }
}
