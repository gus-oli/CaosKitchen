using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private GameInput gameInput;

    void Update()
    {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);

        float playerSize = .7f;
        bool canMove = !Physics.Raycast(transform.position, moveDir, playerSize);

        if (canMove) {
            transform.position += moveDir * moveSpeed * Time.deltaTime;
        }
        else
        {
            Debug.Log("Colisão detectada, não é possível mover o personagem");
        }
    }
}
