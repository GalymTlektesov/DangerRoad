using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public GameObject Destroyer;
    public int Health;
    private SpriteRenderer image;

    
    private void OnTriggerExit(Collider other) 
    {
        DamageHealth("Ball", other);
    }


    private void DamageHealth(string tag, Collider other)
    {
        if (other.CompareTag(tag))
        {
            var ball = other.GetComponent<BallController>();
            ball.IsTeleport = false;
            var damage = other.GetComponent<DamgeScript>();
            Health -= damage.TakeDamage();
            Death();
        }
    }

    private void Death()
    {
        if (Health < 1)
        {
            Instantiate(Destroyer, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
