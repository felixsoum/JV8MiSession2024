using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    public GameObject spikePrefab;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 1f, 1f);
    }

    void Spawn()
    {
        Instantiate(spikePrefab, transform.position, Quaternion.identity);
    }
}
