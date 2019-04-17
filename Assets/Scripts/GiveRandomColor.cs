using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveRandomColor : MonoBehaviour
{




    public Color randColor;
    float magicNum;
    public Color fart;
    // Start is called before the first frame update
    void Start()
    {
        //initial color
        gameObject.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 0.4f, 0.7f, 1f, 1f);
        fart = gameObject.GetComponent<SpriteRenderer>().color;
        magicNum = fart.r;
        if(magicNum <= 0.4f && magicNum>= 0f)
        {
            magicNum += 0.6f;
        } else if (magicNum >= 0.9f && magicNum<= 1f)
        {
            magicNum -= 0.1f; 
        } else if(magicNum <= 0f)
        {
            magicNum = 0.4f; 
        } else if (magicNum >= 1f)
        {
            magicNum = 1;
        }
        Debug.Log("THIS IS THE MMAGIC NUM: " + magicNum);
        randColor = new Color(magicNum,magicNum,magicNum);


}

   
}
