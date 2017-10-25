using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Material
{
    class Menu
    {
        public void MenuItem(Button ElementExp1, Button ElementExp2, Button ElementExp3, Button ElementExp4, Button ElementExp5, Button ElementExp6, int count)
        {
            var bc = new BrushConverter();

            if (count == 1)
            {
                ElementExp1.BorderBrush = (Brush)bc.ConvertFrom("#000");
                ElementExp1.BorderThickness = new Thickness(0.3);
                ElementExp2.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                ElementExp2.BorderThickness = new Thickness(0.3);
                ElementExp3.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                ElementExp3.BorderThickness = new Thickness(0.3);
                ElementExp4.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                ElementExp4.BorderThickness = new Thickness(0.3);
                ElementExp5.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                ElementExp5.BorderThickness = new Thickness(0.3);
                ElementExp6.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                ElementExp6.BorderThickness = new Thickness(0.3);

                ElementExp1.Background = (Brush)bc.ConvertFrom("#ffffff");
                ElementExp2.Background = (Brush)bc.ConvertFrom("#fafafa");
                ElementExp3.Background = (Brush)bc.ConvertFrom("#fafafa");
                ElementExp4.Background = (Brush)bc.ConvertFrom("#fafafa");
                ElementExp5.Background = (Brush)bc.ConvertFrom("#fafafa");
                ElementExp6.Background = (Brush)bc.ConvertFrom("#fafafa");
            }
            else
                if(count == 2)
                {             
                ElementExp1.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                ElementExp1.BorderThickness = new Thickness(0.3);
                ElementExp2.BorderBrush = (Brush)bc.ConvertFrom("#000");
                ElementExp2.BorderThickness = new Thickness(0.3);
                ElementExp3.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                ElementExp3.BorderThickness = new Thickness(0.3);
                ElementExp4.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                ElementExp4.BorderThickness = new Thickness(0.3);
                ElementExp5.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                ElementExp5.BorderThickness = new Thickness(0.3);
                ElementExp6.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                ElementExp6.BorderThickness = new Thickness(0.3);


                ElementExp1.Background = (Brush)bc.ConvertFrom("#fafafa");
                ElementExp2.Background = (Brush)bc.ConvertFrom("#ffffff");
                ElementExp3.Background = (Brush)bc.ConvertFrom("#fafafa");
                ElementExp4.Background = (Brush)bc.ConvertFrom("#fafafa");
                ElementExp5.Background = (Brush)bc.ConvertFrom("#fafafa");
                ElementExp6.Background = (Brush)bc.ConvertFrom("#fafafa");
                }
                else
                    if(count == 3)
                    {
                    ElementExp1.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                    ElementExp1.BorderThickness = new Thickness(0.3);
                    ElementExp2.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                    ElementExp2.BorderThickness = new Thickness(0.3);
                    ElementExp3.BorderBrush = (Brush)bc.ConvertFrom("#000");
                    ElementExp3.BorderThickness = new Thickness(0.3);
                    ElementExp4.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                    ElementExp4.BorderThickness = new Thickness(0.3);
                    ElementExp5.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                    ElementExp5.BorderThickness = new Thickness(0.3);
                    ElementExp6.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                    ElementExp6.BorderThickness = new Thickness(0.3);

                    ElementExp1.Background = (Brush)bc.ConvertFrom("#fafafa");
                    ElementExp2.Background = (Brush)bc.ConvertFrom("#fafafa");
                    ElementExp3.Background = (Brush)bc.ConvertFrom("#ffffff");
                    ElementExp4.Background = (Brush)bc.ConvertFrom("#fafafa");
                    ElementExp5.Background = (Brush)bc.ConvertFrom("#fafafa");
                    ElementExp6.Background = (Brush)bc.ConvertFrom("#fafafa");
                    }
                    else
                        if(count == 4)
                        {
                        ElementExp1.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                        ElementExp1.BorderThickness = new Thickness(0.3);
                        ElementExp2.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                        ElementExp2.BorderThickness = new Thickness(0.3);
                        ElementExp3.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                        ElementExp3.BorderThickness = new Thickness(0.3);
                        ElementExp4.BorderBrush = (Brush)bc.ConvertFrom("#000");
                        ElementExp4.BorderThickness = new Thickness(0.3);
                        ElementExp5.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                        ElementExp5.BorderThickness = new Thickness(0.3);
                        ElementExp6.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                        ElementExp6.BorderThickness = new Thickness(0.3);

                        ElementExp1.Background = (Brush)bc.ConvertFrom("#fafafa");
                        ElementExp2.Background = (Brush)bc.ConvertFrom("#fafafa");
                        ElementExp3.Background = (Brush)bc.ConvertFrom("#fafafa");
                        ElementExp4.Background = (Brush)bc.ConvertFrom("#ffffff");
                        ElementExp5.Background = (Brush)bc.ConvertFrom("#fafafa");
                        ElementExp6.Background = (Brush)bc.ConvertFrom("#fafafa");
                        }
                        else
                            if(count == 5)
                            {
                            ElementExp1.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                            ElementExp1.BorderThickness = new Thickness(0.3);
                            ElementExp2.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                            ElementExp2.BorderThickness = new Thickness(0.3);
                            ElementExp3.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                            ElementExp3.BorderThickness = new Thickness(0.3);
                            ElementExp4.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                            ElementExp4.BorderThickness = new Thickness(0.3);
                            ElementExp5.BorderBrush = (Brush)bc.ConvertFrom("#000");
                            ElementExp5.BorderThickness = new Thickness(0.3);
                            ElementExp6.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                            ElementExp6.BorderThickness = new Thickness(0.3);

                            ElementExp1.Background = (Brush)bc.ConvertFrom("#fafafa");
                            ElementExp2.Background = (Brush)bc.ConvertFrom("#fafafa");
                            ElementExp3.Background = (Brush)bc.ConvertFrom("#fafafa");
                            ElementExp4.Background = (Brush)bc.ConvertFrom("#fafafa");
                            ElementExp5.Background = (Brush)bc.ConvertFrom("#ffffff");
                            ElementExp6.Background = (Brush)bc.ConvertFrom("#fafafa");
                            }
                            else
                                if(count == 6)
                                {
                                ElementExp1.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                                ElementExp1.BorderThickness = new Thickness(0.3);
                                ElementExp2.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                                ElementExp2.BorderThickness = new Thickness(0.3);
                                ElementExp3.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                                ElementExp3.BorderThickness = new Thickness(0.3);
                                ElementExp4.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                                ElementExp4.BorderThickness = new Thickness(0.3);
                                ElementExp5.BorderBrush = (Brush)bc.ConvertFrom("#e1e1e1");
                                ElementExp5.BorderThickness = new Thickness(0.3);
                                ElementExp6.BorderBrush = (Brush)bc.ConvertFrom("#000");
                                ElementExp6.BorderThickness = new Thickness(0.3);

                                ElementExp1.Background = (Brush)bc.ConvertFrom("#fafafa");
                                ElementExp2.Background = (Brush)bc.ConvertFrom("#fafafa");
                                ElementExp3.Background = (Brush)bc.ConvertFrom("#fafafa");
                                ElementExp4.Background = (Brush)bc.ConvertFrom("#fafafa");
                                ElementExp5.Background = (Brush)bc.ConvertFrom("#fafafa");
                                ElementExp6.Background = (Brush)bc.ConvertFrom("#ffffff");
                                }
        }
    }
}
