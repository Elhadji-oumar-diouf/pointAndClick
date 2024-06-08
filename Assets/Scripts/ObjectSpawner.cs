using UnityEngine;



public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // L'objet � g�n�rer
    public Transform spawnPoint; // Point de g�n�ration fixe
    public Vector3 spawnArea = new Vector3(10, 10, 10); // Zone de g�n�ration al�atoire
    public bool useRandomSpawn = false; // Utiliser une position al�atoire pour la g�n�ration
    public float spawnInterval = 2f; // Intervalle de temps entre chaque g�n�ration

    private float timeSinceLastSpawn;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnObject();
            timeSinceLastSpawn = 0f;
        }
    }

    void SpawnObject()
    {
        Vector3 spawnPosition;

        if (useRandomSpawn)
        {
            // G�n�re une position al�atoire dans la zone de g�n�ration sp�cifi�e
            float x = Random.Range(-spawnArea.x / 2, spawnArea.x / 2);
            float y = Random.Range(-spawnArea.y / 2, spawnArea.y / 2);
            float z = Random.Range(-spawnArea.z / 2, spawnArea.z / 2);
            spawnPosition = new Vector3(x, y, z) + transform.position;
        }
        else
        {
            // Utilise le point de g�n�ration fixe
            spawnPosition = spawnPoint.position;
        }

        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
        Debug.Log("Objet g�n�r� � la position : " + spawnPosition);
    }
}
