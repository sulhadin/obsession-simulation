using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
[RequireComponent(typeof(AudioSource))]

public class VideoController : MonoBehaviour
{

    public MovieTexture movie;
    private AudioSource audio;
    // Use this for initialization
    void Start()
    {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        audio = GetComponent<AudioSource>();
        audio.clip = movie.audioClip;
        movie.Play();
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
