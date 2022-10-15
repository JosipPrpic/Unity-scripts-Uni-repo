using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 30;
    void Start()
    {
        // Vector2.right daje vrijednost za označavanje desne strane
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;

        
        
    }

    
        void OnCollisionEnter2D(Collision2D col)
        {
            // Provjera da li je loptica udarila u lijevi reket
            if (col.gameObject.name == "RacketLeft")
            {
                // Provjera u koji dio reketa je loptica udarila
                float y = HitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);
                // Normalizacija vektora
                Vector2 direction = new Vector2(1, y).normalized;
                // Pomicanje loptice
                GetComponent<Rigidbody2D>().velocity = direction * speed;
            }
            // Provjera da li je loptica udarila u desni reket
            if (col.gameObject.name == "RacketRight")
            {
                // Provjera u koji dio reketa je loptica udarila
                float y = HitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);
                // Normalizacija vektora
                Vector2 direction = new Vector2(-1, y).normalized;
                // Pomicanje loptice
                GetComponent<Rigidbody2D>().velocity = direction * speed;
            }
            private float HitFactor(Vector2 ballPosition, Vector2 racketPosition, float racketHeight)
            {
                // 1 <- gornji dio reketa
                // 0 <- sredina reketa
                // -1 <- donji dio reketa
                return (ballPosition.y - racketPosition.y) / racketHeight;
            }
        }
    
    

}
