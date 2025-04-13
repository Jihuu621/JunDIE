using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class BackGround : MonoBehaviour
{
    private MeshRenderer render;
    public float speed;
    private float offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offset += Time.deltaTime * speed;
        render.material.mainTextureOffset = new Vector2(offset, 0);
    }
}

