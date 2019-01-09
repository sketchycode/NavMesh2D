using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour {
    [SerializeField] new private Camera camera;
    [SerializeField] private NavMeshAgent agent;

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            var worldPt = camera.ScreenToWorldPoint(Input.mousePosition);
            worldPt.z = 0;
            agent.SetDestination(worldPt);
        }
    }
}
