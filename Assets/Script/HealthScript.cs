using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public float Health;

    private void OnCollisionEnter(Collision other) 
    {
        DamageHealth("Ball", other.collider);
    }


    private void OnCollisionExit(Collision other) 
    {
        DamageHealth("Ball", other.collider);
    }


    private void DamageHealth(string tag, Collider other)
    {
        if (other.CompareTag(tag))
        {
            var damage = other.GetComponent<DamgeScript>();
            Health -= damage.TakeDamage();
            Death();
        }
    }

    private void Death()
    {
        if (Health < 1)
        {
            Destroy(gameObject);
        }
    }
}
