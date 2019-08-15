using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorCamaras : MonoBehaviour
{
    public GameObject[] Camaracontrol;
    public string etiqueta;
    public int[] indice; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag==etiqueta)
        {

            Camaracontrol[indice[0]].SetActive(false);
            Camaracontrol[indice[1]].SetActive(false);
            Camaracontrol[indice[2]].SetActive(true);
            //this.gameObject.SetActive(false);
           
            Debug.Log("Estas adentro");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            GetComponent<Collider>().isTrigger = false;
            Debug.Log("Estas fuera");
        }
    }
}
