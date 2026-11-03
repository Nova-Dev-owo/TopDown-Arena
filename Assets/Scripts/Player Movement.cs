using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IDamagable
{
    
   Rigidbody2D rigidbody;
  public float TargetHealth;
 
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


    void FixedUpdate()
    {
        //movement
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.linearVelocity = new Vector2(-5, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidbody.linearVelocity = new Vector2(5, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rigidbody.linearVelocity = new Vector2(0, -5);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rigidbody.linearVelocity = new Vector2(0, 5);
        }
        else
        {
            rigidbody.linearVelocity = new Vector2(0, 0);
        }
        

        if ((Input.GetKey(KeyCode.A)) && (Input.GetKey(KeyCode.D)))
        {
            rigidbody.linearVelocity = new Vector2(0, 0);
        }
        if ((Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.S)))
        {
            rigidbody.linearVelocity = new Vector2(0, 0);
        }
        
    }

    public void DealDamage(float damage)
    {
        TargetHealth -= damage;
        Debug.Log("Player"+TargetHealth);
    }



}
