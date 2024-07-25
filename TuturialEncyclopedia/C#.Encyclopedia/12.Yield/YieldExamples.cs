namespace Encyclopedia.YieldExamples

{
    internal class YieldExamples
    {
        public static IEnumerable<string> YieldBaseExamples()
        {
            yield return "monday";
            yield return "tuesday";
            yield return "wednesday";
            yield return "thursday";
            yield return "friday";
            yield return "saturday";
            yield return "sunday";
        }

        public static IEnumerable<int> YieldForExamples()
        {
            for (int i = 0; i <= 9; i++)
            {
                yield return i;
            }
        }

        public static IEnumerable<int> YieldForExample()
        {
            for (int i = 1; i <= 9; i++)
            {
                yield return i;
                {
                    if (i % 5 == 0)
                    {
                        yield break;
                    }
                }
            }
        }
    }
}