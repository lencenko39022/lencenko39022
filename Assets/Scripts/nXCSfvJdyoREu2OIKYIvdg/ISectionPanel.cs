using UnityEngine;

/// <summary>
/// Contract between the lobby router and one secondary screen. The router holds the
/// screens as an array of this type and addresses them by integer index, so no screen
/// is ever found by name and obfuscation cannot break the navigation.
/// </summary>
public interface _0xeb461ae5
{
    RectTransform Root { get; }

    /// <summary>Called every time the screen becomes the active one.</summary>
    void Enter();
    /// <summary>Called roughly once a second while the screen is active.</summary>
    void Tick();
}