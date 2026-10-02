using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.Models;

namespace TravelApp.ViewModels
{
    public partial class TravelViewModel : ObservableObject
    {
        [ObservableProperty]
        public List<TravelItem> _itens;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsLastPosition))]
        [NotifyPropertyChangedFor(nameof(ShowButton))]
        private int _position;

        public bool IsLastPosition => Position == Itens.Count - 1;

        public bool ShowButton => !IsLastPosition;

        public TravelViewModel()
        {
            Itens = new List<TravelItem>
            {
                new TravelItem
                {
                    ImageUrl = "inicio.png",
                    Title = "Explore\nExotic Destinations",
                    Description = "Embark on a virtual journey through stunning\ndestinations worldwide."
                },
                new TravelItem
                {
                    ImageUrl = "disco.png",
                    Title = "Discover\nLocal Gems",
                    Description = "Uncover hidden gems and local favorites\nrecommended by fellow travelers."
                },
                new TravelItem
                {
                    ImageUrl = "plan.png",
                    Title = "Plan\nYour Perfect Trip",
                    Description = "Create personalized itineraries tailored to your\npreferences and interests."
                },
                new TravelItem
                {
                    ImageUrl = "cap.png",
                    Title = "Capture and Share\nMemories",
                    Description = "Preserve your travel memories with our in-app\nphoto and journaling features."
                }
            };
        }

        [RelayCommand]
        public void Next()
        {
            if (Position < Itens.Count - 1)
            {
                Position++;
            }
        }
    }
}
