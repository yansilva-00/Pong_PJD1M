using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;//vai ser a variavel de multiplicador
    private Vector2 directionInput;//vector2 valor em X e Y



    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector2.up * directionInput * speed * Time.deltaTime);//translate é para movimentação do paddle | primeiro chamar a classe TIME, pois o deltaTime é uma variavel dentro de time
        
    
    }


    public void OnMove(InputValue value)//
    {
        directionInput = value.Get<Vector2>(); //método OnMove está conectado em actions "move" no input sistem 
        

    }





}



