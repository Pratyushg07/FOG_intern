using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliders : MonoBehaviour
{
    public GameObject[] lines;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        int i=0;
        for(i=0; i<lines.Length; i++){            
            BoxCollider box = lines[i].GetComponent<BoxCollider>();
            Destroy(box);
            lines[i].AddComponent<BoxCollider>();
        }
    }
}