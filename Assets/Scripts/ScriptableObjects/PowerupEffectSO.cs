using UnityEngine;

public enum PowerupEffectType
{
	SpeedIncrease,
	OverheatReduction,
	DamageReduction
}

[CreateAssetMenu(fileName = "New Powerup Effect", menuName = "EGS/Powerup Effect")]
public class PowerupEffectSO : ScriptableObject
{
	#region SerializeFields
	[SerializeField]
	[Tooltip("A description of what the effect is, which will be seen in menus")]
	private string _description = "";
	[SerializeField]
	[Tooltip("How long the effect lasts in seconds")]
	private float _duration = 0f;
	[SerializeField]
	[Tooltip("What type of powerup effect this is")]
	private PowerupEffectType _powerupEffectType = PowerupEffectType.SpeedIncrease;
	[SerializeField]
	[Tooltip("The value associated with the effect (eg speed increase amount, damage reduction amount, etc)")]
	private float _value = 0f;
	#endregion

	#region Properties
	public string Description { get { return _description; } }
	public float Duration { get { return _duration; } }
	public PowerupEffectType PowerupEffectType { get { return _powerupEffectType; } }
	public float Value { get { return _value; } }
	#endregion
}
