using UnityEngine;

public class WeaponSkin : ScriptableObject
{
	public KLSIJJEGQNH id;

	public GameObject weapon;

	public WeaponDamageEntity damageEntity;

	public WeaponDamageEntityVisual damageVisual;

	public GameObject shell;

	public GameObject shootFX;

	public GameObject meleeHitFX;

	public SoundEffect aimSound;

	public SoundEffect shotSound;

	public SoundEffect reloadSound;

	public SoundEffect fastWeaponSwitch;

	public SoundEffect gunDropSfx;

	public SoundEffect meleeHitSound;
}
