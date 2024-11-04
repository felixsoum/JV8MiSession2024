using UnityEngine;

public class OxyBox : MonoBehaviour
{
    Player player;
    LineRenderer lineRenderer;

    void Start()
    {
        player = FindAnyObjectByType<Player>();
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player.gameObject)
        {
            lineRenderer.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == player.gameObject)
        {
            lineRenderer.enabled = false;
        }
    }

    private void Update()
    {
        if (lineRenderer.enabled)
        {
            player.Oxygenate();
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, player.transform.position);
        }
    }
}
