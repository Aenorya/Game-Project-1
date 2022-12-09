using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject player;
    private void Awake()
    {
        player.transform.position = transform.position;
    }
}
