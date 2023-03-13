using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class disparar : MonoBehaviour
{
    public GameObject bullet;
    public Transform puntoDisparo;
    public float velocidad = 20;

    XRGrabInteractable selfobject;

    // Start is called before the first frame update
    void Start()
    {
        selfobject = GetComponent<XRGrabInteractable>();
    }

    // Update is called once per frame
    void Update()
    {
        //selfobject.activated += onAutomatico;
    }

    public void onAutomatico()
    {
        GameObject bala = Instantiate(bullet, puntoDisparo.position, puntoDisparo.rotation);
        bala.GetComponent<Rigidbody>().velocity = puntoDisparo.forward * velocidad;
        Destroy(bala, 5);
    }
    public void Fire()
    {
        GameObject bala = Instantiate(bullet,puntoDisparo.position, puntoDisparo.rotation);
        bala.GetComponent<Rigidbody>().velocity = puntoDisparo.forward * velocidad;
        Destroy(bala, 5);
    }
}
