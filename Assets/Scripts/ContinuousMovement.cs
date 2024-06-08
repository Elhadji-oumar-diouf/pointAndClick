using UnityEngine;

public class ContinuousMovement : MonoBehaviour
{
    public Vector3 direction = Vector3.forward; // Direction du mouvement
    public float speed = 5f; // Vitesse du mouvement


    void Update()
    {
        // D�place l'objet continuellement dans la direction sp�cifi�e � la vitesse sp�cifi�e
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
