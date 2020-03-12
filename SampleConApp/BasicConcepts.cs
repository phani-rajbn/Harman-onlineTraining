using System;

namespace SampleConApp
{
    class BasicConcepts
    {
        static void Main(string[] args)
        {
            foreachExample();
        }
        //Use for for assigning values to a collection and use foreach for reading the data of the collection. foreach is forward only and read only. U cannot use foreach to access the items of the collection in a reverse order. U cannot modify the data of the collection using foreach. 
        private static void foreachExample()
        {
            var array = new int[] { 123, 23, 32, 34, 66, 765, 4, 5, 3, 54 };
            foreach (var item in array)
            {
                //if(item == 66)
                //{
                //    item += 5;
                //}
                Console.WriteLine(item);
            }
        }
    }
}
