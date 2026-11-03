using UnityEngine;

public class EnemyBase : DamageBase, IDamagable
{
    public float TargetHealth;
    public Transform Player;
    Rigidbody2D rigidbody;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (TargetHealth <= 0)
        {
            Destroy(gameObject);
        }


    }
    private void FixedUpdate()
    {
        rigidbody.linearVelocity = (Player.position - transform.position).normalized;



    }

    public void DealDamage(float damage)
    {
        TargetHealth -= damage;
        Debug.Log(TargetHealth);
    }

}
