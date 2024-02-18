using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject prefab;
    public Transform refPos;


    public bool isActivated = false;


    public void CreatePrefabs()
    {
        GameObject go=Instantiate(prefab,refPos.position,Quaternion.identity);
    }

    public void LeverActivated()
    {
        isActivated = true;
        StartCoroutine(CreatePrefabsLoop());
    }
    public void LeverDActivated()
    {
        isActivated = false;
        StopCoroutine(CreatePrefabsLoop());
    }
    IEnumerator CreatePrefabsLoop()
    {
        while(isActivated)
        {
            yield return new WaitForSeconds(1f);
            CreatePrefabs();
        }
    }

}
