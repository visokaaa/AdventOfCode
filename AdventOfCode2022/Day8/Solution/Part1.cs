namespace Day8.Solution;
internal class Part1
{
    public static int NumberOfVisibleTrees(string[] lines)
    {
        var firstLine = lines[0];

        var rowLength = firstLine.Length;
        var colLength = lines.Length;

        var edgesCount = (2 * rowLength) + (2 * (colLength - 2));
        var visibleTrees = edgesCount;

        for (int i = 1; i < lines.Length - 1; i++)
        {
            var currentRow = lines[i].ToCharArray();

            for (int j = 1; j < currentRow.Length; j++)
            {
                var currentTree = currentRow[j];

                //left direction
                var visibleFromLeft = false;
                var leftDirection = new List<char>();

                for (int k = 1; k < j; k++)
                {
                    leftDirection.Add(currentRow[j - k]);
                }

                var maxTreeFromLeft = leftDirection.DefaultIfEmpty().Max();
                if (maxTreeFromLeft != 0 && maxTreeFromLeft < currentTree)
                {
                    visibleFromLeft = true;
                }


                //right direction
                var rightDirection = new List<char>();
                var visibleFromRight = false;

                for (int k = 1; k < lines[i].Length - j - 1; k++)
                {
                    rightDirection.Add(currentRow[j + k]);
                }

                var maxTreeFromRight = rightDirection.DefaultIfEmpty().Max();
                if (maxTreeFromRight != 0 && maxTreeFromRight < currentTree)
                {
                    visibleFromRight = true;
                }


                //top direction
                var topDirection = new List<char>();
                var visibleFromTop = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    topDirection.Add(lines[k][j]);
                }

                var maxTreeFromTop = topDirection.DefaultIfEmpty().Max();
                if (maxTreeFromTop != 0 && maxTreeFromTop < currentTree)
                {
                    visibleFromTop = true;
                }

                //bottom direction
                var bottomDirection = new List<char>();
                var visibleFromBottom = false;
                for (int k = i + 1; k < lines.Length; k++)
                {
                    bottomDirection.Add(lines[k][j]);
                }


                var maxTreeFromBottom = bottomDirection.DefaultIfEmpty().Max();

                if (maxTreeFromBottom != 0 && maxTreeFromBottom < currentTree)
                {
                    visibleFromBottom = true;
                }

                if (visibleFromTop || visibleFromBottom || visibleFromLeft || visibleFromRight)
                {
                    visibleTrees++;
                }



            }
        }

        return visibleTrees;
    }
}
