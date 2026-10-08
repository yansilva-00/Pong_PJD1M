using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;
    private Vector2 directionInput;



    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector2.up * directionInput * speed * Time.deltaTime);
        
    
    }


    public void OnMove(InputValue value)
    {
        directionInput = value.Get<Vector2>(); 
        

    }





}



