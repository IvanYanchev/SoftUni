using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        string firstList = "Peter Alex Maria Todor Steve Diana Steve";
        string secondList = "Todor Steve Nakov";
        List<string> namesFromFirstList = firstList.Split(new char[] { ' ', ',', '.' }).ToList();
        List<string> namesFromSecondList = secondList.Split(' ').ToList();

        foreach (var name in namesFromSecondList)
        {
            namesFromFirstList.RemoveAll(item => item == name);
        }
        foreach (var name in namesFromFirstList)
        {
            Console.Write("{0} ", name);
        }
    }
}