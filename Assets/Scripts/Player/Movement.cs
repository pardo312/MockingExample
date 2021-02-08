using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 movementInput;

    [SerializeField]private float speed;
    // Start is called before the first frame update
    void Start()
    {
        movementInput =  Vector3.zero;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movementInput = new Vector3(Input.GetAxisRaw("Horizontal"),0, Input.GetAxisRaw("Vertical"));
        if (Input.GetMouseButtonDown(0))
        {
            checkIfCollidesWithEnemy();
        }
    }
    void FixedUpdate()
    {
        rb.velocity += movementInput * Time.deltaTime * speed;
    }

    private void checkIfCollidesWithEnemy()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
            Transform selection = hit.transform;
            Obstacle obstacleSelected;
            if (obstacleSelected = selection.GetComponent<Obstacle>())
            {
                GetComponent<Status>().score++;
                obstacleSelected.obstacleLife--;
            }
            
        }

    }

}
