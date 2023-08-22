using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActiveMan : MonoBehaviour
{
    public int levelIndex = 1;

    private string activeMan;

    private void Start()
    {
        activeMan = transform.name + SceneManager.GetActiveScene().buildIndex.ToString();
        if (PlayerPrefs.HasKey(activeMan))
        {
            levelIndex = PlayerPrefs.GetInt(activeMan);
        }
        LevelMan();
    }

    public void LevelMan()
    {
        SaveIndex();
        switch (levelIndex)
        {
            case 1:
                MaterialNull();
                transform.GetChild(1).GetComponent<Renderer>().material = MaterialList.materialList.ManMaterial[levelIndex - 1];

                //ManScale(new Vector3(0.4f, 1f, 0.4f));
                break;
            case 2:
                MaterialNull();

                transform.GetChild(1).GetComponent<Renderer>().material = MaterialList.materialList.ManMaterial[levelIndex - 1];

                transform.GetChild(5).gameObject.SetActive(true);
                transform.GetChild(6).gameObject.SetActive(true);

                //ManScale(new Vector3(0.45f, 1.25f, 0.45f));
                //  sarý bandana bileklik  .45,1.25,.45
                break;
            case 3:
                MaterialNull();

                transform.GetChild(1).GetComponent<Renderer>().material = MaterialList.materialList.ManMaterial[levelIndex - 1];

                transform.GetChild(4).gameObject.SetActive(true);
                transform.GetChild(5).gameObject.SetActive(true);
                transform.GetChild(6).gameObject.SetActive(true);
                transform.GetChild(7).gameObject.SetActive(true);

                //ManScale(new Vector3(0.5f, 1.25f, 0.5f));
                // yeþil short .5,1.25,.5
                break;
            case 4:
                MaterialNull();

                transform.GetChild(1).GetComponent<Renderer>().material = MaterialList.materialList.ManMaterial[levelIndex - 1];

                transform.GetChild(3).gameObject.SetActive(true);
                transform.GetChild(4).gameObject.SetActive(true);
                transform.GetChild(5).gameObject.SetActive(true);
                transform.GetChild(6).gameObject.SetActive(true);
                transform.GetChild(7).gameObject.SetActive(true);
                transform.GetChild(8).gameObject.SetActive(true);

                //ManScale(new Vector3(0.55f, 1.375f, 0.55f));
                //  mor T-Shirt .55,1.375,.5
                break;
            default:

                break;
        }
    }

    private void SaveIndex()
    {
        PlayerPrefs.SetInt(activeMan, levelIndex);
    }

    //private void ManScale(Vector3 manScale)
    //{
    //    transform.localScale = manScale;
    //}

    private void MaterialNull()
    {
        transform.GetChild(1).GetComponent<Renderer>().material = null;
    }

    private void DeActivator()
    {
        for (int i = 3; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    public void PreviousActiveChild()// Merge edilen makinadan sonraki kahve makinalarýnýn deðiþimidir
    {
        int thisObjectIndex = MatchList.matchList.gameObjects.IndexOf(transform.parent.gameObject);
        DeActivator();
        if (MatchList.matchList.gameObjects.Count > thisObjectIndex + 1)
        {
            levelIndex = MatchList.matchList.gameObjects[thisObjectIndex + 1].transform.GetChild(0).transform.GetComponent<ActiveMan>().levelIndex;
            LevelMan();
        }
        else
        {
            levelIndex = 1;

            LevelMan();
            transform.parent.gameObject.SetActive(false);
        }

    }
}
