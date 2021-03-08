using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public float speed = 10f;
    public GameObject followPlayer;
    public Vector2 followPlayerOffset;
    private Vector2 threshhold;
    private Rigidbody2D rB;

    // Start is called before the first frame update
    void Start()
    {
        threshhold = calculateThreshold();
        rB = followPlayer.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 follow = followPlayer.transform.position;
        float xDifference = Vector2.Distance(Vector2.right * transform.position.x, Vector2.right * follow.x);
        float yDifference = Vector2.Distance(Vector2.up * transform.position.y, Vector2.up * follow.y);

        Vector3 newPosition = transform.position;

        if(Mathf.Abs(xDifference) >= threshhold.x)
        {
            newPosition.x = follow.x;
        }

        if(Mathf.Abs(yDifference) >= threshhold.y)
        {
            newPosition.y = follow.y;
        }

        float moveSpeed = rB.velocity.magnitude > speed ? rB.velocity.magnitude : speed;

        transform.position = Vector3.MoveTowards(transform.position, newPosition, moveSpeed * Time.deltaTime);

    }

    private Vector3 calculateThreshold()
    {
        Rect aspect = Camera.main.pixelRect;
        Vector2 t = new Vector2(Camera.main.orthographicSize * aspect.width / aspect.height, Camera.main.orthographicSize);
        t.x -= followPlayerOffset.x;
        t.x -= followPlayerOffset.y;
        return t;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Vector2 border = calculateThreshold();
        Gizmos.DrawWireCube(transform.position, new Vector3(border.x * 2, border.y * 2, 1));
    }
}
