using UnityEngine;
using UnityEngine.InputSystem;
public class Movimiento : MonoBehaviour
{
    public float velocidad =0.5f;
     public float impulsoSalto= 10.0f;
    public Vector3 inicioPersonaje = new Vector3 (1,2,3);


    void Start()
    {
        this.transform.position = inicioPersonaje;
    }
    void update()
    {
        Vector2 moveInput = InputSystem.actions["Move"].ReadValue<Vector2>();
     
        this.transform.Translate(moveInput.x * velocidad, moveInput.y * velocidad, 0);
     
      if(moveInput.x < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        } 
        else if (moveInput.x > 0)
        {
           this.GetComponent<SpriteRenderer>().flipX = false;

        }

    }
}
