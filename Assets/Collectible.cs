using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject player;
    bool fallen;
    bool imActive;
    float point;
    public GameObject music;
    MusicHandling mH;
    void Start()
    {
        imActive = false;
        fallen = false;
        GetComponent<SpriteRenderer>().enabled = false;
        point = Random.Range(-2f, 7.3f);
        Debug.Log("point is " + point);
        mH = music.GetComponent<MusicHandling>();
    }

    void Update()
    {
        if(mH.panningDown)
        {
            imActive = true;
            GetComponent<SpriteRenderer>().enabled = true;
        }
        if (!fallen && imActive)
        {
            transform.Translate(Vector3.down *0.05f, Space.World);
            if(transform.position.y <= point)
            {
                Debug.Log("it happened!");
                fallen = true;
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("snatched");
            Destroy(gameObject);
            
        }
    }
}
