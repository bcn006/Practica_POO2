using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamaras : MonoBehaviour
{
    public GameObject[] Camaracontrol; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Camaracontrol[0].SetActive(false);
            Camaracontrol[1].SetActive(true);
            Camaracontrol[2].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Camaracontrol[0].SetActive(true);
            Camaracontrol[1].SetActive(false);
            Camaracontrol[2].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Camaracontrol[0].SetActive(false);
            Camaracontrol[1].SetActive(false);
            Camaracontrol[2].SetActive(true);
        }
    }
}
