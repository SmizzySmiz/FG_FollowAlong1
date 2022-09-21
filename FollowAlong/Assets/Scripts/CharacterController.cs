using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Rigidbody characterBody;
    [SerializeField] private float speed = 2f;
    [SerializeField] private PlayerTurn playerTurn;

    void Update()
    {
        if(playerTurn.IsPlayerTurn())
        {
            if (Input.GetAxis("Horizontal") != 0)
            {
                transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
            }

            if (Input.GetKeyDown(KeyCode.Space) && IsTouchingFloor())
            {
                Jump();
            }
        }
    }

    private void Jump()
    {
        characterBody.AddForce(Vector3.up * 300f);
      //  Debug.LogWarning("Great bathroom break!");
    }

    private bool IsTouchingFloor()
    {
       // Debug.LogWarning ("Ooh, toilet!");
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
