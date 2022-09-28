
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
   // [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private Transform weaponBarrel;
    [SerializeField] private float damage = 50f;


    void Update()
    {
        bool IsPlayerTurn = playerTurn.IsPlayerTurn();
        //lineRenderer.enabled = IsPlayerTurn;
        if (IsPlayerTurn)

            if (Input.GetKeyDown(KeyCode.F))
        {
            RaycastHit result;
            bool thereWasHit = Physics.Raycast(weaponBarrel.position, weaponBarrel.forward, out result, Mathf.Infinity);
            Debug.Log(result.collider.name);  
                         
          // ------- The straight line trajectory code -------//
            Vector3 start = weaponBarrel.position;
            Vector3 end = weaponBarrel.position + weaponBarrel.forward * 50f;
            //lineRenderer.SetPosition(0, start);
            //lineRenderer.SetPosition(1, end);

            if (thereWasHit)
            {
                TurnManager.GetInstance().TriggerChangeTurn();
                                                
                ActivePlayerHealth activePlayerHealth = result.collider.GetComponent<ActivePlayerHealth>();
                if (activePlayerHealth != null)
                {
                    activePlayerHealth.TakeDamage(damage);
                }
               // lineRenderer.SetPosition(1, result.point);
            }
            //else
            //{
            //    lineRenderer.SetPosition(1, weaponBarrel.position + weaponBarrel.forward * 50);
            //}
        }
            //{
            // result.collider.gameObject.GetComponent<MeshRenderer>().material.color = GetRandomColor();
            //}
        
    }

    //private Color GetRandomColor()
    //{
     //   Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
      //  return color;
    //}
}