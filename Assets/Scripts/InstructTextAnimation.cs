using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructTextAnimation : MonoBehaviour
{
    Animator anim;
    public GameObject player;
    PlayerMovement pMove;
    Image image;
    bool hasMoved;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.enabled = false;
        anim = GetComponent<Animator>();
        pMove = player.GetComponent<PlayerMovement>();
        hasMoved = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(pMove.controlsEnabled && !hasMoved)
        {
            image.enabled = true;
            anim.enabled = true;
            hasMoved = true;
            anim.SetTrigger("FadeIn");
        }
        if(Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical"))
        {
            anim.SetTrigger("FadeOut");
        }
    }
    void GoAway()
    {
        image.enabled = false;
        anim.enabled = false;
    }
}
