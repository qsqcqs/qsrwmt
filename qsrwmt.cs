using BepInEx;
namespace qsrwm
{


	[BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
	public class QRWM : BaseUnityPlugin
	{
		public const string PLUGIN_GUID = "qsrwm";
		public const string PLUGIN_NAME = "nya~ >///<";		
		public const string PLUGIN_VERSION = "1.0";



		private void OnEnable()
		{
			base.Logger.LogMessage("aaa oh god wtf pls work nya nya nya pls for the love of god");
			On.Player.Update += PlayerUpdateHook;
		}
		
		void PlayerUpdateHook(On.Player.orig_Update orig, Player self, bool eu)
	    	{
	        // Whenever Player.Update gets called by the game, it takes a detour into your code here instead.
			// Do anything that you need to happen when the player updates in here.
			
	        orig(self, eu); // Then, use this to to tell the game that it needs to run the normal code (and other mods' hooks) now.
	
			// And optionally, you can have more code here too, after orig
			// In general, you will want to always try to call orig
			// If you skip calling orig, this prevents all other mods from running their own hooks
			// and it also stops the game from doing the vanilla behavior.

	    	}

	}
}
