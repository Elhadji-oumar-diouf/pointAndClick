using TMPro;
using UnityEngine;

public class CarCollisionStop : MonoBehaviour
{
    private Rigidbody2D carRigidbody;
    /*public string stopOnCollisionWithTag = "CarCollision"; */// Tag de l'objet avec lequel la collision arr�te la voiture

    public TextMeshProUGUI InstructMessage; // R�f�r; // R�f�r
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
        // D�place l'objet continuellement dans la direction sp�cifi�e � la vitesse sp�cifi�e
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("TES component missing from this GameObject. Please add a Rigidbody component.");

        // V�rifie si l'objet avec lequel la voiture est entr�e en collision a le tag sp�cifi�
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
