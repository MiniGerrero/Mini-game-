using UnityEngine;  
  
public class PlayerMovement : MonoBehaviour  
{  
    public float speed = 5f;          // Velocidad del personaje  
    Rigidbody2D rb;                   // Referencia al Rigidbody2D  
  
    void Start()  
    {  
        rb = GetComponent<Rigidbody2D>(); // Busca el Rigidbody2D en el GameObject  
    }  
  
    void Update()  
    {  
        // Toma el input del teclado (flechas o WASD)  
        float moveX = Input.GetAxisRaw("Horizontal");  
        float moveY = Input.GetAxisRaw("Vertical");  
  
        // Crea el vector de movimiento  
        Vector2 movement = new Vector2(moveX, moveY).normalized;  
  
        // Aplica el movimiento multiplicando por la velocidad  
        rb.linearVelocity = movement * speed;  
    }  
  
    void OnCollisionEnter2D(Collision2D collision)  
    {  
        // Esto detecta una colisión con otro Collider2D  
        Debug.Log("Colisión con: " + collision.gameObject.name);  
    }  
}  
