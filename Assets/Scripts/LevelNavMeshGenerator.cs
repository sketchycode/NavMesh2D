using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LevelNavMeshGenerator : MonoBehaviour {
    [SerializeField] private NavMeshSurface surface;
    [SerializeField] private float tileSize = 1f;
    [SerializeField] private Vector2 startPoint;
    [SerializeField] private Vector2Int size;
    [SerializeField] private LayerMask wallCollisionLayer;
    [SerializeField] private BoxCollider navMeshObstaclePrefab;

    private void Start() {
        for(int x=0; x <size.x; x++) {
            for(int y=0; y<size.y; y++) {
                var checkPoint = new Vector2(startPoint.x + (x * tileSize), startPoint.y + (y * tileSize));
                var hit = Physics2D.OverlapBox(checkPoint, Vector2.one * tileSize * 0.8f, 0, wallCollisionLayer);

                if(hit) {
                    var collider = GameObject.Instantiate(navMeshObstaclePrefab, checkPoint, Quaternion.identity);
                    collider.transform.parent = transform;
                }
            }
        }

        surface.BuildNavMesh();
    }
}
