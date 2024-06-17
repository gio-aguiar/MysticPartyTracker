using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MysticPartyTracker.Models;
using MysticPartyTracker.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;
using MysticPartyTracker.Utils;



namespace MysticPartyTracker.ViewModels
{
    internal partial class MagiaViewModel : ObservableObject
    {

        private readonly MagiaService _service;

        [ObservableProperty]
        public int _count;

        [ObservableProperty]
        public ObservableCollection<Magia> _magias;

        public ICommand GetAllMagiasCommand { get; set;  }
        public MagiaViewModel()
        {
            _service = new MagiaService(); 
            GetAllMagiasCommand = new Command(async () => await LoadMagiasAsync()); 
            Task.Run(async () => await LoadMagiasAsync());
        }

        private async Task LoadMagiasAsync()
        {
            try
            {
                MagiaResponse magiaResponse = await _service.GetAllMagiasAsync();
               Magias = new ObservableCollection<Magia>((IEnumerable<Magia>)magiaResponse.Results);
               Count = magiaResponse.Count;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
