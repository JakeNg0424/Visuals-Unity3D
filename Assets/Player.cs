using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var transform = this.GetComponent<Transform>();

        var cc = this.GetComponent<CharacterController>();
        var delta = new Vector3(
            speed * Input.GetAxis("Horizontal"),
            0.0f,
            speed * Input.GetAxis("Vertical"));
        cc.SimpleMove(delta);

        var animator = transform.GetComponentsInChildren<Animator>()[0];
        if(delta.magnitude > 0.1){
            animator.Play("Walk State");
        } else {
            animator.Play("Idle State");
        }
    }
}
