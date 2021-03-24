using UnityEngine;

public class Goomba : Enemy
{
    public Goomba()
    {
        enemyName = "Goomba";
    }

    public override void EnemyAttack(int damage)
    {
        Player.instance.PlayerTakeDamage(damage);
        FMODOneShotPlayer.instance.FMODPlayOneShotSound("event:/sfx/abilities/player_damage_acid");
        Debug.Log("Goomba deals " + damage + " damage to the player!");
    }
}