string[] testArray = new string[] { "Hello", "2", "world", ":-)" };
int numOfSymbols = 3;

string[] resultArray = CreateArray(testArray, numOfSymbols);
FillArray(testArray, resultArray, numOfSymbols);
Console.WriteLine($"[{String.Join(", ", resultArray)}]");

string[] CreateArray(string[] array, int maxStringLength)
{
    int count = 0;
    foreach (string el in array)
    {
        if (el.Length <= maxStringLength) count++;
    }
    string[] result = new string[count];
    return result;
}

void FillArray(string[] fromArray, string[] inArray, int maxStringLength)
{
    int count = 0;
    foreach (string el in fromArray)
    {
        if (el.Length <= maxStringLength)
        {
            inArray[count] = el;
            count++;
        }
    }
}