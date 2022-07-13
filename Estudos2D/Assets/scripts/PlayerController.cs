using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidadePlayer;
    public Rigidbody2D oRigidbody2D;
    public SpriteRenderer oSpriteRenderer;

    public bool estaNoPiso;
    public Transform verificaPiso;
    public float raioDeVerificacao;
    public LayerMask layerPiso;
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
        Pular();
    }

    public void MovePlayer()
    {
        float inputMovement = Input.GetAxisRaw("Horizontal");
        oRigidbody2D.velocity = new Vector2(inputMovement * velocidadePlayer, oRigidbody2D.velocity.y);
        if (inputMovement > 0)
        {
            oSpriteRenderer.flipX = false;
        }

        if (inputMovement < 0)
        {
            oSpriteRenderer.flipX = true;
        }
    }

    public void Pular()
    {
        estaNoPiso = Physics2D.OverlapCircle(verificaPiso.position, raioDeVerificacao, layerPiso);
    }
}
