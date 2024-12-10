using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encyclopedia.OOP.FourFilarsExamples;

internal class LiscovPrincipleExamples
{
}

public interface Shop
{
    public void Sell();

    public void Buy();

    public string Description(string description);
}

public interface ShopOnline : Shop
{
    public void AddToCart();
}

public interface ShopLocal: Shop
{
    public void TakeBag();
}