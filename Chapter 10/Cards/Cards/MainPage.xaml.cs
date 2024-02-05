using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Cards
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		public const int NumHands = 4;
		private Pack pack = null;
		private Hand[] hands = new Hand[NumHands];

		public MainPage()
		{
			this.InitializeComponent();
		}

		private void dealClick(object sender, RoutedEventArgs e)
		{
			try
			{
				pack = new Pack();
				for (int i = 0; i < NumHands; i++) 
				{
					hands[i] = new Hand();
					for (int j = 0; j < Hand.HandSize; j++)
					{
						var cardDealt = pack.DealCardFromPack();
						hands[i].AddCardToHand(cardDealt);
					}
				}

				north.Text = hands[0].ToString();
				south.Text = hands[1].ToString();
				east.Text = hands[2].ToString();
				west.Text = hands[3].ToString();
				// TODO: deal the cards
			}
			catch (Exception ex)
			{
				MessageDialog msg = new MessageDialog(ex.Message, "Error");
				_ = msg.ShowAsync();
			}
		}
	}
}
