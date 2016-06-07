using UnityEngine;
using System.Collections;
using UnityEngine.UI;


[RequireComponent(typeof(Animator))]
public class ChangeWork : MonoBehaviour {

    [SerializeField] GameObject Next;
    [SerializeField] GameObject Actual;

    JobDes[] Jobs;

    int index=0;
    int maxCount = 10;
    // Use this for initialization

    void Start()
    {
        getData();
        setArray();
        setData();
		UpdateInfo (Actual, index);
		UpdateInfo (Next, index+1);
    }
    void setArray()
    {
        JobDes[] joblist = new JobDes[maxCount];
        Jobs = joblist;



    }
    void setData()
    {
        int i = 0;
        Jobs[i] = new JobDes(
            "May 2015 - Present",
            "Game Designer / Developer",
            "Froman Interactive" + " www.fromaninteractive.com",
            "Multimedia / Self Employed",
            "Create prototypes, designs and development of multimedia projects from the idea to the launch, using as main tool Unity 3D.",
            "•	Nostrum Expirence is a Augmenter Realty app developed  for Nostrum(Barcelona, Spain)  in 3 months.\n" +
            "•	Rescue and Escape is a Virtual Reality game for Global Game Architect(DevPost, Worldwide) in 3 weeks.",
            "WorldWide"
            );

        Jobs[++i] = new JobDes(
            "February 2014 - August 2014",
            "Game Designer / Developer",
            "Holoplab",
            "Multimedia / Final Poject",
            "Add to a transmedia World used in CIMA Foundation and Aliavox Books some multimedia objects.",
            "•	Creation of a Website for the project (www.micompas.cat)\n" +
            "•	Creation of Augmented Reality to promote the concerts\n" +
            "•	Development of a serious Game to engage young people into ancient music",
            "Barcelona, Spain"
            );
   
        Jobs[++i] = new JobDes(
              "May 2012 – February 2013",
              "Software Tester",
              "ILIKEA",
              "Software Development for Banks",
              "Test the system and report bugs to the developers",
              "•	Orginize the team and found more than 1000 bugs\n" +
              "•	Verify the 1000 bugs reported plus 3000 reported before\n",
              "Mexico City, Mexico"
              );
     
        Jobs[++i] = new JobDes(
              "June 2011 – March 2012",
              "Software Designer / Developer",
              "Grupo Bryfel S.A. de C.V.",
              "Textile Industry",
              "Design and develop software to automatize some process",
              "•	Develop of a software that save 1 day of work in logistics area",
              "Mexico City, Mexico"
              );
     
    }

    //change it for an XML
    void getData()
    {
        maxCount = 0;
        JobDes job = new JobDes("May 2015 - Present");
        maxCount++;
        job = new JobDes("February 2014 - August 2014");
        maxCount++;
        job = new JobDes("May 2012 – February 2013");
        maxCount++;
        job = new JobDes("June 2011 – March 2012");
        maxCount++;
        
    }

    public void PreviousJob()
    {
		UpdateInfo (Next, index);
		if (index <= 1) {
			index = Jobs.Length - 1;
		} else {
			index--;
		}

		GetComponent<Animator> ().SetTrigger ("Previous");
		UpdateInfo (Actual, index);
	

    }

	public void NextJob()
	{
		GetComponent<Animator> ().SetTrigger ("Next");
		if ((index + 1) >= Jobs.Length) {
			index = 0;
		} else {
			index++;
		}
		StartCoroutine ("WaitForAnimation");

    }

	IEnumerator WaitForAnimation ()
	{
		yield return new WaitForSeconds(1);
		UpdateInfo (Actual, index);
		if (index + 1 >= Jobs.Length) {
			UpdateInfo (Next, 0);
		} else {
			UpdateInfo (Next, index+1);
		}
	}

	void UpdateInfo(GameObject go, int i) {
        go.transform.Find("Date").GetComponent<Text>().text = Jobs[i].Date;
        go.transform.Find("Role").GetComponent<Text>().text = Jobs[i].Role;
        go.transform.Find("Enterprise").GetComponent<Text>().text = Jobs[i].Enterprise;
        go.transform.Find("Category").GetComponent<Text>().text = Jobs[i].Category;
        go.transform.Find("Place").GetComponent<Text>().text = Jobs[i].Place;
		go.transform.Find("Description").GetComponent<Text>().text = Jobs[i].Description;
        go.transform.Find("Achivements").GetComponent<Text>().text = Jobs[i].Achivements;

    }

}
