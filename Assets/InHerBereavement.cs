using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InHerBereavement : MonoBehaviour
{
    public AudioSource clip1;
    Animator anim;
    Image sprite;
    public GameObject npc;
    Jellies jellies;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<Image>();
        anim = GetComponent<Animator>();
        anim.enabled = false;
        sprite.enabled = false;
        jellies = npc.GetComponent<Jellies>();

    }

    // Update is called once per frame
    void Update()
    {
        if (clip1.time >= 89.8f && clip1.time <= 90.1f)
        //if (clip1.time >= 10.8f && clip1.time <= 11.1f)
            {
            anim.enabled = true;
            sprite.enabled = true;
        }
    }

    void EndAnim()
    {
        anim.enabled = false;
        sprite.enabled = false;
    }
    void ChangeColor()
    {
        jellies.changeNow = true;
    }
}
