using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public float speed = 0.25f;
    public GameObject taleObject;

    private static Snake instance;

    private static Direction currentDirection = Direction.Left;
    private static Dictionary<GameObject, Direction> snakeTale;
    private enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    
    private Snake(){}

    public static Snake GetInstance()
    {
        if (instance == null)
        {
            return new Snake();
        }
        else return instance;
    }
    private void Start()
    {
        Application.targetFrameRate = 60;
        snakeTale = new Dictionary<GameObject, Direction>();
        AddSnakeTale();
    }
    void Update()
    {
        gameObject.transform.position = getNewPositionByDirection(gameObject.transform.position, currentDirection);

        Direction newDirection = currentDirection;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            newDirection = Direction.Left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            newDirection = Direction.Right;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            newDirection = Direction.Up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            newDirection = Direction.Down;
        }

        if(currentDirection != newDirection)
        {
            gameObject.transform.GetChild(1).position = getNewPositionForTale(newDirection);
        }

        currentDirection = newDirection;
    }

    public void AddSnakeTale()
    {
        GameObject newTale = Instantiate(taleObject, new Vector3(0, 0, 0), Quaternion.identity);

        snakeTale.Add(newTale, currentDirection);
    }
    private Vector3 getNewPositionForTale(Direction direction)
    {
        Vector3 position = gameObject.transform.position;
        switch (direction)
        {
            case Direction.Up:
                return new Vector3(position.x, position.y - 2);
            case Direction.Down:
                return new Vector3(position.x, position.y + 2);
            case Direction.Left:
                return new Vector3(position.x + 2, position.y);
            case Direction.Right:
                return new Vector3(position.x - 2, position.y);
            default:
                throw new System.Exception();
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
