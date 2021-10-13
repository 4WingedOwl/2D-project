using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruby_Controller_real : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         QualitySettings.vSyncCount = 4;
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
      float horizontal = Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");
       
       Vector2 position = transform.position;
       position.x = position.x + 0.1f * horizontal;
       position.y = position.y + 0.1f * vertical;
       transform.position = position;
    }
}
