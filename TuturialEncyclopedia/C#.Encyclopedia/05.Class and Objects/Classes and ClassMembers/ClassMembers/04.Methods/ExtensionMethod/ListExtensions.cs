namespace Encyclopedia.MethodsExamples.Extensions;

public static class ListExtensions
{
    public static List<T> DeepClone<T>(this List<T> list) where T : ICloneable
    {
        if (list == null)
            throw new ArgumentNullException(nameof(list));

        return list.Select(item => (T)item.Clone()).ToList();
    }
    public static List<T> Clone<T>(this List<T> list)
    {
        if (list == null)
            throw new ArgumentNullException(nameof(list));

        return list.Select(item => item).ToList();
    }
}
