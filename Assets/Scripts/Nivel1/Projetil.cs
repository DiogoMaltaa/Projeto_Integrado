using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    [SerializeField] [Range(5000f, 25000f)]
    float _launchForce = 10000f;
    [SerializeField] [Range(10, 1000)] int _damage = 100;
    [SerializeField] [Range(2f, 10f)] float _range = 5f;

    [SerializeField]float tempoParaDestruir = 10f;

    private EnemyVida inimigo;

    bool OutOfFuel
    {
        get
        {
            _duration -= Time.deltaTime;
            return _duration <= 0f;
        }
    }

    Rigidbody _rigidBody;
    float _duration;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    void OnEnable()
    {
        _rigidBody.AddForce(_launchForce * transform.forward);
        _duration = _range;
    }

    private void Start()
    {
        inimigo = FindObjectOfType<EnemyVida>();
    }

    void Update()
    {
        if (OutOfFuel) Destroy(gameObject);

        tempoParaDestruir -= Time.deltaTime;

        if(tempoParaDestruir <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Inimigo")
        {
            inimigo.TomarDano(_damage);
        }
    }
}

