using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.ComponentModel;

namespace MyApp{
    public class Paddle {

        public int id{get; set;}
        public int yVelocity{get; set;}
        public int speed{get; set;}
        public int yPosition{get; set;}

        public Paddle(int yPosition){
            yPosition = this.yPosition;
        }
    }
}
