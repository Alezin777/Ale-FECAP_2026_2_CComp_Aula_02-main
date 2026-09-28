using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float hp = 100.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float dmg)
    {
        //Debug.Log($"Perdi {dmg} hp");
        hp -= dmg;
        if (hp <= 0.0f)
        {
            //Debug.Log("Inimigo morreu!");
            Destroy(gameObject);
        }
    }
}
