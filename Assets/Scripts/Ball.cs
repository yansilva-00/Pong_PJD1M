
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb; //Rigdidbody é o que atribui fisica ao gameObject

    [SerializeField] private float ballSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Launch();


    }

    private void Launch()
    {
        Vector2 direction = Vector2.zero;

        if (Random.value <= 0.5f)
        {
            direction = Vector2.left;
        }

        else
        {
            direction = Vector2.right;
        }

        rb.linearVelocity = direction * ballSpeed;

    }
}

/*
 * pra declarar variável de componente chamar "rb" que representa rigidBody, chama o método da própria unity (nesse caso o GetComponent) 
 * e dps o tipo. e dps cria um método que defina o comportamento do gameObject (nesse caso Launch)
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */