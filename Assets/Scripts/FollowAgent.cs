using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowAgent : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Vector2 offset;

    private void LateUpdate() {
        transform.position = agent.transform.position + (Vector3)offset;
    }
}
