//MUSI BYC STATYCZNA DLA METOD ROZSZERZAJĄCYCH
using NewTututialEncyklopedia.Classes;
// Extension Classess must be static must expnd sttic class and use this keyword
public static class PlayerExtension
{
    public static int ToBetterPlayer(this PlayerToExpand rogal, int levelUp)
    {
        return rogal.Level + levelUp;
    }
}
