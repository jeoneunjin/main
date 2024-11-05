using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject magicWand;
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) {
            var mousPos = Input.mousePosition;
            mousPos.z = Camera.main.nearClipPlane + 0.1f;
            var screePos = Camera.main.ScreenToWorldPoint(mousPos);

            magicWand.transform.LookAt(screePos);
        }
    }

}
