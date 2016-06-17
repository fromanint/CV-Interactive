using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class PortafolioManager : MonoBehaviour {


    [SerializeField] GameObject DisplayInfo;
    [SerializeField] Sprite[] sprites;

    PortfolioItem[] Items;

    int index = 0;
        // Use this for initialization
    void Start () {
        index = 0;
        setData();
        Display();
	}

    // Update is called once per frame
    void setData()
    {
        int i = 0;
        Items = new PortfolioItem[sprites.Length];
        Items[i] = new PortfolioItem(sprites[i], "Virtual Reality Game developed for de Global Archiact Jam","Rescue and escape", "https://goo.gl/pm9qP8");
        Items[++i] = new PortfolioItem(sprites[i], "Agumented Reality in Android and IOS for Nostrum Restaurants", "Nostrum Experience", "https://goo.gl/l5lhcv");
        Items[++i] = new PortfolioItem(sprites[i], "Short Film for Jameson Notodo Film Fest", "Esperame en Abril", "http://goo.gl/FpS1QF");
        Items[++i] = new PortfolioItem(sprites[i], "Trasmedia that includes: AR, Web and Serious Game for AliaVox and CIMA Foundation", "Mi compás", "http://goo.gl/5Z25yH");
        Items[++i] = new PortfolioItem(sprites[i], "Interactive Device placed in a square of Barcelona to celabrete christmas", "Bon Nadal", "https://goo.gl/P8NuEI");
        Items[++i] = new PortfolioItem(sprites[i], "Game Design of a maze game for smartphones", "Ha-zaman", "https://goo.gl/Bs2xad");




    }

    void Update()
    {
        if (Input.GetKeyDown("right"))
            Next();

        if (Input.GetKeyDown("left"))
            Previous();
    }


    public void Next()
    {
        if ((index + 1) >= Items.Length)
        {
            index = 0;
        }
        else {
            index++;
        }
        Display();
    }
    public void Previous()
    {
        if (index <= 1)
        {
            index = Items.Length - 1;
        }
        else {
            index--;
        }

        Display();
    }

    void Display()
    {
        DisplayInfo.transform.Find("Image").GetComponent<Image>().sprite = Items[index].image;
        DisplayInfo.transform.Find("Name").GetComponent<Text>().text = Items[index].setname;
        DisplayInfo.transform.Find("Description").GetComponent<Text>().text = Items[index].description;
        DisplayInfo.transform.Find("Urlbt").Find("Url").GetComponent<Text>().text = Items[index].url;
    }

    public void ClickUrl()
    {
        Application.OpenURL(Items[index].url);
    }

}
