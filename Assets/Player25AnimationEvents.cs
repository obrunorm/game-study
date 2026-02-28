using UnityEngine;

public class Player25AnimationEvents : MonoBehaviour
{
    private Player25 player;

    void Awake()
    {
        player = GetComponentInParent<Player25>();
    }

    public void DamageEnemies() => player.DamageEnemies();

    private void DisableMovementAndJump() => player.EnableMovementAndJump(false);

    private void EnableMovementAndJump() => player.EnableMovementAndJump(true);

}
