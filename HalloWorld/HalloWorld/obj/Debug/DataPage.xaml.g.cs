// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace HalloWorld {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class DataPage : ContentPage {
        
        private Entry text1;
        
        private Entry text2;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(DataPage));
            text1 = this.FindByName <Entry>("text1");
            text2 = this.FindByName <Entry>("text2");
        }
    }
}
