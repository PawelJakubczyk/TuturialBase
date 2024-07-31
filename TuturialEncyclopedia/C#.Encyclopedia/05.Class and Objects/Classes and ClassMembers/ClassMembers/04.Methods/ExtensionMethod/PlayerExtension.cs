namespace Encyclopedia.MethodsExamples.Extensions;

public static class PlayerExtension
{
    public static int ToBetterPlayer(this PlayerToExpand rogal, int levelUp)
    {
        return rogal.Level + levelUp;
    }
}