using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    [SerializeField] float hiz;

    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, hiz * Time.deltaTime, 0f);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, -hiz * Time.deltaTime, 0f);
        }
    }
}
