using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            RaycastHit result;
            bool thereWasHit = Physics.Raycast(transform.position, transform.forward, out result, Mathf.Infinity);

            Debug.DrawRay(transform.position, transform.forward * 50f, Color.red, 0.05f);

            if (thereWasHit)
            {
                //result.collider.gameObject.GetComponent<MeshRenderer>().material.color = GetRandomColor();
                Destroy1 otherCharacter = result.collider.GetComponent<Destroy1>();
                if (otherCharacter != null)
                {
                    Destroy(result.collider.gameObject);
                }
            }

            
        }
    }

    private Color GetRandomColor()
    {
        Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
        return color;
    }
}
