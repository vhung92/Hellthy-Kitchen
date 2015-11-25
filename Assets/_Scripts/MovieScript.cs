using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class MovieScript: MonoBehaviour
{
	public MovieTexture[] movTexture = new MovieTexture[0];
	public MovieTexture noise;
    private MovieTexture Currentmov;
	private bool noiseOn;

    void Start()
    {
		int rand = Random.Range (0,movTexture.Length);
		Currentmov = movTexture[rand];
        GetComponent<Renderer>().material.mainTexture = movTexture[rand];
        AudioSource aud = GetComponent<AudioSource>();
        aud.clip = movTexture[rand].audioClip;
        aud.Play();
        movTexture[rand].Play();
		noiseOn = false;
    }
	void Update(){

		if (!Currentmov.isPlaying) {
			Currentmov.Stop();
			if(noiseOn)
				selecter ();
			else
				StartNoise ();
		}
	}

	void selecter(){
		int rand = Random.Range (0,movTexture.Length);
		Currentmov = movTexture[rand];
		GetComponent<Renderer>().material.mainTexture = movTexture[rand];
		AudioSource aud = GetComponent<AudioSource>();
		aud.clip = movTexture[rand].audioClip;
		aud.Play();
		movTexture[rand].Play();
		noiseOn = false;
	}
	void StartNoise(){
		Currentmov = noise;
		GetComponent<Renderer>().material.mainTexture = noise;
		AudioSource aud = GetComponent<AudioSource>();
		aud.clip = noise.audioClip;
		aud.Play();
		noise.Play();
		noiseOn = true;
	}

}