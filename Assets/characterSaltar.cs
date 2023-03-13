using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]

public class characterSaltar : MonoBehaviour
{
    [SerializeField] private InputActionReference jumpReference;
    [SerializeField] private float jumpForce = 500f;
    private CharacterController _personaje;
    private float _gravedad=9.81f;
    private float _velocidad;
    private Vector3 _direccion;

    private 

    // Start is called before the first frame update
    void Start()
    {
        _personaje = GetComponent<CharacterController>();
        jumpReference.action.performed += OnJump;
        
    }

    private void ApplyGravity()
    {
        if (_personaje.isGrounded && _velocidad < 0.0f)
        {
            _velocidad = -1.0f;
        }
        else
        {
            _velocidad += _gravedad *  Time.deltaTime;
        }

        _direccion.y = _velocidad;
    }
    private void OnJump(InputAction.CallbackContext obj)
    {
        //_velocidad += _gravedad * Time.deltaTime;
        Debug.Log("asdfasdfasdfsdf");
    }

    // Update is called once per frame
    void Update()
    {
        ApplyGravity();
    }
}
