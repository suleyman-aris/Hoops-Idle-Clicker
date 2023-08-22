using System.Collections.Generic;
using UnityEngine;

public class MaterialList : MonoBehaviour
{
    public static MaterialList materialList;

    public List<Material> ManMaterial;

    private void Awake()
    {
        materialList = materialList == null ? this : materialList;
    }
}
