using UnityEngine;



public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // L'objet à générer
    public Transform spawnPoint; // Point de génération fixe
    public Vector3 spawnArea = new Vector3(10, 10, 10); // Zone de génération aléatoire
    public bool useRandomSpawn = false; // Utiliser une position aléatoire pour la génération
    public float spawnInterval = 2f; // Intervalle de temps entre chaque génération

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
            // Génère une position aléatoire dans la zone de génération spécifiée
            float x = Random.Range(-spawnArea.x / 2, spawnArea.x / 2);
            float y = Random.Range(-spawnArea.y / 2, spawnArea.y / 2);
            float z = Random.Range(-spawnArea.z / 2, spawnArea.z / 2);
            spawnPosition = new Vector3(x, y, z) + transform.position;
        }
        else
        {
            // Utilise le point de génération fixe
            spawnPosition = spawnPoint.position;
        }

        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
        Debug.Log("Objet généré à la position : " + spawnPosition);
    }
}
