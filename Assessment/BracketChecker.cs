namespace Assessment
{
    public static class BracketChecker
    {
        public static bool IsValidText(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                int openCount = 0;

                foreach (char str in input.Where(c => c == '{' || c == '}').ToList())
                {
                    if (str == '{')
                    {
                        openCount++;
                    }
                    else if (str == '}')
                    {
                        if (openCount == 0)
                        {
                            return false;
                        }
                        openCount--;
                    }
                }

                return openCount == 0;
            }

            return true;
        }
    }
}
