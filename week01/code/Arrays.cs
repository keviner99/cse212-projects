using System.Globalization;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // I used the Arrays_Tests.cs as a reference to complete this part
        // Step 1:  I declared the array that will store the multiples of the given number
        // Step 2: populate the array with multiples of the given number using a For Loop
        // The loop should iterate through each index of the multiples array 
        // Calculate the multiple for the index (i+1) starting from 1 up to length
        // Step 3: Return the array of doubles containing the multiples of the given number 
        
        double[] multiples = new double [length];

        for ( int i = 0; i < length; i ++) {
            multiples[i] = number * (i + 1);
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Use the following documentation https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0#methods 
        // to find the methods using for this part (AddRange, GetRange, RemoveRange, InsertRange)

        //use modulo (%) to deal with wrapping around the index number back to 0.
        amount = amount % data.Count;

        // Step 1: Store the length of the array in a variable 
        int arrayLength = data.Count();

        // Step 2: Create a temporary array called tempList, then use the GetRange method to get the amount to shift the list 
        // Take and store that number of the last values in a temporary array
        List<int> tempList = new List<int>();
        tempList.AddRange(data.GetRange(arrayLength - amount, amount));

        // Step 3: Remove the numbers from the end of the array for the number of values we stored. 
        data.RemoveRange(arrayLength - amount, amount);

        // Step 4: Use InsertRange to insert at the beginning of the array the values we stored previously in the temporary array
        data.InsertRange(0, tempList.GetRange(0, tempList.Count()));





    }
}
