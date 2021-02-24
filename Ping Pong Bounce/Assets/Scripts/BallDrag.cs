using UnityEngine;
using System.Collections;

public class BallDrag : MonoBehaviour
{
    [SerializeField] private GameObject touchableBall;

    private bool isPressed;

    private float releaseDelay;
    private float maxDragDistance = 2.5f;

    private Rigidbody2D rb;
    private SpringJoint2D sj;
    private Rigidbody2D slingRb;
    private LineRenderer lineRenderer;
    private TrailRenderer trailRenderer;

    Ray ray;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sj = GetComponent<SpringJoint2D>();
        lineRenderer = GetComponent<LineRenderer>();
        trailRenderer = GetComponent<TrailRenderer>();
        slingRb = sj.connectedBody;

        lineRenderer.enabled = false;
        trailRenderer.enabled = false;

        releaseDelay = 1 / (sj.frequency * 4);
    }

    void FixedUpdate()
    {
        if (isPressed)
            DragBall();
    }

    private void DragBall()
    {
        SetLineRendererPosition();

        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float distance = Vector2.Distance(mousePosition, slingRb.position);

        if (distance > maxDragDistance)
        {
            Vector2 direction = (mousePosition - slingRb.position).normalized;
            rb.position = slingRb.position + direction * maxDragDistance;
        }
        else
            rb.position = mousePosition;
    }

    private void SetLineRendererPosition()
    {
        Vector3[] positions = new Vector3[2];
        positions[0] = rb.position;
        positions[1] = slingRb.position;

        lineRenderer.SetPositions(positions);
    }

    private void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
        lineRenderer.enabled = true;
    }

    private void OnMouseUp()
    {
        Destroy(touchableBall);
        isPressed = false;
        rb.isKinematic = false;
        StartCoroutine(Release());
        lineRenderer.enabled = false;
    }

    private IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseDelay);
        sj.enabled = false;
        trailRenderer.enabled = true;
    }
}
