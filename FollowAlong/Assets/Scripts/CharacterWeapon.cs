using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWeapon : MonoBehaviour
{
    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform shootingStartPosition;
    [SerializeField] private TrajectoryLine lineRenderer;
       
   /* [SerializeField] private float weaponDamage;
      
    private float rayDelay;

    public void ShootLaser()
    {
        RaycastHit result;
        bool thereWasHit = Physics.Raycast(shootingStartPosition.position, transform.forward, out result, Mathf.Infinity);

        lineRenderer.SetPosition(0, shootingStartPosition.position);
              
        if (thereWasHit)
        {
            ActivePlayerHealth activePlayerHealth = result.collider.GetComponent<ActivePlayerHealth>();
            if (activePlayerHealth != null)
            {
                activePlayerHealth.TakeDamage(weaponDamage);
            }
            lineRenderer.SetPosition(1, result.point);
        }
        else
        {
            lineRenderer.SetPosition(1, shootingStartPosition.position + transform.forward * 50);
        }
    
}
   */

    private void Update() // Projectile weapon
    {
        bool IsPlayerTurn = playerTurn.IsPlayerTurn();
        lineRenderer.enabled = IsPlayerTurn;
        if (IsPlayerTurn)

        {
            Vector3 force = transform.forward * 700f + transform.up * 300f;
            lineRenderer.DrawCurvedTrajectory(force, shootingStartPosition.position);
            if (Input.GetKeyDown(KeyCode.V))
            {
                TurnManager.GetInstance().TriggerChangeTurn();
                GameObject newProjectile = Instantiate(projectilePrefab);
                newProjectile.transform.position = shootingStartPosition.position;
                newProjectile.GetComponent<Projectile>().Initialize(force);
            }
        }
    }
}
