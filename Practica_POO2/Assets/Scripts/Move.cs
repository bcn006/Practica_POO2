using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Animator anim; 

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetFloat("Velocidad", 0.5f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetFloat("Velocidad", -0.5f);
        }
        else
        {
            anim.SetFloat("Velocidad", 0.0f);
        }
    }
}
