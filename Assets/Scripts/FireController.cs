using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    //[SerializeField] GameObject ammoObject;
    [Header("Fire Variables")]
    [SerializeField] float fireDelay = 0.5f;
    private float nextFire = 0.01f;
    
    
    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time > nextFire )
        {
            if (GameManager.Instance.CurrentAmmo > 0)
            {
                nextFire = Time.time + fireDelay;
                //GameObject GO = Instantiate(ammoObject, firePoint.position, Quaternion.identity);
                Transform TS = AmmoManager.Instance.FireAmmo(firePoint.position, firePoint.rotation);
                //GameManager.Instance.CurrentAmmo--;
            }
             
        }
    }
}
