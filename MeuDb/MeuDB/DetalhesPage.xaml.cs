using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MeuDB
{
	public partial class DetalhesPage : ContentPage
	{
		public DetalhesPage(Contato dados)
		{
			InitializeComponent();

			txtID.Text = dados.Id.ToString();
			txtEmail.Text = dados.Email;
			txtNome.Text = dados.Nome;
			txtTelefone.Text = dados.Telefone;
		}

		void Salvar_Clicked(object sender, System.EventArgs e)
		{
			var contato = new Contato
			{
				Id = int.Parse(txtID.Text),
				Nome = txtNome.Text,
				Email = txtEmail.Text,
				Telefone = txtTelefone.Text
			};

			using (var dados = new AcessoDados())
			{
				dados.Update(contato);
			}

			Navigation.PopModalAsync();
		}

		void Cancelar_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}

