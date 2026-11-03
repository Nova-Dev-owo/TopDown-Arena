using Unity.VisualScripting;
using UnityEngine;

public class DamageBase : MonoBehaviour
{

    public float Damage;

    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        
        IDamagable Target;
        Target = other.gameObject.GetComponent<IDamagable> ();

        if (Target == null) return;

        Target.DealDamage(Damage);

        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        IDamagable Target;
        Target = other.gameObject.GetComponent<IDamagable>();

        if (Target == null) return;

        Target.DealDamage(Damage);


    }
}
