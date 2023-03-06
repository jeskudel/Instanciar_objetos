using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparar : MonoBehaviour
{
    public GameObject bullet;
    public Transform puntoDisparo;
    public float velocidad = 20;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Fire()
    {
        GameObject bala = Instantiate(bullet);
        bala.transform.position = puntoDisparo.position;
        bala.GetComponent<Rigidbody>().velocity = puntoDisparo.forward * velocidad;
        Destroy(bala, 5);
    }
}
