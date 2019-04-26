using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Auth;
using UnityEngine.SceneManagement;

public class FirebaseScript : MonoBehaviour {
	public InputField EmailAddress, Password;

	public void LoginButtonPressed() {
		FirebaseAuth.DefaultInstance.SignInWithEmailAndPasswordAsync (EmailAddress.text, Password.text).
			ContinueWith ((obj) => 
			{
				SceneManager.LoadSceneAsync("Hanoy");
			});
	}

	public void LoginAnonymousButtonPressed() {
		FirebaseAuth.DefaultInstance.SignInAnonymouslyAsync ().
			ContinueWith ((obj) => 
			{
				SceneManager.LoadSceneAsync("Hanoy");
			});
	}

	public void CreateNewUserButtonPressed() {
		FirebaseAuth.DefaultInstance.CreateUserWithEmailAndPasswordAsync (EmailAddress.text, Password.text).
			ContinueWith ((obj) => 
			{
				SceneManager.LoadSceneAsync("Hanoy");
			});
	}
}
