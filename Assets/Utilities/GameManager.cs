using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance { get => _instance;  }

    
    [SerializeField] int maxAmmo = 10;
    [SerializeField] int _currentAmmo;
    public int CurrentAmmo { get => _currentAmmo; set => _currentAmmo = value; }
    private void Start()
    {
        _currentAmmo = maxAmmo;
    }
}
