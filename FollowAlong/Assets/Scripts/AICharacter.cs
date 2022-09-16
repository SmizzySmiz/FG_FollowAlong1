using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AICharacter : MonoBehaviour
{
    [SerializeField] private PlayerTurn playerTurn;

    [SerializeField] private NavMeshAgent agent;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            bool IsPlayerTurn = playerTurn.IsPlayerTurn();
            if (IsPlayerTurn)
            {
                RaycastHit result;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out result, 100.0f))
                {
                    agent.SetDestination(result.point);
                }
            }
        }
    }
}
