namespace ParallelsCoding.Lab1;
//Medium
//Нахождение кратчайшего пути в треугольнике.
public class Triangle
{
    public int MinimumTotal(IList<IList<int>> triangle) {
        for (int i = triangle.Count - 2; i >= 0; i--)
        {
            for (int j = 0; j < triangle[i].Count; j++)
            {
                triangle[i][j] += Math.Min(triangle[i + 1][j], triangle[i + 1][j + 1]);
            }
        }

        return triangle[0][0];
    }
}