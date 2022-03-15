using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public float speed = 0.25f;
    private static Direction currentDirection = Direction.Left;
    private enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    private void Start()
    {
        Application.targetFrameRate = 60;
    }
    void Update()
    {
        gameObject.transform.position = getNewPositionByDirection(gameObject.transform.position, currentDirection);


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentDirection = Direction.Left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentDirection = Direction.Right;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentDirection = Direction.Up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentDirection = Direction.Down;
        }
    }

    private Vector3 getNewPositionByDirection(Vector3 position, Direction direction)
    {
        switch (direction)
        {
            case Direction.Up:
                return new Vector3(position.x, position.y + speed);
            case Direction.Down:
                return new Vector3(position.x, position.y - speed);
            case Direction.Left:
                return new Vector3(position.x - speed, position.y);
            case Direction.Right:
                return new Vector3(position.x + speed, position.y);
            default:
                throw new System.Exception();
        }
    }
}
