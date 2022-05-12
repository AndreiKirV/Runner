using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    public event UnityAction Died;
    public event UnityAction<int> HealthChanged;

    private void Start() 
    {
        HealthChanged?.Invoke(_health);
    }
    public void AppDamage (int damage)
    {
        _health -= damage;
        HealthChanged?.Invoke(_health);

        if(_health <= 0)
        Die();
    }

    public void Die()
    {
        Died?.Invoke();
    }
}