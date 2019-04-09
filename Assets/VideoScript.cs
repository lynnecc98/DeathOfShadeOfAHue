using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
    public AudioSource clip1;
    VideoPlayer bereave;
    // Start is called before the first frame update
    void Start()
    {
        bereave = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clip1.time >= 89.8f && clip1.time <= 90.1f && !bereave.isPlaying)
        {
            bereave.Play();
        }
    }
}
