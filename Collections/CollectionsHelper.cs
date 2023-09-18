using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    public static class CollectionsHelper
    {
        public static List<int> AddRandomNumbersToList(List<int> numbers, int quantity)
        {
            for (int k = 0; k < quantity; k++)
            {
                Random rnd = new Random();
                numbers.Add(rnd.Next());
            }

            return numbers;
        }

        // output strings aus der Lösung gestibitzt
        public static (List<int>, string) RemoveElementFromList(List<int> numbers, int element)
        {
            string text = "Element not found"; 
            if (numbers.Contains(element))
            {
                numbers.Remove(element);
                text = "Element removed successfully";
            }

            return (numbers, text);
        }

        public static bool CheckElementInList(List<int> numbers, int element)
        {
            return numbers.Contains(element);
        }

        public static int FindMax(List<int> numbers)
        {
            
            return numbers.Count > 0 ? numbers.Max() : 0;
        }
        public static int FindMin(List<int> numbers)
        {
            return numbers.Count > 0 ? numbers.Min() : 0;
        }
        public static double CalculateAverage(List<int> numbers)
        {
            return numbers.Count > 0 ? numbers.Average() : 0;
        }

    }
}
