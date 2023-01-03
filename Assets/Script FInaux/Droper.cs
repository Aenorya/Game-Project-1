using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

//Code Zoe
public class Droper : MonoBehaviour
{
    public PickableCollection pickables;
    //public int countSyringe;

    PickableObject GetDroppedPickObj()
    {
        int randomNumber = Random.Range(1, 101);
        List<PickableObject> possiblePickObjs = new List<PickableObject>(); ;
        foreach (DropRate pickObj in pickables.drops)
        {
            if (randomNumber <= pickObj.rate)
            {
                possiblePickObjs.Add(pickObj.pickable);
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
            Debug.Log("COUCOU G DROP D TRUKS");
            GameObject pickObjGameObject = Instantiate(droppedPickObjs.poPrefab, PickObjSpawnPosition, Quaternion.identity);
            pickObjGameObject.GetComponent<SpriteRenderer>().sprite = droppedPickObjs.poSprite;
        }
    }
    //public void AddSyringe(int count)
    //{
    //    countSyringe += count;
    //}

    //public void RemoveCoins(int count)
    //{
    //    countSyringe -= count;
    //}
}
