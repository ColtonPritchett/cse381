namespace AlgorithmLib;

public static class BetterLinearSearch
{
    public static int Search(List<IComparable> data, IComparable target)
    {
        for (int i = 0; i < data.Count; i++)
            if (data[i].Equals(target))
                return i;
        
        return -1;
    }
}