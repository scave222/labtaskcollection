using System;
using System.Collections;
using System.Collections.Generic;


namespace JamesStuartMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryGenerics dic = new DictionaryGenerics();
            dic.Add("Tom Lee", "Training");
            dic.Add("James Anderson", "HR");
            dic.Add("Michael Chan", "Content Development");
            dic.Add("Jackie Jackson", "Training");
            dic.Add("Bruce Douglas", "Graphics");
            dic.Add("Kim Date", "HR");
            dic.Add("Joseph Mathews", "Content Development");
            dic.Add("Rose Dorson", "Marketing");
            dic.Add("Andrews Stephan", "Graphics");
            //dic.Sort(dic);

            Console.WriteLine("===============Dictionary List==================");
            dic.OnRemove("Rose Dorson");
            dic.GetDetails();
            //dic.OnRemove();
            SortedList srt = new SortedList();
            srt.Add("Tom Lee", "Training");
            srt.Add("James Anderson", "HR");
            srt.Add("Michael Chan", "Content Development");
            srt.Add("Jackie Jackson", "Training");
            srt.Add("Bruce Douglas", "Graphics");
            srt.Add("Kim Date", "HR");
            srt.Add("Joseph Mathews", "Content Development");
            srt.Add("Rose Dorson", "Marketing");
            srt.Add("Andrews Stephan", "Graphics");

            
            Console.WriteLine("===============Sorted List==================");
             for(int i = 0; i < srt.Count; i++)
             {
                 Console.WriteLine("{0},{1}", srt.GetKey(i) ,  srt.GetByIndex(i));
             }
            // bool rst = srt.ContainsValue("Rose Dorson");
            // Console.WriteLine(rst);
        }
    }
}
