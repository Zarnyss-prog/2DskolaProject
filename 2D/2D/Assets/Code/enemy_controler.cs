using UnityEngine;

public class enemy_controler : MonoBehaviour
{
    public GameObject[] points;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, points[0].transform.position, 5*Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, points[1].transform.position, 5 * Time.deltaTime);
    } 
}
