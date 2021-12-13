using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private float Speed;

    private Vector3 _direction;

    void Start()
    {
        
    }

    void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        transform.position = transform.position + _direction * Time.fixedDeltaTime * Speed;
    }
}
