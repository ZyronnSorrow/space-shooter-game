using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Powerup", menuName = "EGS/Powerup")]
public class PowerupSO : ScriptableObject
{
	#region SerializeFields
	[SerializeField]
	[Tooltip("A description of what the powerup is and does. Seen in menus")]
	private string _description = "";
	[SerializeField]
	[Tooltip("An image for the powerup to be displayed in menus")]
	private Image _icon;
	[SerializeField]
	[Tooltip("The name of the powerup to be displayed in menus")]
	private string _name = "";
	[SerializeField]
	[Tooltip("The powerup effect that will be applied when the powerup is picked up")]
	private PowerupEffectSO _powerupEffect;
	#endregion

	#region Properties
	public string Description { get { return _description; } }
	public Image Icon { get { return _icon; } }
	public string Name { get { return _name; } }
	public PowerupEffectSO PowerupEffect { get { return _powerupEffect; } }
	#endregion
}
