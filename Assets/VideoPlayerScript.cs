using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlayerScript : MonoBehaviour {

    public MovieTexture movie;

	// Use this for initialization
	void Start () {

        GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
        movie.loop = true;
        movie.Play();
	}
}
