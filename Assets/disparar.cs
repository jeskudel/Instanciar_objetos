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
    private float fireRate = 5;
    private float lastfired;

    XRGrabInteractable selfobject;
    ActionBasedController mandoI, mandoD;

    // Start is called before the first frame update
    void Start()
    {
        selfobject = GetComponent<XRGrabInteractable>();
        mandoI = GameObject.Find("LeftHand Controller").GetComponent<ActionBasedController>();
        mandoD = GameObject.Find("RightHand Controller").GetComponent<ActionBasedController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (selfobject.isSelected)
        {
            Debug.Log("Esta agarrado el bojeto " + selfobject.name);
            if ((selfobject.IsSelected(mandoD.GetComponent<XRDirectInteractor>()) && mandoD.activateAction.action.ReadValue<float>() > 0) || (selfobject.IsSelected(mandoI.GetComponent<XRDirectInteractor>()) && mandoI.activateAction.action.ReadValue<float>() > 0))
            {
                if (Time.time - lastfired > 1 / fireRate)
                {
                    lastfired = Time.time;
                    onAutomatico();
                }
            }
            else
            {
                Debug.Log("Arma Seleccionada pero no apretado el gatillo");
            }
        }
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
