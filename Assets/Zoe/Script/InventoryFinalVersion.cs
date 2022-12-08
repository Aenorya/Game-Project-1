using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

//Code Zoe
public class InventoryFinalVersion : MonoBehaviour
{
    public List<PickableObject> pickables = new List<PickableObject>();
    public int countSyringe;

    PickableObject GetDroppedPickObj()
    {
        int randomNumber = Random.Range(1, 101);
        List<PickableObject> possiblePickObjs = new List<PickableObject>(); ;
        foreach (PickableObject pickObj in pickables)
        {
            if (randomNumber <= pickObj.dropChance)
            {
                possiblePickObjs.Add(pickObj);
            }
        }

        if (possiblePickObjs.Count > 0)
        {
            PickableObject droppedPickObjs = possiblePickObjs[Random.Range(0, possiblePickObjs.Count)];
            return droppedPickObjs;
        }

        return null;
    }

    public void InstantiateLoot(Vector3 PickObjSpawnPosition)
    {
        PickableObject droppedPickObjs = GetDroppedPickObj();
        if (droppedPickObjs != null)
        {
            GameObject pickObjGameObject = Instantiate(droppedPickObjs.poPrefab, PickObjSpawnPosition, Quaternion.identity);
            pickObjGameObject.GetComponent<SpriteRenderer>().sprite = droppedPickObjs.poSprite;
        }
    }
    public void AddSyringe(int count)
    {
        countSyringe += count;
    }

    public void RemoveCoins(int count)
    {
        countSyringe -= count;
    }
}
