using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContreoller : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerController = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position += playerController.normalized * speed * Time.deltaTime;
    }
}
