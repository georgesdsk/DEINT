using Microsoft.Toolkit.Uwp.UI.Animations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace PruebasAnimaciones
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        

        public MainPage()
        {
            this.InitializeComponent();

            //SendimageHome(CrearButton(),10,10,10);
            SendimageHome(MiRectangulo,10,10,10);
            
            
        }


        public void SendimageHome(FrameworkElement image, double fromX, double fromY, double scale)
        {
            Storyboard storyboardMovimiento = new Storyboard();
            Storyboard storyboardTamanio = new Storyboard();


            // image is the target element 
            ////
            ///
            DoubleAnimation animateScaleX = CreateDoubleAnimation(image, 100, 0.6, "(Canvas.Top)", 1.5);
            storyboardTamanio.Children.Add(animateScaleX);

            DoubleAnimation animacionTamanio = CreateDoubleAnimation(image, 100, 1, "Rectangle.Width", 1.5);
            animacionTamanio.EnableDependentAnimation = true;
            storyboardTamanio.Children.Add(animacionTamanio);


            storyboardTamanio.RepeatBehavior = RepeatBehavior.Forever;
            storyboardTamanio.Begin();
        }


        public Button CrearButton() {

            ScaleTransform sc = new ScaleTransform { ScaleX = 20, ScaleY = 20 }; // esto funciona y se crea
            TranslateTransform translate = new TranslateTransform { X = 0, Y = 0 };
            TransformGroup transformGroup = new TransformGroup();
            transformGroup.Children.Add(sc);
            transformGroup.Children.Add(translate);
            
            Button boton = new Button {
                Width = 10,
                Height = 10,
                RenderTransform = transformGroup
            };

            miCanvas.Children.Add(boton);


            return boton;
            //SendimageHome(boton, 100, 100, 200);

        
        }


        private  DoubleAnimation CreateDoubleAnimation(DependencyObject frameworkElement, double fromX, double toX, string propertyToAnimate, Double interval)
        {
            DoubleAnimation animation = new DoubleAnimation();
          //  animation.EnableDependentAnimation = true;
            Storyboard.SetTarget(animation, frameworkElement);
            Storyboard.SetTargetProperty(animation, propertyToAnimate);
            animation.From = fromX;
            animation.To = toX;
            animation.Duration = TimeSpan.FromSeconds(interval);
            return animation;
        }


        //private void crearAnimacion()
        //{
        //    Storyboard str = new Storyboard();
        //    DoubleAnimation dbAnimationEjeX = new DoubleAnimation();// tamanio x
        //    DoubleAnimation dbAnimationEjeY = new DoubleAnimation();
        //    ScaleTransition scale = new ScaleTransfor();
        //    dbAnimationEjeX.AutoReverse = true;
        //    dbAnimationEjeX.RepeatBehavior = RepeatBehavior.Forever;
        //    MiRectangulo.Scale = scale;
        //    //dbAnimationEjeY.RepeatBehavior = RepeatBehavior.Forever;
        //    //dbAnimationEjeY.AutoReverse = true;
        //    dbAnimationEjeX.From = 600;
        //    dbAnimationEjeX.To = 2000;
        //    dbAnimationEjeX.Duration = TimeSpan.FromSeconds(5); // tendra que ser una variable que se cambie que se cambie segun la velocidad de la aplicacion
        //    TranslateTransform movedor = new TranslateTransform();
        //    str.Children.Add(dbAnimationEjeX);
        //    Storyboard.SetTarget(dbAnimationEjeX, scale);
        //    Storyboard.SetTargetProperty(str, "ScaleX");
        //    str.Begin();

        //}





        //private void animarYConfigurarElementos(Random r, Border borde2, DoubleAnimation dbAnimationEjeX, DoubleAnimation dbAnimationEjeY, Storyboard str)
        //{
        //    dbAnimationEjeX.AutoReverse = true;
        //    dbAnimationEjeX.RepeatBehavior = RepeatBehavior.Forever;
        //    dbAnimationEjeY.AutoReverse = true;
        //    dbAnimationEjeY.To = r.Next(-1000, 1000);
        //    dbAnimationEjeY.RepeatBehavior = RepeatBehavior.Forever;
        //    dbAnimationEjeX.To = r.Next(-1000, 1000);
        //    TranslateTransform moveTransform = new TranslateTransform();
        //    moveTransform.X = r.Next(-1000, 1000);
        //    moveTransform.Y = r.Next(-1000, 1000);
        //    borde2.RenderTransform = moveTransform;
        //    dbAnimationEjeX.Duration = new Duration(TimeSpan.FromSeconds(10));
        //    dbAnimationEjeY.Duration = new Duration(TimeSpan.FromSeconds(10));
        //    str.Children.Add(dbAnimationEjeX);
        //    str.Children.Add(dbAnimationEjeY);
        //    Storyboard.SetTarget(dbAnimationEjeY, moveTransform);
        //    Storyboard.SetTarget(dbAnimationEjeX, moveTransform);
        //    Storyboard.SetTargetProperty(dbAnimationEjeY, "Y");
        //    Storyboard.SetTargetProperty(dbAnimationEjeX, "X");
        //    RelativePanel.SetAlignHorizontalCenterWithPanel(borde2, true);
        //    RelativePanel.SetBelow(borde2, stckMenu);
        //    rltRoot.Children.Add(borde2);
        //    str.Begin();
        //}


    }
}
