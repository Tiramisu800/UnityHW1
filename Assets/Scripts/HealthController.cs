using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private float _health = 100;
    [SerializeField] private float damage = 10;
    [SerializeField] public float _fillSpeed;

    private float _healthPercents;
    [SerializeField] GameObject _gameObject;

    void Start()
    {
        _healthPercents = _health / 100;
    }

    public void TakeDamage() 
    {
        if (_health > 0)
        {
            _health -= damage;
        }
        else
        {
            _health = 0;

            _gameObject.SetActive(false);
        }

        _healthPercents = _health / 100;
    }
    void Update()
    {
        _healthBar.value = Mathf.Lerp(_healthBar.value, _healthPercents, Time.deltaTime * _fillSpeed);
    }
}
