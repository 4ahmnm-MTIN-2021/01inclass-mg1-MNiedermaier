using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject spawn;
    float nextSpawn = 1f;
    public float spawnRateGood = 2f;
    Vector2 whereToSpawn;
    float randX;
    float randY;
    float timer;

    // Update is called once per frame
    void Update()
    {
        SpawnFish();
    }

    private void SpawnFish()
    {
        timer = timer + Time.deltaTime;
        // timer += Time.deltaTime

        if (timer > spawnRateGood)
        {
            nextSpawn = Time.deltaTime + spawnRateGood;
            randX = Random.Range(-6f, 6f);
            randY = Random.Range(-5f, 5f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(spawn, whereToSpawn, Quaternion.identity);
            timer = 0f;
        }
    }
}
