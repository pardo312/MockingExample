using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
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
        
        }
        void FixedUpdate()
        {
            rb.velocity += movementInput * Time.deltaTime * speed;
        }
   

    }

}
