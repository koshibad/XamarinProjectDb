// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MeuDB {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class MyPage : ContentPage {
        
        private Entry Nome;
        
        private Entry Email;
        
        private Entry Telefone;
        
        private Button Salvar;
        
        private ListView Lista;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(MyPage));
            Nome = this.FindByName <Entry>("Nome");
            Email = this.FindByName <Entry>("Email");
            Telefone = this.FindByName <Entry>("Telefone");
            Salvar = this.FindByName <Button>("Salvar");
            Lista = this.FindByName <ListView>("Lista");
        }
    }
}
