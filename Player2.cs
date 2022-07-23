using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField] float hiz;
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, hiz * Time.deltaTime, 0f);
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, -hiz * Time.deltaTime, 0f);
        }
        
    }
}
