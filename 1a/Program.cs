//
try
{
    using (var sr = new StreamReader("input.txt"))
    {
        string line;
        int sum = 0;
        while ((line = sr.ReadLine()) != null)
        {
            string pair = "";

            //find first number in line
            foreach (var c in line)
            {
                if (Char.IsNumber(c))
                {
                    pair += c.ToString();
                    break;
                }
            }
            //find last number in line
            for (int i = line.Length - 1; i >= 0; i--)
            {
                if (Char.IsNumber(line[i]))
                {
                    pair += line[i].ToString();
                    break;
                }
            }
            //add pair to sum as a number
            sum += int.Parse(pair);            
        }

        //write sum to console
        Console.WriteLine(sum);
    }
}
catch (Exception e)
{
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(e.Message);
}
