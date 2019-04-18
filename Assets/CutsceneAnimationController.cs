using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneAnimationController : MonoBehaviour
{
    Animator anim;
    public GameObject player;
    public PlayerMovement pMove;
    public GameObject timer;
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        pMove = player.GetComponent<PlayerMovement>();

    }

    void EnablePlayerControls()
    {
        timer.SetActive(true);
        spawner.SetActive(true);
        pMove.controlsEnabled = true;
        anim.SetTrigger("StayOnPlayer");
    }
}
