using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Class that defines the various event paths as a string constant.
/// Anywhere that passes the event path as a string, use these constants.
/// </summary>

public class FMODEventConstants
{
    //Music Constants
    public const string LEVEL1 = "event:/music/level1";


    //Player SFX constants
    public const string PLAYER_SHOOT = "event:/sfx/abilities/hamster_shoot";


    //Enemy SFX constants
    public const string GOOMBA_ATTACK = "event:/sfx/abilities/player_damage_acid";
    public const string KOOPA_ATTACK = "event:/sfx/abilities/hamster_grapple_shoot";
    public const string BOBOMB_ATTACK = "event:/sfx/abilities/hamster_explosion_fire";

}
