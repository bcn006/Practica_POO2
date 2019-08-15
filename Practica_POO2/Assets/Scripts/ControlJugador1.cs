using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador1 : BaseMove
{
    public float fuerzaSalto;
   
    // Start is called before the first frame update
    void Start()
    {
        AccesoComponentes();
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            anim.SetBool ("ShootB", true);
        }
        else
        {
            anim.SetBool("ShootB", false);  
        }
    }

    void FixedUpdate()
    {
        if (isGrounded() == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            }
        }
        Aceleracion(velocidad);
    }

}