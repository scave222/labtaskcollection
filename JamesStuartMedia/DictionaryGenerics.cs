using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace JamesStuartMedia
{
    public class DictionaryGenerics : DictionaryBase
    {
         public void Add(string name, string department)
        {
            Dictionary.Add(name, department);
        }

        public void OnRemove(string name)
        {
            Dictionary.Remove(name);
        }

        //  public int CompareTo(DictionaryGenerics other)
        // {
        //     if(this.name > other.name)
        //     {
        //         return 1;
        //     }else if (this.name < other.name)
        //     {
        //         return -1;
        //     }else {
        //         return 0;
        //     }
        // }

         public void GetDetails()
        {
            IDictionaryEnumerator objEnumerate = Dictionary.GetEnumerator();
            while (objEnumerate.MoveNext())
            {
                Console.WriteLine(objEnumerate.Key.ToString() + "\t\t" + objEnumerate.Value);
            }
        }

        
    }
}