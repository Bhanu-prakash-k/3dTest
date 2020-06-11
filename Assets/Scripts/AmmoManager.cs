using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoManager : MonoBehaviour
{
    public static AmmoManager Instance;

    public Queue<Transform> ammoQueue = new Queue<Transform>();
    
    public Transform ammoPrefab;
    public Transform[] ammoArray;

    [SerializeField] int poolSize = 5;
    private void Awake()
    {
        if (Instance != null)
            DestroyImmediate(this.gameObject);
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void Start()
    {
        ammoArray = new Transform[poolSize];

        for(int i=0; i < poolSize; i++)
        {
            Transform TS = Instantiate(ammoPrefab);
            ammoArray[i] = TS;
            TS.transform.parent = this.transform;
            TS.gameObject.SetActive(false);
            ammoQueue.Enqueue(TS);
        }
    }
    public Transform FireAmmo(Vector3 position,Quaternion rotation)
    {
        Transform TS = AmmoManager.Instance.ammoQueue.Dequeue();

        TS.position = position;
        TS.rotation = rotation;
        TS.gameObject.SetActive(true);
        //ammoQueue.Enqueue(ammo);
        return TS;
    }
}
