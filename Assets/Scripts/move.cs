using UnityEngine;

public class Mover : MonoBehaviour
{
    public float vitesse = 5f; // Vitesse de déplacement

    // Update is called once per frame
    void Update()
    {
        // Input horizontal et vertical
        float deplacementHorizontal = Input.GetAxis("Horizontal");
        float deplacementVertical = Input.GetAxis("Vertical");

        // Calcul du vecteur de déplacement
        Vector3 deplacement = new Vector3(deplacementHorizontal, deplacementVertical, 0) * vitesse * Time.deltaTime;

        // Appliquer le déplacement au sprite
        transform.Translate(deplacement);
    }
}