using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyIntime : MonoBehaviour
{
    public int DestoyInScous;

    void Start()
    {
        Destroy(gameObject, DestoyInScous);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
