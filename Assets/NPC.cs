using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class NPC : MonoBehaviour
{
    #region Movimiento Click
    /*
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if(Physics.Raycast(rayo, out hit, 1000))
            {
                GetComponent<NavMeshAgent>().SetDestination(hit.point);
            }
        }
    }*/
    #endregion

    public Transform ruta;
    int indiceHijos;
    Vector3 destino;

    private void Start()
    {
        destino = ruta.GetChild(indiceHijos).position;
        GetComponent<NavMeshAgent>().SetDestination(destino);
    }

    private void Update()
    {
        /*
        if(Vector3.Distance(transform.position, destino) < 2)
        {
            indiceHijos++; 
            if(indiceHijos >= ruta.childCount)
            {
                indiceHijos = 0;
            }

            destino = ruta.GetChild(indiceHijos).position;
            GetComponent<NavMeshAgent>().SetDestination(destino);
        }
        */

    }
}
