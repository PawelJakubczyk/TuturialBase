﻿namespace Encyclopedia.LinqExamples
{
    internal class LinqColectionOperations
    {
        private IEnumerable<int> intColection = [1, 2, 3, 4, 5, 6];
        private IEnumerable<char> charColection = ['a', 'b', 'c', 'd', 'e'];
        private IEnumerable<object> mixColection = [1, "b", 3, "d", 5];
        private IEnumerable<List<int>> colectionList = [[1, 2, 3, 4], [4, 3, 2, 1]];
        private IEnumerable<object> objectIntColection = [1, 2, 3, 4, 5];

        public IEnumerable<int> SelectAddColections()
        {
            return colectionList.SelectMany(x => x);
        }

        //public IEnumerable<int> SelectColectionSquaredByColection()
        //{
        //    return colectionList.SelectMany((x, y) => x^y);
        //}
        public IEnumerable<string> SelectCastToString()
        {
            return intColection.Select(x => x.ToString());
        }

        public IEnumerable<int> SelectCastObjectToInt()
        {
            return objectIntColection.Cast<int>();
        }

        public IEnumerable<int> AppendElementToColection()
        {
            return intColection.Append(7);
        }

        public IEnumerable<int> PrependElementToColection()
        {
            return intColection.Prepend(0);
        }
    }
}