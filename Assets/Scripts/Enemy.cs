using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float hp = 100.0f;
    private float disToPlayer;
    private bool isInPurchased = false;
    private bool isInAttackRange = false;
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        disToPlayer = Vector3.Distance(transform.position, player.position);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        disToPlayer = Vector3.Distance(transform.position, player.position);
        transform.LookAt(player.position);
    }
    public void TakeDamage(float dmg)
    {
        //Debug.Log($"Perdi {dmg} hp");
        hp -= dmg;
        if (hp <= 0.0f)
        {
            //comitizin
            //Debug.Log("Inimigo morreu!");
            Destroy(gameObject);
        }
    }
}
