
public class Program
{
    public static void Main()
    {
        //You should use main to test your static methods below.
        //Your static methods should be contained within the program class, but not in main
    }

    //Changed the string[] to a list, then used the indexOf method to find index.
    public static int AddStarWarsCharacters(string[] characters)
    {
        List<string> charList = characters.ToList();

        int index = charList.IndexOf("Yoda");

        return index;
    }

    //Made a placeholder for highest number, and the strongest jedi.
    //The loop is set up to overwrite them with the answers.
    public static string DeathStarCombat(Dictionary<string, int> jediPowers)
    {
        int highest = 0;
        string strongest = "";

        foreach (KeyValuePair<string, int> kvp in jediPowers)
        {
            if (kvp.Value > highest)
            {
                highest = kvp.Value;
                strongest = kvp.Key;
            }
        }

        return strongest;

    }

    //If you need to reverse order something, you can use the .Reverse() method
    //The other way is to do this with loops
    public static List<string> ConvertPlanets(string[] planets)
    {
        List<string> list = planets.Reverse().ToList();
        return list;
    }

    //Iterates through each droid and adds their amount to the total.
    //Then, you just return the total/the number of droids.
    //I also rounded this with Math.Round.
    //The two at the end of line 62 is the amount of places you want it to round to.
    public static double AverageDroids(List<int> droids)
    {
        int total = 0;

        foreach (int droid in droids)
        {
            total += droid;
        }

        double average = Math.Round((double)total / droids.Count, 2);

        return average;
    }

    //Uses a try catch to try and change the string into a whole number
    //Basically, if it CAN convert the input to a number, the try statement will be returned.
    //If not, it'll return the catch statement.
    public static string TryToCatchDarthVader(string attempt)
    {
        try
        {
            int num1 = int.Parse(attempt);
            return "Vader was captured!";
        }
        catch
        {
            return "Vader got away!";
        }
    }
}