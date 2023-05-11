using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float degreesPerSecond = 45;

    public float X,Y,Z;
    Vector3 trajectory;

    private void Start()
    {
        trajectory = new Vector3(X, Y, Z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, trajectory, degreesPerSecond * Time.deltaTime);
    }

}
