using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Scriptable Objects/PlayerStats")]

public class PlayerStats : ScriptableObject
{
    [Tooltip("Maximum health")]
    public float maxHealth;
    [Tooltip("Seconds between dashes")]
    public float dashCooldown;
    [Tooltip("number of dashes")]
    public int dashCount;
    [Tooltip("Armor (damage reduction)")]
    public float armor;
    [Tooltip("Movement Speed")]
    public float moveSpeed;
}
