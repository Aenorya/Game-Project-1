using UnityEngine;

public class CurrentSceneManager : MonoBehaviour
{
    public int coinsPickedUpInThisSceneCount;
    public Vector3 respawnPoint;
    public int levelToUnlock;

    public static CurrentSceneManager instance;
    
    private int MobCount = 0;
    private int MobLimit = 25;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de CurrentSceneManager dans la scène");
            return;
        }

        instance = this;

        respawnPoint = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    public void SetMobCount(int amount)
    {
        MobCount += amount;
    }

    public int GetMobCount()
    {
        return MobCount;
    }

    public int GetMobLimit()
    {
        return MobLimit;
    }
}
