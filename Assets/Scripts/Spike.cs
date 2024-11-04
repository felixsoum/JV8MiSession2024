using UnityEngine;

public class Spike : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * 5f);        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            player.Damage();

            Destroy(gameObject);
        }
    }
}
