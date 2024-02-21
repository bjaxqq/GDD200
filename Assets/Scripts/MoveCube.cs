using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed;
    private int direction = 1; // 1 for right, -1 for left
    public float distanceThreshold = 10f; // Adjust this based on how far you want the cube to move

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed * direction);

        // Check if the cube has reached the threshold distance
        if (Mathf.Abs(transform.position.x) >= distanceThreshold)
        {
            // Reverse the direction
            direction *= -1;
        }
    }
}
