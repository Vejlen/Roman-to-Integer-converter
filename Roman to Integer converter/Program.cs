namespace RomanToIntConverter;

public class RomanToIntConverter
{
    private char[] signs = ['I', 'V', 'X', 'L', 'C', 'D', 'M'];
    private int[] valuesForSigns = [1, 5, 10, 50, 100, 500, 1000];

    public string? numberInRoman { get; set; }

    public void ToInt(string number)
    {
        int result = 0;
        for (int i = 0; i <= number.Length - 1; i++)
        {
            if (signs.Contains(number[i]))
            {
                {
                    if (i != number.Length - 1 && signs.Contains(number[i + 1]) && Array.IndexOf(signs, number[i + 1]) > Array.IndexOf(signs, number[i]))
                    {
                        result -= 2 * valuesForSigns[Array.IndexOf(signs, number[i])];
                    }
                    result += valuesForSigns[Array.IndexOf(signs, number[i])];
                }
            }
            else
            {
                throw new Exception("Not a Roman number");
            }
        }
        Console.WriteLine(result);
    }
}

public class App()
{
    static void Main(string[] args)
    {
        var Conv = new RomanToIntConverter();
        var testCases = new string[]
            {
                "III", // 3
                "IV", // 4
                "VI", // 6
                "LVIII", //58
                "MCMXCIV", // 1994
                "MMMCMLVIII" // 3958
            };
        foreach (var testCase in testCases)
        {
            Conv.ToInt(testCase);
        }
    }
}