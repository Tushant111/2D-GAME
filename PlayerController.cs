using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -14)
        {
            transform.position = new Vector3(-14 , transform.position.y , transform.position.z);
        }
        if (transform.position.x >= 14)
        {
            transform.position = new Vector3(14 , transform.position.y , transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab,transform.position,Quaternion.identity);
        }
    }
}
