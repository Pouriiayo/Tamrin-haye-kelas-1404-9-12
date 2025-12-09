
namespace GetValidArrayInput;

public static class GetValidInput
{
    public static string[] GetArrayInput()
    {
        Console.WriteLine("Adad haye array ra vared konid: (ex => 1 2 4 5 -1 2)");
        string[]? input = Console.ReadLine().Split(' ');
        return input;
    }

    public static bool TryParseArray(string[] input, out int[] arr)
    {
        arr = new int[input.Length];
        bool valid = true;

        for (int i = 0; i < input.Length; i++)
        {
            if (!int.TryParse(input[i], out arr[i]))
            {
                valid = false;
            }
        }

        return valid;
    }

    public static int[] ForceGetIntInput()
    {
        int[] arr;

        string[] input = GetArrayInput();

        while (!TryParseArray(input, out arr))
        {
            Console.WriteLine("Voroodi eshtebah ast! Lotfan faghat adad vared konid.");
            input = GetArrayInput();
        }

        return arr;
    }
}



