using UnityEngine;

public class BoxSpawn : MonoBehaviour
{
    public GameObject Box;
    private float time = 2f;

    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0f)
        {
           
            Vector3 spawnPos = transform.position + Vector3.up * 1f;
            spawnPos.z = 0f; // force it onto camera plane
            GameObject projectile = Instantiate(Box, spawnPos, Quaternion.identity);

            projectile.GetComponent<SpriteRenderer>().sortingOrder = 10; // make sure it's in front

            Debug.Log("Spawned box at: " + projectile.transform.position);

            time = 2f; // reset timer
           

        }
    }
}
