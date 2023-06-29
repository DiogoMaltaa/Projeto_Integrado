using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blaster : MonoBehaviour
{
    [SerializeField] Projetil _projectilePrefab;

    [SerializeField] Transform _BlasterS;
    [SerializeField] [Range(0f, 5f)] float _coolDownTime = 0.25f;

    bool CanFire
    {
        get
        {
            _coolDown -= Time.deltaTime;
            return _coolDown <= 0f;
        }
    }

    float _coolDown;

    // Update is called once per frame
    void Update()
    {
        if (CanFire && Input.GetMouseButton(0) || CanFire && Input.GetKey(KeyCode.Space))
        {
            FireProjectile();
        }
    }

    void FireProjectile()
    {
        _coolDown = _coolDownTime;
        Instantiate(_projectilePrefab, _BlasterS.position, transform.rotation);
    }
}