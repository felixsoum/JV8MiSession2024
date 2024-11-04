using TMPro;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public TMP_Text winText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            player.Freeze();
            winText.enabled = true;
        }
    }
}
