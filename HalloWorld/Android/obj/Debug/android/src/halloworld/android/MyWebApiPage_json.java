package halloworld.android;


public class MyWebApiPage_json
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("HalloWorld.Android.MyWebApiPage_json, HalloWorld.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MyWebApiPage_json.class, __md_methods);
	}


	public MyWebApiPage_json () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MyWebApiPage_json.class)
			mono.android.TypeManager.Activate ("HalloWorld.Android.MyWebApiPage_json, HalloWorld.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
