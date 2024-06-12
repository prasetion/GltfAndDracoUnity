using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadModel : MonoBehaviour
{

    [SerializeField] string url = "https://raw.githubusercontent.com/KhronosGroup/glTF-Sample-Models/master/2.0/Duck/glTF/Duck.gltf";

    async void Start()
    {
        // load glTF
        var gltf = new GLTFast.GltfImport();
        var success = await gltf.Load(url);
        if (success)
        {
            success = await gltf.InstantiateMainSceneAsync(transform);
        }
    }


}
