using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    float enemySpawnTimer = 5.0f;
    float enemySpawnCooldown = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        enemySpawnCooldown += Time.deltaTime;
        if (enemySpawnCooldown >= enemySpawnTimer)
        {
            enemySpawnCooldown = 0.0f;
            // Spawn enemy logic here
            //salvando git
            float posx = Random.Range(-20.0f, 20.0f);
            float posZ = Random.Range(-20.0f, 20.0f);
            Vector3 pos = new Vector3(posx, 1f, posZ);
            Instantiate(enemyPrefab, pos, Quaternion.Euler(0f, 0f, 0f));


        }
    }
}
