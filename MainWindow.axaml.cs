using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.ComponentModel;
using Avalonia.Input;
using System;

namespace MyApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }

    public class MainWindowViewModel : INotifyPropertyChanged
    {   
        public static int PANEL_WIDTH = 800;
        public static int PANEL_HEIGHT = 450;
        string buttonText = "Click Me!";

        public string ButtonText
        {
            get => buttonText;
            set 
            {
                buttonText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ButtonText)));
            }
        }
        Paddle p1 = new Paddle(PANEL_HEIGHT/2 - 40);
        
        Paddle p2 = new Paddle(PANEL_HEIGHT/2 - 40);
        
        public void WPressed(){
            // RedMove += 1;

            if(RedMove <= 0){
                return;
            }else{
                RedMove += -1;
            }
        }

        public void SPressed(){
            // RedMove += 1;

            if(RedMove >= PANEL_HEIGHT-80){
                return;
            }else{
                RedMove += +1;
            }
        }

        public void UpPressed(){

            if(BluMove <= 0){
                return;
            }else{
                BluMove += -1;
            }
        }

        public void DownPressed(){

            if(BluMove >= PANEL_HEIGHT-80){
                return;
            }else{
                BluMove += +1;
            }
        }

        public int RedMove{

            get => p1.yPosition;
            set{
                p1.yPosition = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RedMove)));
            }
        }
        public int BluMove{

            get => p2.yPosition;
            set{
                p2.yPosition = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BluMove)));
            }
        }

        // int redLocation;
        // public int RedMove {
        //     get => redLocation;
        //     set {
        //         redLocation = value;
        //         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RedMove)));
        //     }
        // }

        public event PropertyChangedEventHandler PropertyChanged;

        

        public void ButtonClicked() => ButtonText = "Hello, Avalonia!";
    }
}