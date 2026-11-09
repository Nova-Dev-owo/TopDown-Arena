using System.Linq;
using Unity.Collections;
using UnityEngine;

public class DamageBase : MonoBehaviour
{
    public float Damage;

    public string damagableTag;

    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        IDamagable Target;
        Target = other.gameObject.GetComponent<IDamagable>();

        if (Target == null) return;

        if (damagableTag == other.tag) return;

        Target.DealDamage(Damage);      
    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        IDamagable Target;
        Target = other.gameObject.GetComponent<IDamagable>();

        if (Target == null) return;
        if (damagableTag == other.transform.tag) return;

        Target.DealDamage(Damage);
    }
}
