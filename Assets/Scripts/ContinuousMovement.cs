using UnityEngine;

public class ContinuousMovement : MonoBehaviour
{
    public Vector3 direction = Vector3.forward; // Direction du mouvement
    public float speed = 5f; // Vitesse du mouvement


    void Update()
    {
        // Déplace l'objet continuellement dans la direction spécifiée à la vitesse spécifiée
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
