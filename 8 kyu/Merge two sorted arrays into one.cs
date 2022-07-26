//Merge two sorted arrays into one
//You are given two sorted arrays that both only contain integers. 
//Your task is to find a way to merge them into a single one, sorted in asc order. 
//Complete the function mergeArrays(arr1, arr2), where arr1 and arr2 are the original sorted arrays.

//You don't need to worry about validation, since arr1 and arr2 must be arrays with 0 or more Integers. 
//If both arr1 and arr2 are empty, then just return an empty array.

//Note: arr1 and arr2 may be sorted in different orders. Also arr1 and arr2 may have same integers. Remove duplicated in the returned result.
//Examples (input -> output)

//* [1, 2, 3, 4, 5], [6, 7, 8, 9, 10] -> [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

//* [1, 3, 5, 7, 9], [10, 8, 6, 4, 2] -> [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

//* [1, 3, 5, 7, 9, 11, 12], [1, 2, 3, 4, 5, 10, 12] -> [1, 2, 3, 4, 5, 7, 9, 10, 11, 12]

//Happy coding!

using System;
using System.Linq;
public class Kata
{
  public static int[] MergeArrays(int[] arr1, int[] arr2)
  {
int count1 = arr1.Length;
  int count2 = arr2.Length;
  int[] newArr = new int[count1 + count2];
  int a = 0, b = 0;
  int i = 0;  

  while (a < count1 && b < count2) {
  
  if (arr1[a] <= arr2[b]) {
    newArr[i++] = arr1[a++];
   }
   
   else {
     newArr[i++] = arr2[b++];
   }
   }

   if (a < count1) {
  
   for (int j = a; j < count1; j++) {
    newArr[i++] = arr1[j];
   }
   }
   
   else {
   
   for (int j = b; j < count2; j++) {
    newArr[i++] = arr2[j];
    }
    }
    
    Array.Sort(newArr);
    newArr = newArr.Distinct().ToArray();
    Console.WriteLine("");
    Console.Write("New array: ");
    
    for (int k = 0; k < newArr.Length; k++) {  
     Console.Write(newArr[k]+" ");  
    } 
    
    return newArr;
  }
    }
  
