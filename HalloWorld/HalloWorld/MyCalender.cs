using System;
using Xamarin.Forms;

public class MyCalender : View
{
	public static readonly BindableProperty CurrentDateProperty = 
		BindableProperty.Create<MyCalender,DateTime>(p => p.CurrentDate,DateTime.Now);

	public DateTime CurrentDate
	{
		get {return (DateTime)GetValue (CurrentDateProperty);}
		set {SetValue (CurrentDateProperty,value);}
	}
}

