using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoController : MonoBehaviour
{
    [SerializeField] float lifeTime = 2f;
    private Rigidbody rigidbody;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        rigidbody.AddForce(transform.TransformDirection(transform.forward) * 5000f);
        Destroy(this.gameObject, lifeTime);
    }
}
