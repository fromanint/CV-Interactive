using UnityEngine;
using System.Collections;

public class PortfolioItem  {
 

    public Sprite image;
    public string description;
    public string setname;
    public string url;

    public PortfolioItem(Sprite im, string des, string na, string ur)
    {
        image = im;
        description = des;
        setname = na;
        url = ur;
    }
    public PortfolioItem() { }
}
