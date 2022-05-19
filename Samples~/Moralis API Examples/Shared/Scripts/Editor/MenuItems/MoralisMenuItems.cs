﻿using System.Collections.Generic;
using UnityEditor;
using MoralisUnity.Sdk.Constants;
using MoralisUnity.Sdk.UI.ReadMe;
using MoralisUnity.Sdk.Utilities;
using UnityEngine;
using System.IO;

namespace MoralisUnity.Examples.Sdk.Shared
{
	/// <summary>
	/// The MenuItem attribute allows you to add menu items to the main menu and inspector context menus.
	/// <see cref="https://docs.unity3d.com/ScriptReference/MenuItem.html"/>
	/// </summary>
	public static class MoralisMenuItems
	{

		[MenuItem(MoralisConstants.PathMoralisExamplesWindowMenu + "/" +
			ExampleConstants.MoralisAPIExamples + "/" + MoralisConstants.OpenReadMe, false,
			MoralisConstants.PriorityMoralisWindow_Examples)]
		static void OpenReadMe()
		{
			ReadMeEditor.SelectReadmeGuid("3b4d333465945474ea57ff6e62ba4f37");
		}


		[MenuItem(MoralisConstants.PathMoralisExamplesWindowMenu + "/" +
				   ExampleConstants.MoralisAPIExamples + "/" + "Add Example Scenes To Build Settings", false,
			MoralisConstants.PriorityMoralisWindow_Examples)]
		static void AddAllScenesToBuildSettings()
		{
			List<SceneAsset> sceneAssets = ExampleDiskStorage.Instance.SceneAssets;

			Debug.Log($"AddAllScenesToBuildSettings() sceneAssets.Count={sceneAssets.Count}");
			EditorBuildSettingsUtility.AddScenesToBuildSettings(sceneAssets);
		}


		[MenuItem(MoralisConstants.PathMoralisExamplesWindowMenu + "/" +
				   ExampleConstants.MoralisAPIExamples + "/" + "Load Example Layout (10x16)", false,
			MoralisConstants.PriorityMoralisWindow_Examples)]
		public static void LoadExampleLayout()
		{
			string path = Path.GetFullPath("Packages/io.moralis.web3-unity-sdk/Editor/Layouts/MoralisUnityLayout10x16.wlt");
			UnityReflectionUtility.UnityEditor_WindowLayout_LoadWindowLayout(path);
		}
	}
}
