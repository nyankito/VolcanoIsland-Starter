using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public int initialHealth = 3;
    private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = initialHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x = pos.x - speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x = pos.x + speed * Time.deltaTime;     
        }
        this.transform.position = pos;    
    }
}
