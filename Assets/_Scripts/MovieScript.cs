using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class MovieScript: MonoBehaviour
{
    public MovieTexture movTexture;
    //public AudioSource audio2;
    void Start()
    {
        GetComponent<Renderer>().material.mainTexture = movTexture;
        AudioSource aud = GetComponent<AudioSource>();
        aud.clip = movTexture.audioClip;
        aud.Play();
        movTexture.Play();
        //audio2.Play();
    }
}