using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class PortfolioItem : MonoBehaviour {


    [SerializeField]
    Image setImange;
    [SerializeField]
    Text Description;
    [SerializeField]
    Text Name;
    [SerializeField]
    Text Url;


    Image image;
    string description;
    string setname;
    string url;

    public void InsertItem(Image im, string des, string na, string url)
    {
        image = im;
        description = des;
        name = na;
    }

    public void DisplayItem()
    {
        setImange = image;
        Description.text = description;
        Name.text = name;
        Url.text = url;
    }

    public void OpenUrl()
    {
        Application.OpenURL(url);
    }

}
