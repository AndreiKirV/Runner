using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyItem : MonoBehaviour
{
    [SerializeField] private int _damage;
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.TryGetComponent(out Player player))
        {
            player.AppDamage(_damage);
            Die();
        }
        else
        {
            Die();
        }
    }
    
    private void Die()
    {
        gameObject.SetActive(false);
    }
}
