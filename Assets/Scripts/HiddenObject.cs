using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenObject : MonoBehaviour
{


    private void Start()
    {

    }

    private void OnMouseDown()
    {
        /** If you want object to remain in list */
        // gameObject.SetActive(false);
        HiddenManager.Instance.hiddenObjects.Remove(gameObject);
        
        DestroyImmediate(gameObject);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
