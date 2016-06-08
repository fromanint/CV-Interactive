using UnityEngine;
using System.Collections;
using UnityEngine.UI;


[RequireComponent(typeof(AudioSource))]
public class SetMovieText : MonoBehaviour {

    public string url = "http://www.unity3d.com/webplayers/Movie/sample.ogg";
    int index = 0;

    void Start()
    {
        StartCoroutine("SetVideo");
    }


    IEnumerator SetVideo()
    {

        WWW www = new WWW(url);

      MovieTexture movieTexture = www.movie;
        while (!movieTexture.isReadyToPlay)
        {
            yield return null;
        }
        Debug.Log("Ready");
        RawImage gt = GetComponent<RawImage>();
        gt.texture = movieTexture;
        AudioSource aud = GetComponent<AudioSource>();
        aud.clip = movieTexture.audioClip;
        movieTexture.Play();
        aud.Play();


    }


}
