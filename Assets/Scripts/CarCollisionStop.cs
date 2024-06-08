using TMPro;
using UnityEngine;

public class CarCollisionStop : MonoBehaviour
{
    private Rigidbody2D carRigidbody;
    /*public string stopOnCollisionWithTag = "CarCollision"; */// Tag de l'objet avec lequel la collision arrête la voiture

    public TextMeshProUGUI InstructMessage; // Référ; // Référ
    public Vector3 direction = Vector3.forward; // Direction du mouvement
    public float speed = 5f; // Vitesse du mouvement


  

    void Start()
    {
        carRigidbody = GetComponent<Rigidbody2D>();

        if (carRigidbody == null)
        {
            Debug.LogError("Rigidbody component missing from this GameObject. Please add a Rigidbody component.");
        }
    }

    void Update()
    {
        // Déplace l'objet continuellement dans la direction spécifiée à la vitesse spécifiée
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("TES component missing from this GameObject. Please add a Rigidbody component.");

        // Vérifie si l'objet avec lequel la voiture est entrée en collision a le tag spécifié
        if (collision.gameObject.CompareTag("CarCollision"))
        {
            Debug.Log("Stop");
            StopCar();
        }
    }

 

    void StopCar()
    {
        if (carRigidbody != null)
        {
            speed = 0L;
            carRigidbody.velocity = Vector2.zero;
            carRigidbody.angularVelocity = 0L;
        }
    }
}
