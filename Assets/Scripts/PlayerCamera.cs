using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    Player player;

    void Start()
    {
        player = FindAnyObjectByType<Player>();    
    }

    void Update()
    {
        var pos = transform.position;
        pos.x = player.transform.position.x;
        transform.position = pos;
    }
}
