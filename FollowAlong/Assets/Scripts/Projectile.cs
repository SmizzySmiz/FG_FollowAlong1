using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
    [SerializeField] private GameObject damageIndicatorPrefab;
    private bool isActive;

    public void Initialize()
    {
        isActive = true;
        // -------- This method is for projectiles that have a parabole. ----------
        // We add a force only once, not every frame
        // Make sure to have "useGravity" toggled on in the rigid body
        projectileBody.AddForce(transform.forward * 700f + transform.up * 100f);
    }

    void Update()
    {
        if (isActive)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
          //GameObject collisionObject = collision.gameObject;
          //DestructionFree destruction = collisionObject.GetComponent<DestructionFree>();
         // if (GetComponent<DestructionFree>())
        
          {
            //Destroy(collisionObject);
            GameObject damageIndicator = Instantiate(damageIndicatorPrefab);
            damageIndicator.transform.position = collision.GetContact(0).point;
            
            Destroy(gameObject);
                        
          }
          
    }
       
}
