using System;
using System.Collections.Generic;
using System.Text;

namespace TCPExtensions
{
    public static class Extension
    {
        public static List<T> Filter<T>(this List<T> records, Func<T, bool> func)
        { 
            List<T> filteredList = new List<T>();
            //Adiciona os elementos para a lista do tipo T
            foreach (T record in records) 
            {
                //se Func retornar true, então será adicionado a lista
                if (func(record))
                {
                    filteredList.Add(record);
                }
            }

            return filteredList;
        }
    }
}
