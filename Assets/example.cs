using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        for (var i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(i * 2.0f, 2, 0), Quaternion.identity);
        }
    }
}
