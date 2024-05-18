using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public string parentName;
    // Start is called before the first frame update
    void Start()
    {

        parentName = transform.name;
        StartCoroutine(DestroyClone());
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    IEnumerator DestroyClone()
    {
        yield return new WaitForSeconds(50);
        if (parentName == "Section(Clone)")
        {
            Destroy(gameObject);
        }

    }
}
