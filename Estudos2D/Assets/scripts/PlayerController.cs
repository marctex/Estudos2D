using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidadePlayer;
    public Rigidbody2D oRigidbody2D;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        float inputMovement = Input.GetAxisRaw("Horizontal");
        oRigidbody2D.velocity = new Vector2(inputMovement * velocidadePlayer, oRigidbody2D.velocity.y);
    }
}
