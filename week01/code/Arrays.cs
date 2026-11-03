
public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting
    /// with 'number' followed by multiples of 'number'.
    /// </summary>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array with the requested length.
        // Step 2: Loop through each position in the array.
        // Step 3: Multiply the number by the index plus 1.
        // Step 4: Store the result in the array.
        // Step 5: Return the completed array.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.
    /// This modifies the existing list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Find where the last 'amount' items begin.
        // Step 2: Copy those items into a temporary list.
        // Step 3: Remove those items from the original list.
        // Step 4: Insert the saved items at the beginning.
        // Step 5: The original list is now rotated.

        int startIndex = data.Count - amount;

        List<int> movedItems = data.GetRange(startIndex, amount);

        data.RemoveRange(startIndex, amount);

        data.InsertRange(0, movedItems);
    }
}
