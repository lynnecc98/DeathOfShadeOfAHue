using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jellies : MonoBehaviour
{
    Transform[] jelly;
    GameObject[] jellyObjs;
    Transform[] ugly;
    float colorAmount = 0f;
    public bool changeNow;
    // Start is called before the first frame update
    void Start()
    {
        changeNow = false;
        jelly = gameObject.GetComponentsInChildren<Transform>();
        jellyObjs = new GameObject[jelly.Length - 1];
        ugly = new Transform[jelly.Length - 1];
        if (jelly[0] == null)
        {
            Debug.Log("fuck");
        } else
        {
            Debug.Log("kid in here");
        }
        for (int i = 1; i < jelly.Length; i++)
        {
            ugly[i - 1] = jelly[i]; 
            
        }
        for(int i = 0; i < jellyObjs.Length;i++)
        {
            jellyObjs[i] = ugly[i].gameObject;
        }
        Debug.Log("jelly object list size " + jellyObjs.Length);
        Debug.Log(jellyObjs[0].tag);
        if(jellyObjs != null)
        {
            Debug.Log("I DON'T UNDERSTAND");
        }
      
    }
    void TurnGray()
    {
        
        if (jellyObjs == null)
        {
            Debug.Log("NOOOOOOOOOOOOOOOOOO");
        }
      
        for (int i = 0; i < jellyObjs.Length; i++)
        {
            jellyObjs[i].GetComponent<SpriteRenderer>().color = Color.Lerp(jellyObjs[i].GetComponent<GiveRandomColor>().fart, jellyObjs[i].GetComponent<GiveRandomColor>().randColor, colorAmount);
            //jellyObjs[i].GetComponent<SpriteRenderer>().color = Color.Lerp(fart, hereWeGo, colorAmount);


            colorAmount += Time.deltaTime / 150;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if (changeNow)
        {
            TurnGray();
        }
    }
}
