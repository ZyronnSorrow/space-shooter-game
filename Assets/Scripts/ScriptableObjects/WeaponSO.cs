using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Weapon", menuName = "EGS/Weapon")]
public class WeaponSO : ScriptableObject
{
	#region SerializeFields
	[SerializeField]
	[Tooltip("The cooldown time inbetween shots in seconds")]
	private float _cooldown = 0f;
	[SerializeField]
	[Tooltip("The description of what the weapon does, which will be seen in menus")]
	private string _description = "";
	[SerializeField]
	[Tooltip("The image of the weapon which will be seen in menus")]
	private Image _icon;
	[SerializeField]
	[Tooltip("The amount of overheat that gets added when the weapon is fired")]
	private float _overheatAmount = 0f;
	[SerializeField]
	[Tooltip("The projectile data for the weapon")]
	private ProjectileSO _projectile;
	#endregion

	#region Properties
	public float Cooldown { get { return _cooldown; } }
	public string Description { get { return _description; } }
	public Image Icon { get { return _icon; } }
	public float OverheatAmount { get { return _overheatAmount; } }
	public ProjectileSO Projectile { get { return _projectile; } }
	#endregion
}
