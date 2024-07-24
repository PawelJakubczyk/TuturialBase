using System;
using System.Drawing;
namespace NewTututialEncyklopedia.Classes;


public class EnumPolymorphAlien
{
    public string AlienForm { get; private set; }

    private enum FormEnum
    {
        Egg,
        Facehugger,
        Chestburster,
        Drone,
        Warrior,
        Queen
    }

    private FormEnum currentForm;

    public EnumPolymorphAlien()
    {
        currentForm = FormEnum.Egg;
        AlienForm = currentForm.ToString();
    }

    public void Grow()
    {
        if (currentForm < FormEnum.Queen)
        {
            currentForm++;
            AlienForm = currentForm.ToString();
        }
    }

    public void Grow(int growingSpeed)
    {
        if (currentForm < FormEnum.Queen)
        {
            FormEnum formEnum = currentForm + growingSpeed;
            AlienForm = currentForm.ToString();
        }
    }
}