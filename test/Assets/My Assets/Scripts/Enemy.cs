
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 50f;
    public Collider mainCollider;
    public Collider[] allColliders;

    public void Awake()
    {
        mainCollider = GetComponent<Collider>();
        allColliders = GetComponentInChildren<Collider[]>(true);
        Die(false);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if(health <= 0f)
        {
            Die(true);
            PlayerManager.instance.calculator.AddPoint();
            gameObject.SetActive(false);
        }
    }

    void Die(bool isDead)
    {
        foreach (var col in allColliders)
            col.enabled = isDead;
        mainCollider.enabled = !isDead;
        GetComponent<Rigidbody>().useGravity = !isDead;
        GetComponent<Animator>().enabled = !isDead;
    }
}
