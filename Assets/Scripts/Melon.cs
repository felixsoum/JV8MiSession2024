using UnityEngine;

public class Melon : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.gameObject.GetComponent<Player>();
        if (player != null )
        {
            player.EatMelon();
            Destroy(gameObject);
        }
    }
}
