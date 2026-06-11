using UnityEngine;

public class PotionSpawner : MonoBehaviour
{
    public Transform SpawnPoint;

    public void Spawn(GameObject potion)

    {
        Instantiate(potion,SpawnPoint.position, Quaternion.identity);
    }
}
