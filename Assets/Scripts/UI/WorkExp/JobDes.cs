using UnityEngine;
using System.Collections;

public class JobDes {

    public string Date;
    public string Role;
    public string Enterprise;
    public string Category;
    public string Place;
    public string Achivements;

    public string Description;


    public JobDes(string da, string ro, string en, string ca, string des,string ac,string pl) {
        Date = da;
        Role = ro;
        Enterprise = en;
        Category = ca;
        Place = pl;
        Achivements = ac;
        Description = des;
    }

    public JobDes() {
    }

    public JobDes(string da)
    {
    }
   
}
