using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMove : MonoBehaviour
{
    public float velocidad;
    public float velRot;
    protected Rigidbody rb;
    protected Animator anim;
    protected float hor;
    protected float vert;
    protected float mouseHor;

    protected void AccesoComponentes()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    protected void Aceleracion(float v)
    {
        hor = Input.GetAxis("Horizontal")*v*Time.deltaTime;
        vert = Input.GetAxis("Vertical") * v * Time.deltaTime;

        rb.velocity = new Vector3(hor, rb.velocity.y, vert);

        anim.SetFloat("Velocidad", vert);
        anim.SetFloat("veloLate", hor);
    }

    protected void Rotacion(float r)
    {
        mouseHor = Input.GetAxis("Mouse x") * r * Time.deltaTime;
        rb.AddRelativeTorque(transform.up * mouseHor);
    }

    public LayerMask mask;
    protected bool isGrounded()
    {
        Vector3 rayOrigin = GetComponent<Collider>().bounds.center;
        float rayDistance = GetComponent<Collider>().bounds.extents.y + 0.01f;
        Ray ray = new Ray();
        ray.origin = rayOrigin;
        ray.direction = Vector3.down;
        Debug.DrawRay(ray.origin, ray.direction, Color.red);

        if (Physics.Raycast(ray.origin, ray.direction, rayDistance, mask))
        {
            Debug.Log("Esta chocando");
            return true;
        }
        else
            return false;
    }


}
