namespace Day8.Solution;

internal class Part2
{
    internal static int ScenicScore(string[] lines)
    {
        var scenicScores = new List<int>();
        for (int i = 0; i < lines.Length; i++)
        {
            var trees = lines[i].ToCharArray();

            for (int j = 0; j < trees.Length; j++)
            {
                var currentTree = trees[j];

                //left
                var leftTrees = lines[i].Substring(0, j).Reverse().ToArray();
                var hasLeftView = true;
                var leftCount = 0;
                for (int k = 0; k < leftTrees.Count(); k++)
                {
                    var comparingTree = leftTrees[k];
                    if (hasLeftView)
                    {
                        leftCount++;
                    }

                    if (comparingTree >= currentTree)
                    {
                        hasLeftView = false;
                    }
                }
                leftCount = leftCount == 0 ? 1 : leftCount;

                //right
                var rightTrees = lines[i].Substring(j + 1).ToCharArray();
                var hasRightView = true;
                var rightCount = 0;
                for (int k = 0; k < rightTrees.Count(); k++)
                {
                    var comparingTree = rightTrees[k];
                    if (hasRightView)
                    {
                        rightCount++;
                    }

                    if (comparingTree >= currentTree)
                    {
                        hasRightView = false;
                    }

                }
                rightCount = rightCount == 0 ? 1 : rightCount;

                //top
                var hasTopView = true;
                var topCount = 0;
                for (int k = i; k > 0; k--)
                {
                    var comparingTree = lines[k - 1][j];
                    if (hasTopView)
                    {
                        topCount++;
                    }
                    
                    if(comparingTree >= currentTree)
                    {
                        hasTopView = false;
                    }
                }
                topCount = topCount == 0 ? 1 : topCount;

                //bottom
                var hasBottomView = true;
                var bottomCount = 0;
                for (int k = i + 1; k < lines.Length; k++)
                {
                    var comparingTree = lines[k][j];
                    if (hasBottomView)
                    {
                        bottomCount++;
                    }

                    if (comparingTree >= currentTree)
                    {
                        hasBottomView = false;
                    }
                }
                bottomCount = bottomCount == 0 ? 1 : bottomCount;
                var scenicScore = bottomCount * topCount * leftCount * rightCount;

                scenicScores.Add(scenicScore);
            }

        }

        return scenicScores.Max();
    }
}
