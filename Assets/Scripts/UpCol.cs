using UnityEngine;
using System.Collections.Generic;

public class UpdateCollider : MonoBehaviour
{
    private PolygonCollider2D polygonCollider;
    private SpriteRenderer spriteRenderer;
    private List<Vector2> path = new List<Vector2>();

    void Start()
    {
        polygonCollider = GetComponent<PolygonCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        UpdatePolygonCollider();
    }

    void UpdatePolygonCollider()
    {
        if (polygonCollider != null && spriteRenderer != null)
        {
            if (spriteRenderer.sprite == null) return;

            int shapeCount = spriteRenderer.sprite.GetPhysicsShapeCount();
            if (shapeCount == 0) return;


            polygonCollider.pathCount = shapeCount;

            for (int i = 0; i < shapeCount; i++)
            {
                path.Clear();
                spriteRenderer.sprite.GetPhysicsShape(i, path);
                polygonCollider.SetPath(i, path);
            }
        }
    }
}
