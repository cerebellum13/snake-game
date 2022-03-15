using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position = new Vector2(transform.position.x - 1, transform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position = new Vector2(transform.position.x + 1, transform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.position = new Vector2(transform.position.x, transform.position.y + 1);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.position = new Vector2(transform.position.x, transform.position.y - 1);
        }
    }
}
