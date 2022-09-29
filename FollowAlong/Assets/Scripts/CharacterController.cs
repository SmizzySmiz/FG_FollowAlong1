using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    /* Original Movement Script....
     [SerializeField] private Rigidbody characterBody;
     [SerializeField] private TurnManager playerturn;
     [SerializeField] private float rotationSpeed;
     [SerializeField] private float walkingSpeed;

     void Update()
     {

         {
             if (Input.GetAxis("Horizontal") != 0)
             {
                // ActivePlayer currentPlayer = playerturn.IsPlayerTurn();
                 transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);
             }

             if (Input.GetAxis("Vertical") != 0)
             {
                 //ActivePlayer currentPlayer = manager.GetCurrentPlayer();
                 transform.Translate(transform.forward * walkingSpeed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);
             }

             if (Input.GetKeyDown(KeyCode.X))
             {
                 //ActivePlayer currentPlayer = manager.GetCurrentPlayer();
                 GetComponent<CharacterWeapon>().ShootLaser();
             }
             if (Input.GetKeyDown(KeyCode.Space) && IsTouchingFloor())
             {
                 Jump();
             }
         }
     } */
      [SerializeField] private Rigidbody characterBody;
      [SerializeField] private PlayerTurn playerTurn;
      [SerializeField] private float speed = 2f;
      [SerializeField] private float rotationSpeed = 50f;

    void Update() // Player Movement, rotation & jump.
      {
          if(playerTurn.IsPlayerTurn())
          {
              if (Input.GetAxis("Horizontal") != 0)
              {
                //transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
                transform.Rotate(transform.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
               }

              if (Input.GetAxis("Vertical") != 0)
              {
                //transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
                transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
            }

              if (Input.GetKeyDown(KeyCode.Space) && IsTouchingFloor())
              {
                  Jump();
              }
          }
      }
     
    private void Jump() // Jump force - height
    {
        characterBody.AddForce(Vector3.up * 300f);
      //  Debug.LogWarning("Great");
    }

    private bool IsTouchingFloor() // Check for contact with the floor.
    {
       // Debug.LogWarning ("Ooh");
        RaycastHit hit;
        // Parameters:
        // - The center from where we shoot
        // - Radius of the sphere
        // - Direction of the sphere
        // - hit parameter
        // - Distance the sphere
        bool result = Physics.SphereCast(transform.position, 0.15f, -transform.up, out hit, 1f);
        return result;
    }
   
}
