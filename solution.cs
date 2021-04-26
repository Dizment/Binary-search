using System;

namespace BinarySearch
{
    public static class Search
    {
        public static int? BinarySearch(int[] source, int value)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            int indexNow;
            int indexSmall = 0;
            int indexBig = source.Length - 1;

            while (indexSmall <= indexBig)
            {
                indexNow = ((indexBig - indexSmall) / 2) + indexSmall;

                if (value == source[indexNow])
                {
                    return indexNow;
                }
                else if (source[indexNow] > value)
                {
                    indexBig = indexNow - 1;
                }
                else
                {
                    indexSmall = indexNow + 1;
                }
            }

            return null;
        }
    }
}
