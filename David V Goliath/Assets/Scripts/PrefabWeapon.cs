using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
public class PrefabWeapon : MonoBehaviour {

	public Transform firePoint;
	public GameObject bulletPrefab;
	public Button shootButton;
	
	void Start ()
	{
		shootButton.onClick.AddListener(TaskOnClickShoot);
	}
	// Update is called once per frame
	void TaskOnClickShoot()
	{
		Shoot();
	}

	void Shoot ()
	{
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
	}
}
