using System;
using Component;
using UnityEngine;

[RequireComponent(typeof(Healthy))]
[RequireComponent(typeof(EnemyVisual))]
public class WoodenBox : MonoBehaviour, IDamageable
{
    Healthy _healthy;
    private EnemyVisual _visual;
    

    private void Awake()
    {
        _healthy = GetComponent<Healthy>();
        _visual = GetComponent<EnemyVisual>();
    }

    public bool TakeDamage(int damage)
    {
        return _healthy.TakeDamage(damage);
    }
}
