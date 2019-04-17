using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainyCollectible : MonoBehaviour
{
    public GameObject player;
    bool fallen;
    float point;
    // Start is called before the first frame update
    void Start()
    {
        fallen = false;
        point = Random.Range(-2f, 7.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!fallen)
        {
            transform.Translate(Vector3.down * 0.05f, Space.World);
            if (transform.position.y <= point)
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
