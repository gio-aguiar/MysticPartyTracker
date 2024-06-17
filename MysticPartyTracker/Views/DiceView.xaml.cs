using MysticPartyTracker.Models;
using MysticPartyTracker.ViewModels;
namespace MysticPartyTracker.Views;

public partial class DiceView : ContentPage
{
    public DiceView()
    {
        InitializeComponent();
        SidesPicker.SelectedIndex = 0;
        QuantityPicker.SelectedIndex = 0;
        BindingContext = new DiceViewModel();
    }

    private void RollBtn_Clicked(object sender, EventArgs e)
    {
        /*
        AllDicesResultLabel.Text = "";
        //Pegar a quantidade de dados que o usuário selecionou
        int quantidade = Convert.ToInt32(QuantityPicker.SelectedItem);
        //Pegar a quantidade de lados dos dados
        int lados = Convert.ToInt32(SidesPicker.SelectedItem);
        int total = 0;

        //Sortear o valor de cada dado
        //Exibir o valor dos dados na tela
        for (int i = 0; i < quantidade; i++)
        {
            int resultado = new Dice(lados).Roll();
            //total = total + resultado;
            total += resultado;

            AllDicesResultLabel.Text += resultado.ToString() + "\n";
            resultString.Text = total.ToString();
        }
        */



        int numberSides = (int)SidesPicker.SelectedItem;
        int quantity = (int)QuantityPicker.SelectedItem;

        Dice dice = new(numberSides);

        string finalResult = "";
        int total = 0;

        for (int i = 0; i < quantity; i++)
        {
            int roll = dice.Roll();
            Console.WriteLine(roll);
            total += roll;
            finalResult += $"Dado {i + 1} = {roll} \n";
            if (i < quantity - 1)
                finalResult += "\n";
        }

        resultString.Text = $"Foram jogados {quantity} dado(s) de {numberSides} lados.";


    }

}
