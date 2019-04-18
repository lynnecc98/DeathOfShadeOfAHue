using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicHandling : MonoBehaviour
{
    //first should play, with the second playing immediately after.
    //the third should happen once the player collects a certain amount,
    //and the fourth should happen once the player collects them all
    public AudioSource first;
    public AudioSource second;
    public AudioSource third;
    public AudioSource fourth;
    public AudioMixerSnapshot secondSnap;

    public GameObject player;

    public bool panningDown;
    

    public Animator camAnim;

    // Start is called before the first frame update
    void Start()
    {
        camAnim.SetTrigger("GoToIdle");
        Debug.Log("1");
        panningDown = false;
        StartCoroutine(PlaySounds());

        
    }
    IEnumerator PlaySounds()
    {
        Debug.Log("called");
        first.Play();
        Debug.Log("should play");
        yield return new WaitForSeconds(first.clip.length);
        secondSnap.TransitionTo(3f);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log(first.time);
        }
       
        if (first.time >= 67f && first.time <= 67.2f)
        {
            camAnim.SetTrigger("PanDown");
            panningDown = true;
        }

    }

}
